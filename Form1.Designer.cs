using System.Drawing;
using System.Windows.Forms;

namespace DNShift
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        // ---- palet monokrom (dipakai Form1.cs & InfoForm.cs) ----
        public static readonly Color ColBg = Color.FromArgb(24, 24, 26);
        public static readonly Color ColPanel = Color.FromArgb(32, 32, 35);
        public static readonly Color ColPanel2 = Color.FromArgb(44, 44, 48);
        public static readonly Color ColBorder = Color.FromArgb(62, 62, 68);
        public static readonly Color ColAccent = Color.FromArgb(240, 240, 245);
        public static readonly Color ColAccentDk = Color.FromArgb(228, 228, 234);
        public static readonly Color ColText = Color.FromArgb(232, 232, 236);
        public static readonly Color ColTextDim = Color.FromArgb(142, 142, 150);
        public static readonly Color ColSection = Color.FromArgb(170, 170, 178);
        public static readonly Color ColMark = Color.FromArgb(110, 110, 118);
        public static readonly Color ColDanger = Color.FromArgb(200, 92, 92);

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlAdapter = new System.Windows.Forms.Panel();
            this.lblSecAdapter = new System.Windows.Forms.Label();
            this.cmbAdapters = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlCurrent = new System.Windows.Forms.Panel();
            this.lblSecCurrent = new System.Windows.Forms.Label();
            this.lblCur4P = new System.Windows.Forms.Label();
            this.valCur4P = new System.Windows.Forms.Label();
            this.lblCur4S = new System.Windows.Forms.Label();
            this.valCur4S = new System.Windows.Forms.Label();
            this.lblCur6P = new System.Windows.Forms.Label();
            this.valCur6P = new System.Windows.Forms.Label();
            this.lblCur6S = new System.Windows.Forms.Label();
            this.valCur6S = new System.Windows.Forms.Label();
            this.pnlSet = new System.Windows.Forms.Panel();
            this.lblSecSet = new System.Windows.Forms.Label();
            this.lblPreset = new System.Windows.Forms.Label();
            this.cmbPresets = new System.Windows.Forms.ComboBox();
            this.lblSet4P = new System.Windows.Forms.Label();
            this.txt4P = new System.Windows.Forms.TextBox();
            this.lblSet4S = new System.Windows.Forms.Label();
            this.txt4S = new System.Windows.Forms.TextBox();
            this.lblSet6P = new System.Windows.Forms.Label();
            this.txt6P = new System.Windows.Forms.TextBox();
            this.lblSet6S = new System.Windows.Forms.Label();
            this.txt6S = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnFlush = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatusDot = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlAdapter.SuspendLayout();
            this.pnlCurrent.SuspendLayout();
            this.pnlSet.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTagline);
            this.pnlHeader.Controls.Add(this.lnkSite);
            this.pnlHeader.Controls.Add(this.btnHelp);
            this.pnlHeader.Controls.Add(this.btnAbout);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(660, 74);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DNShift";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblTagline.Location = new System.Drawing.Point(23, 44);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(197, 13);
            this.lblTagline.TabIndex = 1;
            this.lblTagline.Text = "Free DNS changer for Windows  •  by";
            // 
            // lnkSite
            // 
            this.lnkSite.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkSite.AutoSize = true;
            this.lnkSite.BackColor = System.Drawing.Color.Transparent;
            this.lnkSite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lnkSite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lnkSite.Location = new System.Drawing.Point(212, 44);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(93, 13);
            this.lnkSite.TabIndex = 2;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "minanatech.com";
            this.lnkSite.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lnkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSite_LinkClicked);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnHelp.Location = new System.Drawing.Point(478, 24);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(76, 28);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "How to use";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnAbout.Location = new System.Drawing.Point(562, 24);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(76, 28);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlAdapter
            // 
            this.pnlAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.pnlAdapter.Controls.Add(this.lblSecAdapter);
            this.pnlAdapter.Controls.Add(this.cmbAdapters);
            this.pnlAdapter.Controls.Add(this.btnRefresh);
            this.pnlAdapter.Location = new System.Drawing.Point(16, 90);
            this.pnlAdapter.Name = "pnlAdapter";
            this.pnlAdapter.Size = new System.Drawing.Size(628, 76);
            this.pnlAdapter.TabIndex = 1;
            this.pnlAdapter.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // lblSecAdapter
            // 
            this.lblSecAdapter.AutoSize = true;
            this.lblSecAdapter.BackColor = System.Drawing.Color.Transparent;
            this.lblSecAdapter.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecAdapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.lblSecAdapter.Location = new System.Drawing.Point(16, 12);
            this.lblSecAdapter.Name = "lblSecAdapter";
            this.lblSecAdapter.Size = new System.Drawing.Size(110, 13);
            this.lblSecAdapter.TabIndex = 0;
            this.lblSecAdapter.Text = "NETWORK ADAPTER";
            // 
            // cmbAdapters
            // 
            this.cmbAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmbAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdapters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAdapters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbAdapters.FormattingEnabled = true;
            this.cmbAdapters.Location = new System.Drawing.Point(16, 36);
            this.cmbAdapters.Name = "cmbAdapters";
            this.cmbAdapters.Size = new System.Drawing.Size(486, 23);
            this.cmbAdapters.TabIndex = 1;
            this.cmbAdapters.SelectedIndexChanged += new System.EventHandler(this.cmbAdapters_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnRefresh.Location = new System.Drawing.Point(516, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 26);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.pnlCurrent.Controls.Add(this.lblSecCurrent);
            this.pnlCurrent.Controls.Add(this.lblCur4P);
            this.pnlCurrent.Controls.Add(this.valCur4P);
            this.pnlCurrent.Controls.Add(this.lblCur4S);
            this.pnlCurrent.Controls.Add(this.valCur4S);
            this.pnlCurrent.Controls.Add(this.lblCur6P);
            this.pnlCurrent.Controls.Add(this.valCur6P);
            this.pnlCurrent.Controls.Add(this.lblCur6S);
            this.pnlCurrent.Controls.Add(this.valCur6S);
            this.pnlCurrent.Location = new System.Drawing.Point(16, 176);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(628, 108);
            this.pnlCurrent.TabIndex = 2;
            this.pnlCurrent.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // lblSecCurrent
            // 
            this.lblSecCurrent.AutoSize = true;
            this.lblSecCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblSecCurrent.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.lblSecCurrent.Location = new System.Drawing.Point(16, 12);
            this.lblSecCurrent.Name = "lblSecCurrent";
            this.lblSecCurrent.Size = new System.Drawing.Size(81, 13);
            this.lblSecCurrent.TabIndex = 0;
            this.lblSecCurrent.Text = "CURRENT DNS";
            // 
            // lblCur4P
            // 
            this.lblCur4P.AutoSize = true;
            this.lblCur4P.BackColor = System.Drawing.Color.Transparent;
            this.lblCur4P.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCur4P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblCur4P.Location = new System.Drawing.Point(16, 44);
            this.lblCur4P.Name = "lblCur4P";
            this.lblCur4P.Size = new System.Drawing.Size(67, 13);
            this.lblCur4P.TabIndex = 1;
            this.lblCur4P.Text = "IPv4 Primary";
            // 
            // valCur4P
            // 
            this.valCur4P.AutoSize = true;
            this.valCur4P.BackColor = System.Drawing.Color.Transparent;
            this.valCur4P.Font = new System.Drawing.Font("Consolas", 9F);
            this.valCur4P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.valCur4P.Location = new System.Drawing.Point(112, 44);
            this.valCur4P.Name = "valCur4P";
            this.valCur4P.Size = new System.Drawing.Size(14, 14);
            this.valCur4P.TabIndex = 2;
            this.valCur4P.Text = "—";
            // 
            // lblCur4S
            // 
            this.lblCur4S.AutoSize = true;
            this.lblCur4S.BackColor = System.Drawing.Color.Transparent;
            this.lblCur4S.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCur4S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblCur4S.Location = new System.Drawing.Point(16, 72);
            this.lblCur4S.Name = "lblCur4S";
            this.lblCur4S.Size = new System.Drawing.Size(83, 13);
            this.lblCur4S.TabIndex = 3;
            this.lblCur4S.Text = "IPv4 Secondary";
            // 
            // valCur4S
            // 
            this.valCur4S.AutoSize = true;
            this.valCur4S.BackColor = System.Drawing.Color.Transparent;
            this.valCur4S.Font = new System.Drawing.Font("Consolas", 9F);
            this.valCur4S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.valCur4S.Location = new System.Drawing.Point(112, 72);
            this.valCur4S.Name = "valCur4S";
            this.valCur4S.Size = new System.Drawing.Size(14, 14);
            this.valCur4S.TabIndex = 4;
            this.valCur4S.Text = "—";
            // 
            // lblCur6P
            // 
            this.lblCur6P.AutoSize = true;
            this.lblCur6P.BackColor = System.Drawing.Color.Transparent;
            this.lblCur6P.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCur6P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblCur6P.Location = new System.Drawing.Point(322, 44);
            this.lblCur6P.Name = "lblCur6P";
            this.lblCur6P.Size = new System.Drawing.Size(67, 13);
            this.lblCur6P.TabIndex = 5;
            this.lblCur6P.Text = "IPv6 Primary";
            // 
            // valCur6P
            // 
            this.valCur6P.AutoSize = true;
            this.valCur6P.BackColor = System.Drawing.Color.Transparent;
            this.valCur6P.Font = new System.Drawing.Font("Consolas", 9F);
            this.valCur6P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.valCur6P.Location = new System.Drawing.Point(424, 44);
            this.valCur6P.Name = "valCur6P";
            this.valCur6P.Size = new System.Drawing.Size(14, 14);
            this.valCur6P.TabIndex = 6;
            this.valCur6P.Text = "—";
            // 
            // lblCur6S
            // 
            this.lblCur6S.AutoSize = true;
            this.lblCur6S.BackColor = System.Drawing.Color.Transparent;
            this.lblCur6S.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCur6S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblCur6S.Location = new System.Drawing.Point(322, 72);
            this.lblCur6S.Name = "lblCur6S";
            this.lblCur6S.Size = new System.Drawing.Size(83, 13);
            this.lblCur6S.TabIndex = 7;
            this.lblCur6S.Text = "IPv6 Secondary";
            // 
            // valCur6S
            // 
            this.valCur6S.AutoSize = true;
            this.valCur6S.BackColor = System.Drawing.Color.Transparent;
            this.valCur6S.Font = new System.Drawing.Font("Consolas", 9F);
            this.valCur6S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.valCur6S.Location = new System.Drawing.Point(424, 72);
            this.valCur6S.Name = "valCur6S";
            this.valCur6S.Size = new System.Drawing.Size(14, 14);
            this.valCur6S.TabIndex = 8;
            this.valCur6S.Text = "—";
            // 
            // pnlSet
            // 
            this.pnlSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.pnlSet.Controls.Add(this.lblSecSet);
            this.pnlSet.Controls.Add(this.lblPreset);
            this.pnlSet.Controls.Add(this.cmbPresets);
            this.pnlSet.Controls.Add(this.lblSet4P);
            this.pnlSet.Controls.Add(this.txt4P);
            this.pnlSet.Controls.Add(this.lblSet4S);
            this.pnlSet.Controls.Add(this.txt4S);
            this.pnlSet.Controls.Add(this.lblSet6P);
            this.pnlSet.Controls.Add(this.txt6P);
            this.pnlSet.Controls.Add(this.lblSet6S);
            this.pnlSet.Controls.Add(this.txt6S);
            this.pnlSet.Location = new System.Drawing.Point(16, 294);
            this.pnlSet.Name = "pnlSet";
            this.pnlSet.Size = new System.Drawing.Size(628, 200);
            this.pnlSet.TabIndex = 3;
            this.pnlSet.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // lblSecSet
            // 
            this.lblSecSet.AutoSize = true;
            this.lblSecSet.BackColor = System.Drawing.Color.Transparent;
            this.lblSecSet.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblSecSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(178)))));
            this.lblSecSet.Location = new System.Drawing.Point(16, 12);
            this.lblSecSet.Name = "lblSecSet";
            this.lblSecSet.Size = new System.Drawing.Size(50, 13);
            this.lblSecSet.TabIndex = 0;
            this.lblSecSet.Text = "SET DNS";
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.BackColor = System.Drawing.Color.Transparent;
            this.lblPreset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblPreset.Location = new System.Drawing.Point(16, 42);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(38, 13);
            this.lblPreset.TabIndex = 1;
            this.lblPreset.Text = "Preset";
            // 
            // cmbPresets
            // 
            this.cmbPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.cmbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPresets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPresets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbPresets.FormattingEnabled = true;
            this.cmbPresets.Location = new System.Drawing.Point(120, 38);
            this.cmbPresets.Name = "cmbPresets";
            this.cmbPresets.Size = new System.Drawing.Size(380, 23);
            this.cmbPresets.TabIndex = 2;
            this.cmbPresets.SelectedIndexChanged += new System.EventHandler(this.cmbPresets_SelectedIndexChanged);
            // 
            // lblSet4P
            // 
            this.lblSet4P.AutoSize = true;
            this.lblSet4P.BackColor = System.Drawing.Color.Transparent;
            this.lblSet4P.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSet4P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblSet4P.Location = new System.Drawing.Point(16, 82);
            this.lblSet4P.Name = "lblSet4P";
            this.lblSet4P.Size = new System.Drawing.Size(67, 13);
            this.lblSet4P.TabIndex = 3;
            this.lblSet4P.Text = "IPv4 Primary";
            // 
            // txt4P
            // 
            this.txt4P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.txt4P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4P.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txt4P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.txt4P.Location = new System.Drawing.Point(120, 78);
            this.txt4P.Name = "txt4P";
            this.txt4P.Size = new System.Drawing.Size(200, 23);
            this.txt4P.TabIndex = 4;
            // 
            // lblSet4S
            // 
            this.lblSet4S.AutoSize = true;
            this.lblSet4S.BackColor = System.Drawing.Color.Transparent;
            this.lblSet4S.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSet4S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblSet4S.Location = new System.Drawing.Point(16, 112);
            this.lblSet4S.Name = "lblSet4S";
            this.lblSet4S.Size = new System.Drawing.Size(83, 13);
            this.lblSet4S.TabIndex = 5;
            this.lblSet4S.Text = "IPv4 Secondary";
            // 
            // txt4S
            // 
            this.txt4S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.txt4S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4S.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txt4S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.txt4S.Location = new System.Drawing.Point(120, 108);
            this.txt4S.Name = "txt4S";
            this.txt4S.Size = new System.Drawing.Size(200, 23);
            this.txt4S.TabIndex = 6;
            // 
            // lblSet6P
            // 
            this.lblSet6P.AutoSize = true;
            this.lblSet6P.BackColor = System.Drawing.Color.Transparent;
            this.lblSet6P.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSet6P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblSet6P.Location = new System.Drawing.Point(16, 142);
            this.lblSet6P.Name = "lblSet6P";
            this.lblSet6P.Size = new System.Drawing.Size(67, 13);
            this.lblSet6P.TabIndex = 7;
            this.lblSet6P.Text = "IPv6 Primary";
            // 
            // txt6P
            // 
            this.txt6P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.txt6P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt6P.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txt6P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.txt6P.Location = new System.Drawing.Point(120, 138);
            this.txt6P.Name = "txt6P";
            this.txt6P.Size = new System.Drawing.Size(380, 23);
            this.txt6P.TabIndex = 8;
            // 
            // lblSet6S
            // 
            this.lblSet6S.AutoSize = true;
            this.lblSet6S.BackColor = System.Drawing.Color.Transparent;
            this.lblSet6S.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSet6S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblSet6S.Location = new System.Drawing.Point(16, 172);
            this.lblSet6S.Name = "lblSet6S";
            this.lblSet6S.Size = new System.Drawing.Size(83, 13);
            this.lblSet6S.TabIndex = 9;
            this.lblSet6S.Text = "IPv6 Secondary";
            // 
            // txt6S
            // 
            this.txt6S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.txt6S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt6S.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txt6S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.txt6S.Location = new System.Drawing.Point(120, 168);
            this.txt6S.Name = "txt6S";
            this.txt6S.Size = new System.Drawing.Size(380, 23);
            this.txt6S.TabIndex = 10;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.btnApply.Location = new System.Drawing.Point(16, 506);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 38);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply DNS";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnRestore.Location = new System.Drawing.Point(226, 506);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 38);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore to DHCP";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnFlush
            // 
            this.btnFlush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnFlush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlush.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(68)))));
            this.btnFlush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnFlush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlush.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnFlush.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnFlush.Location = new System.Drawing.Point(436, 506);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(208, 38);
            this.btnFlush.TabIndex = 6;
            this.btnFlush.Text = "Flush DNS Cache";
            this.btnFlush.UseVisualStyleBackColor = false;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.pnlStatus.Controls.Add(this.lblStatusDot);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Location = new System.Drawing.Point(0, 562);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(660, 30);
            this.pnlStatus.TabIndex = 7;
            // 
            // lblStatusDot
            // 
            this.lblStatusDot.AutoSize = true;
            this.lblStatusDot.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblStatusDot.Location = new System.Drawing.Point(14, 3);
            this.lblStatusDot.Name = "lblStatusDot";
            this.lblStatusDot.Size = new System.Drawing.Size(17, 21);
            this.lblStatusDot.TabIndex = 0;
            this.lblStatusDot.Text = "•";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.lblStatus.Location = new System.Drawing.Point(30, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(660, 592);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAdapter);
            this.Controls.Add(this.pnlCurrent);
            this.Controls.Add(this.pnlSet);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnFlush);
            this.Controls.Add(this.pnlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNShift — Free DNS Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAdapter.ResumeLayout(false);
            this.pnlAdapter.PerformLayout();
            this.pnlCurrent.ResumeLayout(false);
            this.pnlCurrent.PerformLayout();
            this.pnlSet.ResumeLayout(false);
            this.pnlSet.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.LinkLabel lnkSite;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnlAdapter;
        private System.Windows.Forms.Label lblSecAdapter;
        private System.Windows.Forms.ComboBox cmbAdapters;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlCurrent;
        private System.Windows.Forms.Label lblSecCurrent;
        private System.Windows.Forms.Label lblCur4P;
        private System.Windows.Forms.Label valCur4P;
        private System.Windows.Forms.Label lblCur4S;
        private System.Windows.Forms.Label valCur4S;
        private System.Windows.Forms.Label lblCur6P;
        private System.Windows.Forms.Label valCur6P;
        private System.Windows.Forms.Label lblCur6S;
        private System.Windows.Forms.Label valCur6S;
        private System.Windows.Forms.Panel pnlSet;
        private System.Windows.Forms.Label lblSecSet;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ComboBox cmbPresets;
        private System.Windows.Forms.Label lblSet4P;
        private System.Windows.Forms.TextBox txt4P;
        private System.Windows.Forms.Label lblSet4S;
        private System.Windows.Forms.TextBox txt4S;
        private System.Windows.Forms.Label lblSet6P;
        private System.Windows.Forms.TextBox txt6P;
        private System.Windows.Forms.Label lblSet6S;
        private System.Windows.Forms.TextBox txt6S;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnFlush;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatusDot;
        private System.Windows.Forms.Label lblStatus;
    }
}