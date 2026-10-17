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
            // FormUbahStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.dgvStatus);
            this.Controls.Add(this.pnlUbahStatus);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormUbahStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Status Penerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            this.pnlUbahStatus.ResumeLayout(false);
            this.pnlUbahStatus.PerformLayout();
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
    }
}
