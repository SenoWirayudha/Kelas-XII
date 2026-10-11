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
            this.lblKodePenerbangan = new System.Windows.Forms.Label();
            this.mtbKode = new System.Windows.Forms.MaskedTextBox();
            this.lblDari = new System.Windows.Forms.Label();
            this.cmbDari = new System.Windows.Forms.ComboBox();
            this.lblKe = new System.Windows.Forms.Label();
            this.cmbKe = new System.Windows.Forms.ComboBox();
            this.lblMaskapai = new System.Windows.Forms.Label();
            this.cmbMaskapai = new System.Windows.Forms.ComboBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.mtbWaktu = new System.Windows.Forms.MaskedTextBox();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.mtbDurasi = new System.Windows.Forms.MaskedTextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.nudHarga = new System.Windows.Forms.NumericUpDown();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(25, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(381, 34);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Jadwal Penerbangan";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(28, 50);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(294, 15);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AllowUserToDeleteRows = false;
            this.dgvJadwal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvJadwal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvJadwal.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvJadwal.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvJadwal.EnableHeadersVisualStyles = false;
            this.dgvJadwal.GridColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.dgvJadwal.Location = new System.Drawing.Point(25, 78);
            this.dgvJadwal.MultiSelect = false;
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersVisible = false;
            this.dgvJadwal.RowTemplate.Height = 38;
            this.dgvJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJadwal.Size = new System.Drawing.Size(770, 260);
            this.dgvJadwal.TabIndex = 2;
            this.dgvJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwal_CellClick);
            // 
            // kolomKode
            // 
            this.kolomKode.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.kolomKode.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.FillWeight = 10F;
            this.kolomKode.HeaderText = "Kode";
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            // 
            // kolomAsal
            // 
            this.kolomAsal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomAsal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomAsal.FillWeight = 14F;
            this.kolomAsal.HeaderText = "Bandara Asal";
            this.kolomAsal.Name = "kolomAsal";
            this.kolomAsal.ReadOnly = true;
            // 
            // kolomTujuan
            // 
            this.kolomTujuan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomTujuan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTujuan.FillWeight = 14F;
            this.kolomTujuan.HeaderText = "Bandara Tujuan";
            this.kolomTujuan.Name = "kolomTujuan";
            this.kolomTujuan.ReadOnly = true;
            // 
            // kolomMaskapai
            // 
            this.kolomMaskapai.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomMaskapai.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaskapai.FillWeight = 12F;
            this.kolomMaskapai.HeaderText = "Maskapai";
            this.kolomMaskapai.Name = "kolomMaskapai";
            this.kolomMaskapai.ReadOnly = true;
            // 
            // kolomTanggal
            // 
            this.kolomTanggal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomTanggal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTanggal.FillWeight = 10F;
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
            this.kolomDurasi.FillWeight = 13F;
            this.kolomDurasi.HeaderText = "Durasi";
            this.kolomDurasi.Name = "kolomDurasi";
            this.kolomDurasi.ReadOnly = true;
            // 
            // kolomHarga
            // 
            this.kolomHarga.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomHarga.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHarga.FillWeight = 10F;
            this.kolomHarga.HeaderText = "Harga Tiket";
            this.kolomHarga.Name = "kolomHarga";
            this.kolomHarga.ReadOnly = true;
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
            this.kolomUbah.Width = 75;
            // 
            // kolomHapus
            // 
            this.kolomHapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kolomHapus.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.kolomHapus.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kolomHapus.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.kolomHapus.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.kolomHapus.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolomHapus.HeaderText = "";
            this.kolomHapus.Name = "kolomHapus";
            this.kolomHapus.ReadOnly = true;
            this.kolomHapus.Text = "Hapus";
            this.kolomHapus.UseColumnTextForButtonValue = true;
            this.kolomHapus.Width = 75;
            // 
            // lblKodePenerbangan
            // 
            this.lblKodePenerbangan.AutoSize = true;
            this.lblKodePenerbangan.Location = new System.Drawing.Point(25, 365);
            this.lblKodePenerbangan.Name = "lblKodePenerbangan";
            this.lblKodePenerbangan.Size = new System.Drawing.Size(104, 15);
            this.lblKodePenerbangan.TabIndex = 3;
            this.lblKodePenerbangan.Text = "Kode Penerbangan";
            // 
            // mtbKode
            // 
            this.mtbKode.Location = new System.Drawing.Point(140, 361);
            this.mtbKode.Mask = ">LL-0000";
            this.mtbKode.Name = "mtbKode";
            this.mtbKode.PromptChar = '_';
            this.mtbKode.Size = new System.Drawing.Size(190, 23);
            this.mtbKode.TabIndex = 4;
            // 
            // lblDari
            // 
            this.lblDari.AutoSize = true;
            this.lblDari.Location = new System.Drawing.Point(25, 401);
            this.lblDari.Name = "lblDari";
            this.lblDari.Size = new System.Drawing.Size(27, 15);
            this.lblDari.TabIndex = 5;
            this.lblDari.Text = "Dari";
            // 
            // cmbDari
            // 
            this.cmbDari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDari.Location = new System.Drawing.Point(140, 397);
            this.cmbDari.Name = "cmbDari";
            this.cmbDari.Size = new System.Drawing.Size(190, 23);
            this.cmbDari.TabIndex = 6;
            // 
            // lblKe
            // 
            this.lblKe.AutoSize = true;
            this.lblKe.Location = new System.Drawing.Point(25, 437);
            this.lblKe.Name = "lblKe";
            this.lblKe.Size = new System.Drawing.Size(22, 15);
            this.lblKe.TabIndex = 7;
            this.lblKe.Text = "Ke";
            // 
            // cmbKe
            // 
            this.cmbKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKe.Location = new System.Drawing.Point(140, 433);
            this.cmbKe.Name = "cmbKe";
            this.cmbKe.Size = new System.Drawing.Size(190, 23);
            this.cmbKe.TabIndex = 8;
            // 
            // lblMaskapai
            // 
            this.lblMaskapai.AutoSize = true;
            this.lblMaskapai.Location = new System.Drawing.Point(25, 473);
            this.lblMaskapai.Name = "lblMaskapai";
            this.lblMaskapai.Size = new System.Drawing.Size(59, 15);
            this.lblMaskapai.TabIndex = 9;
            this.lblMaskapai.Text = "Maskapai";
            // 
            // cmbMaskapai
            // 
            this.cmbMaskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaskapai.Location = new System.Drawing.Point(140, 469);
            this.cmbMaskapai.Name = "cmbMaskapai";
            this.cmbMaskapai.Size = new System.Drawing.Size(190, 23);
            this.cmbMaskapai.TabIndex = 10;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(350, 365);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(51, 15);
            this.lblTanggal.TabIndex = 11;
            this.lblTanggal.Text = "Tanggal";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(475, 361);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(245, 23);
            this.dtpTanggal.TabIndex = 12;
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Location = new System.Drawing.Point(350, 401);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(121, 15);
            this.lblWaktu.TabIndex = 13;
            this.lblWaktu.Text = "Waktu Keberangkatan";
            // 
            // mtbWaktu
            // 
            this.mtbWaktu.Location = new System.Drawing.Point(475, 397);
            this.mtbWaktu.Mask = "00:00";
            this.mtbWaktu.Name = "mtbWaktu";
            this.mtbWaktu.PromptChar = '_';
            this.mtbWaktu.Size = new System.Drawing.Size(245, 23);
            this.mtbWaktu.TabIndex = 14;
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Location = new System.Drawing.Point(350, 437);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(113, 15);
            this.lblDurasi.TabIndex = 15;
            this.lblDurasi.Text = "Durasi Penerbangan";
            // 
            // mtbDurasi
            // 
            this.mtbDurasi.Location = new System.Drawing.Point(475, 433);
            this.mtbDurasi.Mask = "00 j\\am 00 menit";
            this.mtbDurasi.Name = "mtbDurasi";
            this.mtbDurasi.PromptChar = '_';
            this.mtbDurasi.Size = new System.Drawing.Size(245, 23);
            this.mtbDurasi.TabIndex = 16;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(350, 473);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(92, 15);
            this.lblHarga.TabIndex = 17;
            this.lblHarga.Text = "Harga per Tiket";
            // 
            // nudHarga
            // 
            this.nudHarga.Location = new System.Drawing.Point(475, 469);
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
            this.nudHarga.Size = new System.Drawing.Size(245, 23);
            this.nudHarga.TabIndex = 18;
            this.nudHarga.ThousandsSeparator = true;
            this.nudHarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(485, 510);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 30);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(610, 510);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 30);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormMasterJadwal
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(790, 560);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 540);
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
            this.Controls.Add(this.dgvJadwal);
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
