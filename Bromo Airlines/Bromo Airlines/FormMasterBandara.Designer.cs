namespace Bromo_Airlines
{
    partial class FormMasterBandara
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlMenu4 = new System.Windows.Forms.Panel();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.picMenu4 = new System.Windows.Forms.PictureBox();
            this.pnlMenu3 = new System.Windows.Forms.Panel();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.picMenu3 = new System.Windows.Forms.PictureBox();
            this.pnlMenu2 = new System.Windows.Forms.Panel();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.picMenu2 = new System.Windows.Forms.PictureBox();
            this.pnlMenu1 = new System.Windows.Forms.Panel();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.picMenu1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu0 = new System.Windows.Forms.Panel();
            this.lblMenu0 = new System.Windows.Forms.Label();
            this.picMenu0 = new System.Windows.Forms.PictureBox();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panelGaris = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.dgvBandara = new System.Windows.Forms.DataGridView();
            this.kolomNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomKodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomKota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomNegara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomJumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.nudJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahTerminal = new System.Windows.Forms.Label();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.lblNegara = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKodeIATA = new System.Windows.Forms.TextBox();
            this.lblKodeIATA = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTerminal)).BeginInit();
            this.panelKonten.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.pnlMenu4.SuspendLayout();
            this.pnlMenu3.SuspendLayout();
            this.pnlMenu2.SuspendLayout();
            this.pnlMenu1.SuspendLayout();
            this.pnlMenu0.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(21, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(170, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Bandara";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(402, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // dgvBandara
            // 
            this.dgvBandara.AllowUserToAddRows = false;
            this.dgvBandara.AllowUserToDeleteRows = false;
            this.dgvBandara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBandara.BackgroundColor = System.Drawing.Color.White;
            this.dgvBandara.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBandara.ColumnHeadersHeight = 32;
            this.dgvBandara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomNama,
            this.kolomKodeIATA,
            this.kolomKota,
            this.kolomNegara,
            this.kolomJumlahTerminal,
            this.kolomAlamat,
            this.kolomUbah,
            this.kolomHapus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBandara.EnableHeadersVisualStyles = false;
            this.dgvBandara.GridColor = System.Drawing.Color.Black;
            this.dgvBandara.Location = new System.Drawing.Point(21, 77);
            this.dgvBandara.MultiSelect = false;
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.ReadOnly = true;
            this.dgvBandara.RowHeadersVisible = false;
            this.dgvBandara.RowHeadersWidth = 62;
            this.dgvBandara.RowTemplate.Height = 33;
            this.dgvBandara.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBandara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBandara.Size = new System.Drawing.Size(722, 215);
            this.dgvBandara.TabIndex = 2;
            this.dgvBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandara_CellClick);
            // 
            // kolomNama
            // 
            this.kolomNama.FillWeight = 18F;
            this.kolomNama.HeaderText = "Nama";
            this.kolomNama.MinimumWidth = 8;
            this.kolomNama.Name = "kolomNama";
            this.kolomNama.ReadOnly = true;
            // 
            // kolomKodeIATA
            // 
            this.kolomKodeIATA.FillWeight = 9F;
            this.kolomKodeIATA.HeaderText = "Kode IATA";
            this.kolomKodeIATA.MinimumWidth = 8;
            this.kolomKodeIATA.Name = "kolomKodeIATA";
            this.kolomKodeIATA.ReadOnly = true;
            // 
            // kolomKota
            // 
            this.kolomKota.FillWeight = 12F;
            this.kolomKota.HeaderText = "Kota";
            this.kolomKota.MinimumWidth = 8;
            this.kolomKota.Name = "kolomKota";
            this.kolomKota.ReadOnly = true;
            // 
            // kolomNegara
            // 
            this.kolomNegara.FillWeight = 11F;
            this.kolomNegara.HeaderText = "Negara";
            this.kolomNegara.MinimumWidth = 8;
            this.kolomNegara.Name = "kolomNegara";
            this.kolomNegara.ReadOnly = true;
            // 
            // kolomJumlahTerminal
            // 
            this.kolomJumlahTerminal.FillWeight = 14F;
            this.kolomJumlahTerminal.HeaderText = "Jumlah Terminal";
            this.kolomJumlahTerminal.MinimumWidth = 8;
            this.kolomJumlahTerminal.Name = "kolomJumlahTerminal";
            this.kolomJumlahTerminal.ReadOnly = true;
            // 
            // kolomAlamat
            // 
            this.kolomAlamat.FillWeight = 20F;
            this.kolomAlamat.HeaderText = "Alamat";
            this.kolomAlamat.MinimumWidth = 8;
            this.kolomAlamat.Name = "kolomAlamat";
            this.kolomAlamat.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle = dataGridViewCellStyle2;
            this.kolomUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolomUbah.HeaderText = "";
            this.kolomUbah.MinimumWidth = 8;
            this.kolomUbah.Name = "kolomUbah";
            this.kolomUbah.ReadOnly = true;
            this.kolomUbah.Text = "Ubah";
            this.kolomUbah.UseColumnTextForButtonValue = true;
            this.kolomUbah.Width = 87;
            // 
            // kolomHapus
            // 
            this.kolomHapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHapus.DefaultCellStyle = dataGridViewCellStyle3;
            this.kolomHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolomHapus.HeaderText = "";
            this.kolomHapus.MinimumWidth = 8;
            this.kolomHapus.Name = "kolomHapus";
            this.kolomHapus.ReadOnly = true;
            this.kolomHapus.Text = "Hapus";
            this.kolomHapus.UseColumnTextForButtonValue = true;
            this.kolomHapus.Width = 87;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(564, 456);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(98, 28);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(454, 456);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.AcceptsReturn = true;
            this.txtAlamat.Location = new System.Drawing.Point(422, 342);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(241, 84);
            this.txtAlamat.TabIndex = 14;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(323, 345);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(68, 25);
            this.lblAlamat.TabIndex = 13;
            this.lblAlamat.Text = "Alamat";
            // 
            // nudJumlahTerminal
            // 
            this.nudJumlahTerminal.Location = new System.Drawing.Point(422, 321);
            this.nudJumlahTerminal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudJumlahTerminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahTerminal.Name = "nudJumlahTerminal";
            this.nudJumlahTerminal.Size = new System.Drawing.Size(241, 31);
            this.nudJumlahTerminal.TabIndex = 12;
            this.nudJumlahTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJumlahTerminal
            // 
            this.lblJumlahTerminal.AutoSize = true;
            this.lblJumlahTerminal.Location = new System.Drawing.Point(323, 324);
            this.lblJumlahTerminal.Name = "lblJumlahTerminal";
            this.lblJumlahTerminal.Size = new System.Drawing.Size(137, 25);
            this.lblJumlahTerminal.TabIndex = 11;
            this.lblJumlahTerminal.Text = "Jumlah Terminal";
            // 
            // cmbNegara
            // 
            this.cmbNegara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(107, 414);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(193, 33);
            this.cmbNegara.TabIndex = 10;
            // 
            // lblNegara
            // 
            this.lblNegara.AutoSize = true;
            this.lblNegara.Location = new System.Drawing.Point(21, 417);
            this.lblNegara.Name = "lblNegara";
            this.lblNegara.Size = new System.Drawing.Size(69, 25);
            this.lblNegara.TabIndex = 9;
            this.lblNegara.Text = "Negara";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(107, 383);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(193, 31);
            this.txtKota.TabIndex = 8;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(21, 386);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(48, 25);
            this.lblKota.TabIndex = 7;
            this.lblKota.Text = "Kota";
            // 
            // txtKodeIATA
            // 
            this.txtKodeIATA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeIATA.Location = new System.Drawing.Point(107, 352);
            this.txtKodeIATA.MaxLength = 3;
            this.txtKodeIATA.Name = "txtKodeIATA";
            this.txtKodeIATA.Size = new System.Drawing.Size(193, 31);
            this.txtKodeIATA.TabIndex = 6;
            // 
            // lblKodeIATA
            // 
            this.lblKodeIATA.AutoSize = true;
            this.lblKodeIATA.Location = new System.Drawing.Point(21, 355);
            this.lblKodeIATA.Name = "lblKodeIATA";
            this.lblKodeIATA.Size = new System.Drawing.Size(94, 25);
            this.lblKodeIATA.TabIndex = 5;
            this.lblKodeIATA.Text = "Kode IATA";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(107, 321);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 31);
            this.txtNama.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(21, 324);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 25);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.Color.White;
            this.panelKonten.Controls.Add(this.dgvBandara);
            this.panelKonten.Controls.Add(this.btnSimpan);
            this.panelKonten.Controls.Add(this.btnBatal);
            this.panelKonten.Controls.Add(this.txtAlamat);
            this.panelKonten.Controls.Add(this.lblAlamat);
            this.panelKonten.Controls.Add(this.nudJumlahTerminal);
            this.panelKonten.Controls.Add(this.lblJumlahTerminal);
            this.panelKonten.Controls.Add(this.cmbNegara);
            this.panelKonten.Controls.Add(this.lblNegara);
            this.panelKonten.Controls.Add(this.txtKota);
            this.panelKonten.Controls.Add(this.lblKota);
            this.panelKonten.Controls.Add(this.txtKodeIATA);
            this.panelKonten.Controls.Add(this.lblKodeIATA);
            this.panelKonten.Controls.Add(this.txtNama);
            this.panelKonten.Controls.Add(this.lblNama);
            this.panelKonten.Controls.Add(this.lblDeskripsi);
            this.panelKonten.Controls.Add(this.lblJudul);
            this.panelKonten.Location = new System.Drawing.Point(220, 52);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(764, 509);
            this.panelKonten.TabIndex = 17;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.btnMenu);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 52);
            this.panelHeader.TabIndex = 18;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(52, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(932, 52);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 52);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "\uE700";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.pnlMenu4);
            this.panelMenu.Controls.Add(this.pnlMenu3);
            this.panelMenu.Controls.Add(this.pnlMenu2);
            this.panelMenu.Controls.Add(this.pnlMenu1);
            this.panelMenu.Controls.Add(this.pnlMenu0);
            this.panelMenu.Controls.Add(this.pnlLogout);
            this.panelMenu.Controls.Add(this.panelGaris);
            this.panelMenu.Location = new System.Drawing.Point(0, 52);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 509);
            this.panelMenu.TabIndex = 19;
            // 
            // pnlMenu4
            // 
            this.pnlMenu4.BackColor = System.Drawing.Color.White;
            this.pnlMenu4.Controls.Add(this.lblMenu4);
            this.pnlMenu4.Controls.Add(this.picMenu4);
            this.pnlMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu4.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu4.Name = "pnlMenu4";
            this.pnlMenu4.Size = new System.Drawing.Size(220, 50);
            this.pnlMenu4.TabIndex = 0;
            this.pnlMenu4.Tag = 4;
            this.pnlMenu4.Click += new System.EventHandler(this.Item_Click);
            this.pnlMenu4.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlMenu4.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblMenu4
            // 
            this.lblMenu4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu4.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblMenu4.Location = new System.Drawing.Point(50, 0);
            this.lblMenu4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(170, 50);
            this.lblMenu4.TabIndex = 0;
            this.lblMenu4.Tag = 4;
            this.lblMenu4.Text = "Ubah Status Penerbangan";
            this.lblMenu4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu4.Click += new System.EventHandler(this.Item_Click);
            this.lblMenu4.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblMenu4.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picMenu4
            // 
            this.picMenu4.BackColor = System.Drawing.Color.Transparent;
            this.picMenu4.Image = global::Bromo_Airlines.Properties.Resources.ic_ubah_status;
            this.picMenu4.Location = new System.Drawing.Point(18, 13);
            this.picMenu4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu4.Name = "picMenu4";
            this.picMenu4.Size = new System.Drawing.Size(24, 24);
            this.picMenu4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu4.TabIndex = 1;
            this.picMenu4.TabStop = false;
            this.picMenu4.Tag = 4;
            this.picMenu4.Click += new System.EventHandler(this.Item_Click);
            this.picMenu4.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picMenu4.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // pnlMenu3
            // 
            this.pnlMenu3.BackColor = System.Drawing.Color.White;
            this.pnlMenu3.Controls.Add(this.lblMenu3);
            this.pnlMenu3.Controls.Add(this.picMenu3);
            this.pnlMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu3.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu3.Name = "pnlMenu3";
            this.pnlMenu3.Size = new System.Drawing.Size(220, 50);
            this.pnlMenu3.TabIndex = 0;
            this.pnlMenu3.Tag = 3;
            this.pnlMenu3.Click += new System.EventHandler(this.Item_Click);
            this.pnlMenu3.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlMenu3.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblMenu3
            // 
            this.lblMenu3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu3.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblMenu3.Location = new System.Drawing.Point(50, 0);
            this.lblMenu3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(170, 50);
            this.lblMenu3.TabIndex = 0;
            this.lblMenu3.Tag = 3;
            this.lblMenu3.Text = "Master Kode Promo";
            this.lblMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu3.Click += new System.EventHandler(this.Item_Click);
            this.lblMenu3.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblMenu3.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picMenu3
            // 
            this.picMenu3.BackColor = System.Drawing.Color.Transparent;
            this.picMenu3.Image = global::Bromo_Airlines.Properties.Resources.ic_kode_promo;
            this.picMenu3.Location = new System.Drawing.Point(18, 13);
            this.picMenu3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu3.Name = "picMenu3";
            this.picMenu3.Size = new System.Drawing.Size(24, 24);
            this.picMenu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu3.TabIndex = 1;
            this.picMenu3.TabStop = false;
            this.picMenu3.Tag = 3;
            this.picMenu3.Click += new System.EventHandler(this.Item_Click);
            this.picMenu3.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picMenu3.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // pnlMenu2
            // 
            this.pnlMenu2.BackColor = System.Drawing.Color.White;
            this.pnlMenu2.Controls.Add(this.lblMenu2);
            this.pnlMenu2.Controls.Add(this.picMenu2);
            this.pnlMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu2.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu2.Name = "pnlMenu2";
            this.pnlMenu2.Size = new System.Drawing.Size(220, 50);
            this.pnlMenu2.TabIndex = 0;
            this.pnlMenu2.Tag = 2;
            this.pnlMenu2.Click += new System.EventHandler(this.Item_Click);
            this.pnlMenu2.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlMenu2.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblMenu2
            // 
            this.lblMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu2.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblMenu2.Location = new System.Drawing.Point(50, 0);
            this.lblMenu2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(170, 50);
            this.lblMenu2.TabIndex = 0;
            this.lblMenu2.Tag = 2;
            this.lblMenu2.Text = "Master Jadwal Penerbangan";
            this.lblMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu2.Click += new System.EventHandler(this.Item_Click);
            this.lblMenu2.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblMenu2.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picMenu2
            // 
            this.picMenu2.BackColor = System.Drawing.Color.Transparent;
            this.picMenu2.Image = global::Bromo_Airlines.Properties.Resources.ic_jadwal;
            this.picMenu2.Location = new System.Drawing.Point(18, 13);
            this.picMenu2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu2.Name = "picMenu2";
            this.picMenu2.Size = new System.Drawing.Size(24, 24);
            this.picMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu2.TabIndex = 1;
            this.picMenu2.TabStop = false;
            this.picMenu2.Tag = 2;
            this.picMenu2.Click += new System.EventHandler(this.Item_Click);
            this.picMenu2.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picMenu2.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.BackColor = System.Drawing.Color.White;
            this.pnlMenu1.Controls.Add(this.lblMenu1);
            this.pnlMenu1.Controls.Add(this.picMenu1);
            this.pnlMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu1.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu1.Name = "pnlMenu1";
            this.pnlMenu1.Size = new System.Drawing.Size(220, 50);
            this.pnlMenu1.TabIndex = 0;
            this.pnlMenu1.Tag = 1;
            this.pnlMenu1.Click += new System.EventHandler(this.Item_Click);
            this.pnlMenu1.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlMenu1.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblMenu1
            // 
            this.lblMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu1.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblMenu1.Location = new System.Drawing.Point(50, 0);
            this.lblMenu1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(170, 50);
            this.lblMenu1.TabIndex = 0;
            this.lblMenu1.Tag = 1;
            this.lblMenu1.Text = "Master Maskapai";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu1.Click += new System.EventHandler(this.Item_Click);
            this.lblMenu1.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblMenu1.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picMenu1
            // 
            this.picMenu1.BackColor = System.Drawing.Color.Transparent;
            this.picMenu1.Image = global::Bromo_Airlines.Properties.Resources.ic_maskapai;
            this.picMenu1.Location = new System.Drawing.Point(18, 13);
            this.picMenu1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu1.Name = "picMenu1";
            this.picMenu1.Size = new System.Drawing.Size(24, 24);
            this.picMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu1.TabIndex = 1;
            this.picMenu1.TabStop = false;
            this.picMenu1.Tag = 1;
            this.picMenu1.Click += new System.EventHandler(this.Item_Click);
            this.picMenu1.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picMenu1.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // pnlMenu0
            // 
            this.pnlMenu0.BackColor = System.Drawing.Color.White;
            this.pnlMenu0.Controls.Add(this.lblMenu0);
            this.pnlMenu0.Controls.Add(this.picMenu0);
            this.pnlMenu0.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu0.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMenu0.Name = "pnlMenu0";
            this.pnlMenu0.Size = new System.Drawing.Size(220, 50);
            this.pnlMenu0.TabIndex = 0;
            this.pnlMenu0.Tag = 0;
            this.pnlMenu0.Click += new System.EventHandler(this.Item_Click);
            this.pnlMenu0.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlMenu0.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblMenu0
            // 
            this.lblMenu0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu0.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenu0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblMenu0.Location = new System.Drawing.Point(50, 0);
            this.lblMenu0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu0.Name = "lblMenu0";
            this.lblMenu0.Size = new System.Drawing.Size(170, 50);
            this.lblMenu0.TabIndex = 0;
            this.lblMenu0.Tag = 0;
            this.lblMenu0.Text = "Master Bandara";
            this.lblMenu0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu0.Click += new System.EventHandler(this.Item_Click);
            this.lblMenu0.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblMenu0.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picMenu0
            // 
            this.picMenu0.BackColor = System.Drawing.Color.Transparent;
            this.picMenu0.Image = global::Bromo_Airlines.Properties.Resources.ic_bandara_aktif;
            this.picMenu0.Location = new System.Drawing.Point(18, 13);
            this.picMenu0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picMenu0.Name = "picMenu0";
            this.picMenu0.Size = new System.Drawing.Size(24, 24);
            this.picMenu0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu0.TabIndex = 1;
            this.picMenu0.TabStop = false;
            this.picMenu0.Tag = 0;
            this.picMenu0.Click += new System.EventHandler(this.Item_Click);
            this.picMenu0.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picMenu0.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.White;
            this.pnlLogout.Controls.Add(this.lblLogout);
            this.pnlLogout.Controls.Add(this.picLogout);
            this.pnlLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogout.Location = new System.Drawing.Point(0, 459);
            this.pnlLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(220, 50);
            this.pnlLogout.TabIndex = 0;
            this.pnlLogout.Tag = 5;
            this.pnlLogout.Click += new System.EventHandler(this.Item_Click);
            this.pnlLogout.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.pnlLogout.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblLogout.Location = new System.Drawing.Point(50, 0);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(170, 50);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Tag = 5;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Click += new System.EventHandler(this.Item_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // picLogout
            // 
            this.picLogout.BackColor = System.Drawing.Color.Transparent;
            this.picLogout.Image = global::Bromo_Airlines.Properties.Resources.ic_logout;
            this.picLogout.Location = new System.Drawing.Point(18, 13);
            this.picLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(24, 24);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 1;
            this.picLogout.TabStop = false;
            this.picLogout.Tag = 5;
            this.picLogout.Click += new System.EventHandler(this.Item_Click);
            this.picLogout.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.picLogout.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // panelGaris
            // 
            this.panelGaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelGaris.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGaris.Location = new System.Drawing.Point(218, 0);
            this.panelGaris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGaris.Name = "panelGaris";
            this.panelGaris.Size = new System.Drawing.Size(2, 509);
            this.panelGaris.TabIndex = 0;
            // 
            // FormMasterBandara
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::Bromo_Airlines.Properties.Resources.favicon;
            this.Name = "FormMasterBandara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Bandara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTerminal)).EndInit();
            this.panelKonten.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.pnlMenu4.ResumeLayout(false);
            this.pnlMenu3.ResumeLayout(false);
            this.pnlMenu2.ResumeLayout(false);
            this.pnlMenu1.ResumeLayout(false);
            this.pnlMenu0.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.DataGridView dgvBandara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKodeIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKota;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNegara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomJumlahTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAlamat;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomHapus;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKodeIATA;
        private System.Windows.Forms.TextBox txtKodeIATA;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label lblNegara;
        private System.Windows.Forms.ComboBox cmbNegara;
        private System.Windows.Forms.Label lblJumlahTerminal;
        private System.Windows.Forms.NumericUpDown nudJumlahTerminal;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pnlMenu0;
        private System.Windows.Forms.Label lblMenu0;
        private System.Windows.Forms.PictureBox picMenu0;
        private System.Windows.Forms.Panel pnlMenu1;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.PictureBox picMenu1;
        private System.Windows.Forms.Panel pnlMenu2;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.PictureBox picMenu2;
        private System.Windows.Forms.Panel pnlMenu3;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.PictureBox picMenu3;
        private System.Windows.Forms.Panel pnlMenu4;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.PictureBox picMenu4;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel panelGaris;
    }
}
