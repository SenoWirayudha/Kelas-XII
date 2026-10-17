namespace Bromo_Airlines
{
    partial class FormUbahStatus
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
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.kolomKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomMaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDiubah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlUbahStatus = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.mtbDelay = new System.Windows.Forms.MaskedTextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            this.pnlUbahStatus.SuspendLayout();
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
            this.lblJudul.Size = new System.Drawing.Size(331, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Ubah Status Penerbangan";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(449, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // dgvStatus
            // 
            this.dgvStatus.AllowUserToAddRows = false;
            this.dgvStatus.AllowUserToDeleteRows = false;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStatus.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvStatus.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvStatus.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStatus.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStatus.ColumnHeadersHeight = 32;
            this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomMaskapai,
            this.kolomAsal,
            this.kolomTujuan,
            this.kolomTanggal,
            this.kolomWaktu,
            this.kolomDurasi,
            this.kolomStatus,
            this.kolomDiubah,
            this.kolomUbah});
            this.dgvStatus.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvStatus.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatus.EnableHeadersVisualStyles = false;
            this.dgvStatus.GridColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.dgvStatus.Location = new System.Drawing.Point(21, 77);
            this.dgvStatus.MultiSelect = false;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            this.dgvStatus.RowHeadersVisible = false;
            this.dgvStatus.RowTemplate.Height = 33;
            this.dgvStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatus.Size = new System.Drawing.Size(722, 215);
            this.dgvStatus.TabIndex = 2;
            this.dgvStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellClick);
            // 
            // kolomKode
            // 
            this.kolomKode.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.kolomKode.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.FillWeight = 9F;
            this.kolomKode.HeaderText = "Kode";
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            // 
            // kolomMaskapai
            // 
            this.kolomMaskapai.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomMaskapai.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaskapai.FillWeight = 11F;
            this.kolomMaskapai.HeaderText = "Maskapai";
            this.kolomMaskapai.Name = "kolomMaskapai";
            this.kolomMaskapai.ReadOnly = true;
            // 
            // kolomAsal
            // 
            this.kolomAsal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomAsal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomAsal.FillWeight = 12F;
            this.kolomAsal.HeaderText = "Asal";
            this.kolomAsal.Name = "kolomAsal";
            this.kolomAsal.ReadOnly = true;
            // 
            // kolomTujuan
            // 
            this.kolomTujuan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomTujuan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTujuan.FillWeight = 12F;
            this.kolomTujuan.HeaderText = "Tujuan";
            this.kolomTujuan.Name = "kolomTujuan";
            this.kolomTujuan.ReadOnly = true;
            // 
            // kolomTanggal
            // 
            this.kolomTanggal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomTanggal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTanggal.FillWeight = 9F;
            this.kolomTanggal.HeaderText = "Tanggal";
            this.kolomTanggal.Name = "kolomTanggal";
            this.kolomTanggal.ReadOnly = true;
            // 
            // kolomWaktu
            // 
            this.kolomWaktu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomWaktu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomWaktu.FillWeight = 7F;
            this.kolomWaktu.HeaderText = "Waktu";
            this.kolomWaktu.Name = "kolomWaktu";
            this.kolomWaktu.ReadOnly = true;
            // 
            // kolomDurasi
            // 
            this.kolomDurasi.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomDurasi.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDurasi.FillWeight = 11F;
            this.kolomDurasi.HeaderText = "Durasi";
            this.kolomDurasi.Name = "kolomDurasi";
            this.kolomDurasi.ReadOnly = true;
            // 
            // kolomStatus
            // 
            this.kolomStatus.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomStatus.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomStatus.FillWeight = 15F;
            this.kolomStatus.HeaderText = "Status Terakhir";
            this.kolomStatus.Name = "kolomStatus";
            this.kolomStatus.ReadOnly = true;
            // 
            // kolomDiubah
            // 
            this.kolomDiubah.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomDiubah.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDiubah.FillWeight = 14F;
            this.kolomDiubah.HeaderText = "Terakhir Diubah";
            this.kolomDiubah.Name = "kolomDiubah";
            this.kolomDiubah.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kolomUbah.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.kolomUbah.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.kolomUbah.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.kolomUbah.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolomUbah.HeaderText = "";
            this.kolomUbah.Name = "kolomUbah";
            this.kolomUbah.ReadOnly = true;
            this.kolomUbah.Text = "Ubah";
            this.kolomUbah.UseColumnTextForButtonValue = true;
            this.kolomUbah.Width = 87;
            // 
            // pnlUbahStatus
            // 
            this.pnlUbahStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUbahStatus.Controls.Add(this.btnSimpan);
            this.pnlUbahStatus.Controls.Add(this.btnBatal);
            this.pnlUbahStatus.Controls.Add(this.mtbDelay);
            this.pnlUbahStatus.Controls.Add(this.lblDelay);
            this.pnlUbahStatus.Controls.Add(this.cmbStatus);
            this.pnlUbahStatus.Controls.Add(this.lblStatus);
            this.pnlUbahStatus.Location = new System.Drawing.Point(21, 414);
            this.pnlUbahStatus.Name = "pnlUbahStatus";
            this.pnlUbahStatus.Size = new System.Drawing.Size(722, 95);
            this.pnlUbahStatus.TabIndex = 3;
            this.pnlUbahStatus.Visible = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(595, 55);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 30);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(475, 55);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 30);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // mtbDelay
            // 
            this.mtbDelay.Location = new System.Drawing.Point(420, 12);
            this.mtbDelay.Mask = "00 j\\am 00 menit";
            this.mtbDelay.Name = "mtbDelay";
            this.mtbDelay.PromptChar = '_';
            this.mtbDelay.Size = new System.Drawing.Size(200, 31);
            this.mtbDelay.TabIndex = 3;
            this.mtbDelay.Visible = false;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(285, 16);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(126, 25);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Perkiraan Durasi Delay";
            this.lblDelay.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(75, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 31);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.Color.White;
            this.panelKonten.Controls.Add(this.dgvStatus);
            this.panelKonten.Controls.Add(this.pnlUbahStatus);
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
            this.lblMenu4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
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
            this.picMenu4.Image = global::Bromo_Airlines.Properties.Resources.ic_ubah_status_aktif;
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
            this.lblMenu0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
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
            this.picMenu0.Image = global::Bromo_Airlines.Properties.Resources.ic_bandara;
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
            // FormUbahStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::Bromo_Airlines.Properties.Resources.favicon;
            this.Name = "FormUbahStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Status Penerbangan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDiubah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.Panel pnlUbahStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.MaskedTextBox mtbDelay;
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
