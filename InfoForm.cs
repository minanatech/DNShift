using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DNShift
{
    public class InfoForm : Form
    {
        public enum Mode { About, Help }

        public InfoForm(Mode mode)
        {
            BackColor = Form1.ColBg;
            ForeColor = Form1.ColText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(500, mode == Mode.About ? 310 : 470);
            Text = mode == Mode.About ? "About DNShift" : "How to use DNShift";

            var header = new Panel
            {
                BackColor = Form1.ColPanel,
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 56)
            };
            header.Paint += (s, e) =>
            {
                using (var pen = new Pen(Form1.ColAccent, 2))
                    e.Graphics.DrawLine(pen, 0, header.Height - 1, header.Width, header.Height - 1);
            };
            Controls.Add(header);

            header.Controls.Add(new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Form1.ColAccent,
                Location = new Point(18, 14),
                Text = mode == Mode.About ? "DNShift" : "How to use"
            });

            var body = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Form1.ColText,
                Font = new Font("Segoe UI", 9F),
                Location = new Point(20, 72),
                Size = new Size(460, ClientSize.Height - 72 - 92),
                Text = mode == Mode.About ? AboutText() : HelpText()
            };
            Controls.Add(body);

            var link = new LinkLabel
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                LinkColor = Form1.ColAccent,
                ActiveLinkColor = Color.White,
                LinkBehavior = LinkBehavior.HoverUnderline,
                Location = new Point(20, ClientSize.Height - 78),
                Text = "minanatech.com"
            };
            link.LinkClicked += (s, e) =>
            {
                try { Process.Start("https://minanatech.com"); } catch { }
            };
            Controls.Add(link);

            var btnClose = new Button
            {
                FlatStyle = FlatStyle.Flat,
                BackColor = Form1.ColAccentDk,
                ForeColor = Color.FromArgb(10, 16, 20),
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                Size = new Size(110, 32),
                Location = new Point(ClientSize.Width - 130, ClientSize.Height - 46),
                Text = "Close",
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);
            AcceptButton = btnClose;
        }

        private string AboutText()
        {
            return
                "Version 1.0\r\n\r\n" +
                "DNShift is free software. There is no cost, no trial period, " +
                "no ads and no in-app purchases. It does not collect or transmit " +
                "any personal data.\r\n\r\n" +
                "Developed and published by minanatech.com. Always download it from " +
                "the official website to make sure you get an unmodified copy.";
        }

        private string HelpText()
        {
            return
                "1.  Select a network adapter\r\n" +
                "     Pick the connection you are using, usually Wi-Fi or Ethernet.\r\n\r\n" +
                "2.  Choose a DNS\r\n" +
                "     Pick a provider from the preset list, or type your own addresses\r\n" +
                "     in the fields below. You can fill in IPv4, IPv6, or both.\r\n\r\n" +
                "3.  Click Apply DNS\r\n" +
                "     The new settings take effect immediately. The Current DNS panel\r\n" +
                "     will show what is active.\r\n\r\n" +
                "4.  Going back\r\n" +
                "     Restore to DHCP returns the adapter to the automatic settings\r\n" +
                "     provided by your router or internet provider.\r\n\r\n" +
                "Flush DNS Cache clears locally cached lookups. Useful after changing\r\n" +
                "DNS, or when a site still resolves to an old address.\r\n\r\n" +
                "Administrator rights are required to change network settings.";
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.SuspendLayout();
            // 
            // InfoForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.ResumeLayout(false);

        }
    }
}