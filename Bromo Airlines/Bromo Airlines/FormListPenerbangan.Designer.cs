namespace Bromo_Airlines
{
    partial class FormListPenerbangan
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
            this.btnKembali = new System.Windows.Forms.PictureBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblRingkasan = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbUrutkan = new System.Windows.Forms.ComboBox();
            this.lblUrutkan = new System.Windows.Forms.Label();
            this.chkWaktu4 = new System.Windows.Forms.CheckBox();
            this.chkWaktu3 = new System.Windows.Forms.CheckBox();
            this.chkWaktu2 = new System.Windows.Forms.CheckBox();
            this.chkWaktu1 = new System.Windows.Forms.CheckBox();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblKosong = new System.Windows.Forms.Label();
            this.dgvPenerbangan = new System.Windows.Forms.DataGridView();
            this.kolomKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomMaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomBeli = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerbangan)).BeginInit();
            this.SuspendLayout();
            //
            // btnKembali
            //
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.Location = new System.Drawing.Point(15, 15);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(20, 20);
            this.btnKembali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKembali.TabIndex = 0;
            this.btnKembali.TabStop = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            //
            // lblJudul
            //
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(43, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(197, 32);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "List Penerbangan";
            //
            // lblRingkasan
            //
            this.lblRingkasan.AutoSize = true;
            this.lblRingkasan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRingkasan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRingkasan.Location = new System.Drawing.Point(43, 48);
            this.lblRingkasan.Name = "lblRingkasan";
            this.lblRingkasan.Size = new System.Drawing.Size(130, 15);
            this.lblRingkasan.TabIndex = 2;
            this.lblRingkasan.Text = "Ringkasan pencarian";
            //
            // grpFilter
            //
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cmbUrutkan);
            this.grpFilter.Controls.Add(this.lblUrutkan);
            this.grpFilter.Controls.Add(this.chkWaktu4);
            this.grpFilter.Controls.Add(this.chkWaktu3);
            this.grpFilter.Controls.Add(this.chkWaktu2);
            this.grpFilter.Controls.Add(this.chkWaktu1);
            this.grpFilter.Controls.Add(this.lblWaktu);
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpFilter.Location = new System.Drawing.Point(15, 73);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(806, 130);
            this.grpFilter.TabIndex = 3;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            //
            // btnFilter
            //
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.Location = new System.Drawing.Point(654, 94);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 28);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Terapkan Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            //
            // cmbUrutkan
            //
            this.cmbUrutkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrutkan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbUrutkan.FormattingEnabled = true;
            this.cmbUrutkan.Items.AddRange(new object[] {
            "Harga Terendah",
            "Harga Tertinggi",
            "Waktu Keberangkatan Terawal",
            "Waktu Keberangkatan Terakhir"});
            this.cmbUrutkan.Location = new System.Drawing.Point(15, 94);
            this.cmbUrutkan.Name = "cmbUrutkan";
            this.cmbUrutkan.Size = new System.Drawing.Size(205, 23);
            this.cmbUrutkan.TabIndex = 6;
            //
            // lblUrutkan
            //
            this.lblUrutkan.AutoSize = true;
            this.lblUrutkan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUrutkan.Location = new System.Drawing.Point(15, 74);
            this.lblUrutkan.Name = "lblUrutkan";
            this.lblUrutkan.Size = new System.Drawing.Size(108, 15);
            this.lblUrutkan.TabIndex = 5;
            this.lblUrutkan.Text = "Urutkan Berdasarkan";
            //
            // chkWaktu4
            //
            this.chkWaktu4.AutoSize = true;
            this.chkWaktu4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkWaktu4.Location = new System.Drawing.Point(345, 44);
            this.chkWaktu4.Name = "chkWaktu4";
            this.chkWaktu4.Size = new System.Drawing.Size(98, 19);
            this.chkWaktu4.TabIndex = 4;
            this.chkWaktu4.Text = "18:00 - 24:00";
            this.chkWaktu4.UseVisualStyleBackColor = true;
            //
            // chkWaktu3
            //
            this.chkWaktu3.AutoSize = true;
            this.chkWaktu3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkWaktu3.Location = new System.Drawing.Point(235, 44);
            this.chkWaktu3.Name = "chkWaktu3";
            this.chkWaktu3.Size = new System.Drawing.Size(98, 19);
            this.chkWaktu3.TabIndex = 3;
            this.chkWaktu3.Text = "12:00 - 18:00";
            this.chkWaktu3.UseVisualStyleBackColor = true;
            //
            // chkWaktu2
            //
            this.chkWaktu2.AutoSize = true;
            this.chkWaktu2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkWaktu2.Location = new System.Drawing.Point(125, 44);
            this.chkWaktu2.Name = "chkWaktu2";
            this.chkWaktu2.Size = new System.Drawing.Size(98, 19);
            this.chkWaktu2.TabIndex = 2;
            this.chkWaktu2.Text = "06:00 - 12:00";
            this.chkWaktu2.UseVisualStyleBackColor = true;
            //
            // chkWaktu1
            //
            this.chkWaktu1.AutoSize = true;
            this.chkWaktu1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkWaktu1.Location = new System.Drawing.Point(15, 44);
            this.chkWaktu1.Name = "chkWaktu1";
            this.chkWaktu1.Size = new System.Drawing.Size(98, 19);
            this.chkWaktu1.TabIndex = 1;
            this.chkWaktu1.Text = "00:00 - 06:00";
            this.chkWaktu1.UseVisualStyleBackColor = true;
            //
            // lblWaktu
            //
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWaktu.Location = new System.Drawing.Point(15, 20);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(130, 15);
            this.lblWaktu.TabIndex = 0;
            this.lblWaktu.Text = "Waktu Keberangkatan";
            //
            // lblKosong
            //
            this.lblKosong.AutoSize = true;
            this.lblKosong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKosong.ForeColor = System.Drawing.Color.Gray;
            this.lblKosong.Location = new System.Drawing.Point(245, 390);
            this.lblKosong.Name = "lblKosong";
            this.lblKosong.Size = new System.Drawing.Size(324, 15);
            this.lblKosong.TabIndex = 4;
            this.lblKosong.Text = "Tidak ada penerbangan yang sesuai dengan pencarian Anda.";
            this.lblKosong.Visible = false;
            //
            // dgvPenerbangan
            //
            this.dgvPenerbangan.AllowUserToAddRows = false;
            this.dgvPenerbangan.AllowUserToDeleteRows = false;
            this.dgvPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenerbangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenerbangan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenerbangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPenerbangan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPenerbangan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPenerbangan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvPenerbangan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPenerbangan.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomMaskapai,
            this.kolomAsal,
            this.kolomTujuan,
            this.kolomHarga,
            this.kolomTanggal,
            this.kolomWaktu,
            this.kolomBeli});
            this.dgvPenerbangan.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPenerbangan.EnableHeadersVisualStyles = false;
            this.dgvPenerbangan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dgvPenerbangan.Location = new System.Drawing.Point(15, 215);
            this.dgvPenerbangan.MultiSelect = false;
            this.dgvPenerbangan.Name = "dgvPenerbangan";
            this.dgvPenerbangan.ReadOnly = true;
            this.dgvPenerbangan.RowHeadersVisible = false;
            this.dgvPenerbangan.RowTemplate.Height = 33;
            this.dgvPenerbangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenerbangan.Size = new System.Drawing.Size(806, 363);
            this.dgvPenerbangan.TabIndex = 5;
            this.dgvPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenerbangan_CellClick);
            //
            // kolomKode
            //
            this.kolomKode.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.kolomKode.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.FillWeight = 11F;
            this.kolomKode.HeaderText = "Kode Penerbangan";
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            //
            // kolomMaskapai
            //
            this.kolomMaskapai.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomMaskapai.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaskapai.FillWeight = 13F;
            this.kolomMaskapai.HeaderText = "Maskapai";
            this.kolomMaskapai.Name = "kolomMaskapai";
            this.kolomMaskapai.ReadOnly = true;
            //
            // kolomAsal
            //
            this.kolomAsal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomAsal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomAsal.FillWeight = 14F;
            this.kolomAsal.HeaderText = "Bandara Keberangkatan";
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
            // kolomHarga
            //
            this.kolomHarga.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomHarga.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHarga.FillWeight = 11F;
            this.kolomHarga.HeaderText = "Harga Per Tiket";
            this.kolomHarga.Name = "kolomHarga";
            this.kolomHarga.ReadOnly = true;
            //
            // kolomTanggal
            //
            this.kolomTanggal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomTanggal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomTanggal.FillWeight = 14F;
            this.kolomTanggal.HeaderText = "Tanggal Keberangkatan";
            this.kolomTanggal.Name = "kolomTanggal";
            this.kolomTanggal.ReadOnly = true;
            //
            // kolomWaktu
            //
            this.kolomWaktu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomWaktu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomWaktu.FillWeight = 13F;
            this.kolomWaktu.HeaderText = "Waktu Penerbangan";
            this.kolomWaktu.Name = "kolomWaktu";
            this.kolomWaktu.ReadOnly = true;
            //
            // kolomBeli
            //
            this.kolomBeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kolomBeli.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.kolomBeli.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.kolomBeli.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.kolomBeli.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.kolomBeli.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kolomBeli.HeaderText = "";
            this.kolomBeli.Name = "kolomBeli";
            this.kolomBeli.ReadOnly = true;
            this.kolomBeli.Text = "Beli Tiket";
            this.kolomBeli.UseColumnTextForButtonValue = true;
            this.kolomBeli.Width = 110;
            //
            // FormListPenerbangan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(780, 520);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 593);
            this.Controls.Add(this.dgvPenerbangan);
            this.Controls.Add(this.lblKosong);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblRingkasan);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnKembali);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 520);
            this.Name = "FormListPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - List Penerbangan";
            this.Load += new System.EventHandler(this.FormListPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerbangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnKembali;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblRingkasan;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbUrutkan;
        private System.Windows.Forms.Label lblUrutkan;
        private System.Windows.Forms.CheckBox chkWaktu4;
        private System.Windows.Forms.CheckBox chkWaktu3;
        private System.Windows.Forms.CheckBox chkWaktu2;
        private System.Windows.Forms.CheckBox chkWaktu1;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblKosong;
        private System.Windows.Forms.DataGridView dgvPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomWaktu;
        private System.Windows.Forms.DataGridViewButtonColumn kolomBeli;
    }
}
