using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DNShift
{
    public partial class Form1 : Form
    {
        private class DnsPreset
        {
            public string Name;
            public string V4Primary;
            public string V4Secondary;
            public string V6Primary;
            public string V6Secondary;
            public override string ToString() { return Name; }
        }

        private class AdapterItem
        {
            public string Name;          // nama koneksi, dipakai netsh
            public string Description;
            public override string ToString() { return Name + "  (" + Description + ")"; }
        }

        private List<DnsPreset> presets;
        private bool suppressPresetEvent = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildPresets();
            LoadAdapters();
        }

        // ---------- Preset ----------

        private void BuildPresets()
        {
            presets = new List<DnsPreset>
            {
                new DnsPreset { Name = "-- Custom --", V4Primary = "", V4Secondary = "", V6Primary = "", V6Secondary = "" },
                new DnsPreset { Name = "Cloudflare",        V4Primary = "1.1.1.1",  V4Secondary = "1.0.0.1",
                                V6Primary = "2606:4700:4700::1111", V6Secondary = "2606:4700:4700::1001" },
                new DnsPreset { Name = "Cloudflare (Malware Blocking)", V4Primary = "1.1.1.2", V4Secondary = "1.0.0.2",
                                V6Primary = "2606:4700:4700::1112", V6Secondary = "2606:4700:4700::1002" },
                new DnsPreset { Name = "Google Public DNS", V4Primary = "8.8.8.8",  V4Secondary = "8.8.4.4",
                                V6Primary = "2001:4860:4860::8888", V6Secondary = "2001:4860:4860::8844" },
                new DnsPreset { Name = "Quad9 (Security)",  V4Primary = "9.9.9.9",  V4Secondary = "149.112.112.112",
                                V6Primary = "2620:fe::fe", V6Secondary = "2620:fe::9" },
                new DnsPreset { Name = "OpenDNS",           V4Primary = "208.67.222.222", V4Secondary = "208.67.220.220",
                                V6Primary = "2620:119:35::35", V6Secondary = "2620:119:53::53" },
                new DnsPreset { Name = "AdGuard DNS (Ad Blocking)", V4Primary = "94.140.14.14", V4Secondary = "94.140.15.15",
                                V6Primary = "2a10:50c0::ad1:ff", V6Secondary = "2a10:50c0::ad2:ff" }
            };

            cmbPresets.Items.Clear();
            foreach (var p in presets) cmbPresets.Items.Add(p);
            suppressPresetEvent = true;
            cmbPresets.SelectedIndex = 0;
            suppressPresetEvent = false;
        }

        private void cmbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressPresetEvent) return;
            var p = cmbPresets.SelectedItem as DnsPreset;
            if (p == null || p.Name == "-- Custom --") return;

            txt4P.Text = p.V4Primary;
            txt4S.Text = p.V4Secondary;
            txt6P.Text = p.V6Primary;
            txt6S.Text = p.V6Secondary;
        }

        // ---------- Adapter ----------

        private void LoadAdapters()
        {
            cmbAdapters.Items.Clear();

            var nics = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback
                         && n.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
                .OrderByDescending(n => n.OperationalStatus == OperationalStatus.Up);

            foreach (var n in nics)
            {
                cmbAdapters.Items.Add(new AdapterItem
                {
                    Name = n.Name,
                    Description = n.OperationalStatus == OperationalStatus.Up ? "Connected" : "Disconnected"
                });
            }

            if (cmbAdapters.Items.Count > 0)
                cmbAdapters.SelectedIndex = 0;
            else
                SetStatus("No network adapter found.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdapters();
            SetStatus("Adapter list refreshed.");
        }

        private void cmbAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCurrentDns();
        }

        private void ShowCurrentDns()
        {
            valCur4P.Text = "—";
            valCur4S.Text = "—";
            valCur6P.Text = "—";
            valCur6S.Text = "—";

            var item = cmbAdapters.SelectedItem as AdapterItem;
            if (item == null) return;

            var nic = NetworkInterface.GetAllNetworkInterfaces()
                        .FirstOrDefault(n => n.Name == item.Name);
            if (nic == null) return;

            try
            {
                var dns = nic.GetIPProperties().DnsAddresses;

                var v4 = dns.Where(a => a.AddressFamily == AddressFamily.InterNetwork).ToList();
                var v6 = dns.Where(a => a.AddressFamily == AddressFamily.InterNetworkV6).ToList();

                if (v4.Count > 0) valCur4P.Text = v4[0].ToString();
                if (v4.Count > 1) valCur4S.Text = v4[1].ToString();
                if (v6.Count > 0) valCur6P.Text = v6[0].ToString();
                if (v6.Count > 1) valCur6S.Text = v6[1].ToString();
            }
            catch (Exception ex)
            {
                SetStatus("Failed to read DNS: " + ex.Message);
            }
        }

        // ---------- Apply ----------

        private void btnApply_Click(object sender, EventArgs e)
        {
            var item = cmbAdapters.SelectedItem as AdapterItem;
            if (item == null)
            {
                MessageBox.Show("Please select a network adapter.", "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string v4p = txt4P.Text.Trim();
            string v4s = txt4S.Text.Trim();
            string v6p = txt6P.Text.Trim();
            string v6s = txt6S.Text.Trim();

            if (v4p == "" && v6p == "")
            {
                MessageBox.Show("Enter at least one primary DNS address (IPv4 or IPv6).", "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateField(v4p, AddressFamily.InterNetwork, "IPv4 Primary")) return;
            if (!ValidateField(v4s, AddressFamily.InterNetwork, "IPv4 Secondary")) return;
            if (!ValidateField(v6p, AddressFamily.InterNetworkV6, "IPv6 Primary")) return;
            if (!ValidateField(v6s, AddressFamily.InterNetworkV6, "IPv6 Secondary")) return;

            Cursor = Cursors.WaitCursor;
            try
            {
                string iface = item.Name;

                if (v4p != "")
                {
                    RunNetsh(string.Format(
                        "interface ipv4 set dnsservers name=\"{0}\" source=static address={1} register=primary validate=no",
                        iface, v4p));

                    if (v4s != "")
                        RunNetsh(string.Format(
                            "interface ipv4 add dnsservers name=\"{0}\" address={1} index=2 validate=no",
                            iface, v4s));
                }

                if (v6p != "")
                {
                    RunNetsh(string.Format(
                        "interface ipv6 set dnsservers name=\"{0}\" source=static address={1} register=primary validate=no",
                        iface, v6p));

                    if (v6s != "")
                        RunNetsh(string.Format(
                            "interface ipv6 add dnsservers name=\"{0}\" address={1} index=2 validate=no",
                            iface, v6s));
                }

                ShowCurrentDns();
                SetStatus("DNS applied to " + iface + ".");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to apply DNS:\n" + ex.Message, "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Apply failed.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool ValidateField(string value, AddressFamily family, string label)
        {
            if (string.IsNullOrEmpty(value)) return true;

            IPAddress ip;
            if (!IPAddress.TryParse(value, out ip) || ip.AddressFamily != family)
            {
                MessageBox.Show(label + " is not a valid address.", "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ---------- Restore ----------

        private void btnRestore_Click(object sender, EventArgs e)
        {
            var item = cmbAdapters.SelectedItem as AdapterItem;
            if (item == null)
            {
                MessageBox.Show("Please select a network adapter.", "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                RunNetsh(string.Format("interface ipv4 set dnsservers name=\"{0}\" source=dhcp", item.Name));
                RunNetsh(string.Format("interface ipv6 set dnsservers name=\"{0}\" source=dhcp", item.Name));

                ShowCurrentDns();
                SetStatus("DNS restored to automatic (DHCP).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to restore DNS:\n" + ex.Message, "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Restore failed.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // ---------- Flush ----------

        private void btnFlush_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RunHidden("ipconfig", "/flushdns");
                SetStatus("DNS cache flushed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to flush DNS cache:\n" + ex.Message, "DNShift",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetStatus("Flush failed.");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // ---------- Tampilan ----------

        private void card_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(ColBorder))
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            using (var b = new SolidBrush(ColMark))
                e.Graphics.FillRectangle(b, 0, 0, 3, 26);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(Color.FromArgb(70, 70, 76), 1))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        private void lnkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { Process.Start("https://minanatech.com"); }
            catch { MessageBox.Show("Could not open the browser.", "DNShift"); }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var f = new InfoForm(InfoForm.Mode.About)) f.ShowDialog(this);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            using (var f = new InfoForm(InfoForm.Mode.Help)) f.ShowDialog(this);
        }

        // ---------- Helper ----------

        private void RunNetsh(string arguments)
        {
            RunHidden("netsh", arguments);
        }

        private void RunHidden(string fileName, string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (var p = Process.Start(psi))
            {
                string output = p.StandardOutput.ReadToEnd();
                string error = p.StandardError.ReadToEnd();
                p.WaitForExit();

                if (p.ExitCode != 0)
                {
                    string msg = !string.IsNullOrWhiteSpace(error) ? error : output;
                    throw new Exception(string.IsNullOrWhiteSpace(msg)
                        ? fileName + " exited with code " + p.ExitCode
                        : msg.Trim());
                }
            }
        }

        private void SetStatus(string text)
        {
            lblStatus.Text = text;
            bool bad = text.IndexOf("fail", StringComparison.OrdinalIgnoreCase) >= 0
                    || text.IndexOf("no network", StringComparison.OrdinalIgnoreCase) >= 0;
            lblStatusDot.ForeColor = bad ? ColDanger : ColText;
        }
    }
}