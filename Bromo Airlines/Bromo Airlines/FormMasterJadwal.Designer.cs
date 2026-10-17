namespace Bromo_Airlines
{
    partial class FormMasterJadwal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.kolomKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomMaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDurasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.nudHarga = new System.Windows.Forms.NumericUpDown();
            this.lblHarga = new System.Windows.Forms.Label();
            this.mtbDurasi = new System.Windows.Forms.MaskedTextBox();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.mtbWaktu = new System.Windows.Forms.MaskedTextBox();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.cmbMaskapai = new System.Windows.Forms.ComboBox();
            this.lblMaskapai = new System.Windows.Forms.Label();
            this.cmbKe = new System.Windows.Forms.ComboBox();
            this.lblKe = new System.Windows.Forms.Label();
            this.cmbDari = new System.Windows.Forms.ComboBox();
            this.lblDari = new System.Windows.Forms.Label();
            this.mtbKode = new System.Windows.Forms.MaskedTextBox();
            this.lblKodePenerbangan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(21, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(341, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Jadwal Penerbangan";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(387, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AllowUserToDeleteRows = false;
            this.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvJadwal.ColumnHeadersHeight = 32;
            this.dgvJadwal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomAsal,
            this.kolomTujuan,
            this.kolomMaskapai,
            this.kolomTanggal,
            this.kolomWaktu,
            this.kolomDurasi,
            this.kolomHarga,
            this.kolomUbah,
            this.kolomHapus});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJadwal.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvJadwal.EnableHeadersVisualStyles = false;
            this.dgvJadwal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dgvJadwal.Location = new System.Drawing.Point(21, 77);
            this.dgvJadwal.MultiSelect = false;
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersVisible = false;
            this.dgvJadwal.RowHeadersWidth = 62;
            this.dgvJadwal.RowTemplate.Height = 33;
            this.dgvJadwal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJadwal.Size = new System.Drawing.Size(722, 215);
            this.dgvJadwal.TabIndex = 2;
            this.dgvJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwal_CellClick);
            // 
            // kolomKode
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.DefaultCellStyle = dataGridViewCellStyle2;
            this.kolomKode.FillWeight = 10F;
            this.kolomKode.HeaderText = "Kode";
            this.kolomKode.MinimumWidth = 8;
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            // 
            // kolomAsal
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomAsal.DefaultCellStyle = dataGridViewCellStyle3;
            this.kolomAsal.FillWeight = 14F;
            this.kolomAsal.HeaderText = "Bandara Asal";
            this.kolomAsal.MinimumWidth = 8;
            this.kolomAsal.Name = "kolomAsal";
            this.kolomAsal.ReadOnly = true;
            // 
            // kolomTujuan
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTujuan.DefaultCellStyle = dataGridViewCellStyle4;
            this.kolomTujuan.FillWeight = 14F;
            this.kolomTujuan.HeaderText = "Bandara Tujuan";
            this.kolomTujuan.MinimumWidth = 8;
            this.kolomTujuan.Name = "kolomTujuan";
            this.kolomTujuan.ReadOnly = true;
            // 
            // kolomMaskapai
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaskapai.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolomMaskapai.FillWeight = 12F;
            this.kolomMaskapai.HeaderText = "Maskapai";
            this.kolomMaskapai.MinimumWidth = 8;
            this.kolomMaskapai.Name = "kolomMaskapai";
            this.kolomMaskapai.ReadOnly = true;
            // 
            // kolomTanggal
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTanggal.DefaultCellStyle = dataGridViewCellStyle6;
            this.kolomTanggal.FillWeight = 10F;
            this.kolomTanggal.HeaderText = "Tanggal";
            this.kolomTanggal.MinimumWidth = 8;
            this.kolomTanggal.Name = "kolomTanggal";
            this.kolomTanggal.ReadOnly = true;
            // 
            // kolomWaktu
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomWaktu.DefaultCellStyle = dataGridViewCellStyle7;
            this.kolomWaktu.FillWeight = 7F;
            this.kolomWaktu.HeaderText = "Waktu";
            this.kolomWaktu.MinimumWidth = 8;
            this.kolomWaktu.Name = "kolomWaktu";
            this.kolomWaktu.ReadOnly = true;
            // 
            // kolomDurasi
            // 
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDurasi.DefaultCellStyle = dataGridViewCellStyle8;
            this.kolomDurasi.FillWeight = 13F;
            this.kolomDurasi.HeaderText = "Durasi";
            this.kolomDurasi.MinimumWidth = 8;
            this.kolomDurasi.Name = "kolomDurasi";
            this.kolomDurasi.ReadOnly = true;
            // 
            // kolomHarga
            // 
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHarga.DefaultCellStyle = dataGridViewCellStyle9;
            this.kolomHarga.FillWeight = 10F;
            this.kolomHarga.HeaderText = "Harga Tiket";
            this.kolomHarga.MinimumWidth = 8;
            this.kolomHarga.Name = "kolomHarga";
            this.kolomHarga.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHapus.DefaultCellStyle = dataGridViewCellStyle11;
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
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(454, 456);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // nudHarga
            // 
            this.nudHarga.Location = new System.Drawing.Point(422, 414);
            this.nudHarga.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudHarga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHarga.Name = "nudHarga";
            this.nudHarga.Size = new System.Drawing.Size(241, 31);
            this.nudHarga.TabIndex = 15;
            this.nudHarga.ThousandsSeparator = true;
            this.nudHarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(323, 417);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(133, 25);
            this.lblHarga.TabIndex = 14;
            this.lblHarga.Text = "Harga per Tiket";
            // 
            // mtbDurasi
            // 
            this.mtbDurasi.Location = new System.Drawing.Point(422, 383);
            this.mtbDurasi.Mask = "00 j\\am 00 menit";
            this.mtbDurasi.Name = "mtbDurasi";
            this.mtbDurasi.Size = new System.Drawing.Size(241, 31);
            this.mtbDurasi.TabIndex = 13;
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Location = new System.Drawing.Point(323, 386);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(170, 25);
            this.lblDurasi.TabIndex = 12;
            this.lblDurasi.Text = "Durasi Penerbangan";
            // 
            // mtbWaktu
            // 
            this.mtbWaktu.Location = new System.Drawing.Point(422, 352);
            this.mtbWaktu.Mask = "00:00";
            this.mtbWaktu.Name = "mtbWaktu";
            this.mtbWaktu.Size = new System.Drawing.Size(241, 31);
            this.mtbWaktu.TabIndex = 11;
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Location = new System.Drawing.Point(323, 355);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(185, 25);
            this.lblWaktu.TabIndex = 10;
            this.lblWaktu.Text = "Waktu Keberangkatan";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(422, 321);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(241, 31);
            this.dtpTanggal.TabIndex = 9;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(323, 324);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(73, 25);
            this.lblTanggal.TabIndex = 8;
            this.lblTanggal.Text = "Tanggal";
            // 
            // cmbMaskapai
            // 
            this.cmbMaskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaskapai.Location = new System.Drawing.Point(107, 414);
            this.cmbMaskapai.Name = "cmbMaskapai";
            this.cmbMaskapai.Size = new System.Drawing.Size(193, 33);
            this.cmbMaskapai.TabIndex = 7;
            // 
            // lblMaskapai
            // 
            this.lblMaskapai.AutoSize = true;
            this.lblMaskapai.Location = new System.Drawing.Point(21, 417);
            this.lblMaskapai.Name = "lblMaskapai";
            this.lblMaskapai.Size = new System.Drawing.Size(87, 25);
            this.lblMaskapai.TabIndex = 6;
            this.lblMaskapai.Text = "Maskapai";
            // 
            // cmbKe
            // 
            this.cmbKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKe.Location = new System.Drawing.Point(107, 383);
            this.cmbKe.Name = "cmbKe";
            this.cmbKe.Size = new System.Drawing.Size(193, 33);
            this.cmbKe.TabIndex = 5;
            // 
            // lblKe
            // 
            this.lblKe.AutoSize = true;
            this.lblKe.Location = new System.Drawing.Point(21, 386);
            this.lblKe.Name = "lblKe";
            this.lblKe.Size = new System.Drawing.Size(31, 25);
            this.lblKe.TabIndex = 4;
            this.lblKe.Text = "Ke";
            // 
            // cmbDari
            // 
            this.cmbDari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDari.Location = new System.Drawing.Point(107, 352);
            this.cmbDari.Name = "cmbDari";
            this.cmbDari.Size = new System.Drawing.Size(193, 33);
            this.cmbDari.TabIndex = 3;
            // 
            // lblDari
            // 
            this.lblDari.AutoSize = true;
            this.lblDari.Location = new System.Drawing.Point(21, 355);
            this.lblDari.Name = "lblDari";
            this.lblDari.Size = new System.Drawing.Size(44, 25);
            this.lblDari.TabIndex = 2;
            this.lblDari.Text = "Dari";
            // 
            // mtbKode
            // 
            this.mtbKode.Location = new System.Drawing.Point(107, 321);
            this.mtbKode.Mask = ">LL-0000";
            this.mtbKode.Name = "mtbKode";
            this.mtbKode.Size = new System.Drawing.Size(193, 31);
            this.mtbKode.TabIndex = 1;
            // 
            // lblKodePenerbangan
            // 
            this.lblKodePenerbangan.AutoSize = true;
            this.lblKodePenerbangan.Location = new System.Drawing.Point(21, 324);
            this.lblKodePenerbangan.Name = "lblKodePenerbangan";
            this.lblKodePenerbangan.Size = new System.Drawing.Size(161, 25);
            this.lblKodePenerbangan.TabIndex = 0;
            this.lblKodePenerbangan.Text = "Kode Penerbangan";
            // 
            // FormMasterJadwal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.nudHarga);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.mtbDurasi);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.mtbWaktu);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.cmbMaskapai);
            this.Controls.Add(this.lblMaskapai);
            this.Controls.Add(this.cmbKe);
            this.Controls.Add(this.lblKe);
            this.Controls.Add(this.cmbDari);
            this.Controls.Add(this.lblDari);
            this.Controls.Add(this.mtbKode);
            this.Controls.Add(this.lblKodePenerbangan);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMasterJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Jadwal Penerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDurasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomHarga;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomHapus;
        private System.Windows.Forms.Label lblKodePenerbangan;
        private System.Windows.Forms.MaskedTextBox mtbKode;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.ComboBox cmbDari;
        private System.Windows.Forms.Label lblKe;
        private System.Windows.Forms.ComboBox cmbKe;
        private System.Windows.Forms.Label lblMaskapai;
        private System.Windows.Forms.ComboBox cmbMaskapai;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.MaskedTextBox mtbWaktu;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.MaskedTextBox mtbDurasi;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.NumericUpDown nudHarga;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
