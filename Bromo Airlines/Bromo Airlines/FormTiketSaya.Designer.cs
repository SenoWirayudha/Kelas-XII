namespace Bromo_Airlines
{
    partial class FormTiketSaya
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
            this.lblSubJudul = new System.Windows.Forms.Label();
            this.dgvTiket = new System.Windows.Forms.DataGridView();
            this.kolomKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomMaskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKosong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).BeginInit();
            this.SuspendLayout();
            //
            // btnKembali
            //
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.Location = new System.Drawing.Point(15, 15);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(20, 20);
            this.btnKembali.Image = global::Bromo_Airlines.Properties.Resources.ic_kembali;
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
            this.lblJudul.Size = new System.Drawing.Size(141, 32);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Tiket Saya";
            //
            // lblSubJudul
            //
            this.lblSubJudul.AutoSize = true;
            this.lblSubJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubJudul.ForeColor = System.Drawing.Color.Black;
            this.lblSubJudul.Location = new System.Drawing.Point(43, 46);
            this.lblSubJudul.Name = "lblSubJudul";
            this.lblSubJudul.Size = new System.Drawing.Size(267, 15);
            this.lblSubJudul.TabIndex = 2;
            this.lblSubJudul.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            //
            // dgvTiket
            //
            this.dgvTiket.AllowUserToAddRows = false;
            this.dgvTiket.AllowUserToDeleteRows = false;
            this.dgvTiket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTiket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTiket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTiket.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTiket.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvTiket.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTiket.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomMaskapai,
            this.kolomAsal,
            this.kolomTujuan,
            this.kolomTanggal,
            this.kolomWaktu,
            this.kolomStatus});
            this.dgvTiket.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTiket.EnableHeadersVisualStyles = false;
            this.dgvTiket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dgvTiket.Location = new System.Drawing.Point(15, 71);
            this.dgvTiket.MultiSelect = false;
            this.dgvTiket.Name = "dgvTiket";
            this.dgvTiket.ReadOnly = true;
            this.dgvTiket.RowHeadersVisible = false;
            this.dgvTiket.RowTemplate.Height = 33;
            this.dgvTiket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiket.Size = new System.Drawing.Size(856, 307);
            this.dgvTiket.TabIndex = 3;
            //
            // kolomKode
            //
            this.kolomKode.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.kolomKode.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.FillWeight = 13F;
            this.kolomKode.HeaderText = "Kode Penerbangan";
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            //
            // kolomMaskapai
            //
            this.kolomMaskapai.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomMaskapai.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaskapai.FillWeight = 15F;
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
            this.kolomWaktu.FillWeight = 14F;
            this.kolomWaktu.HeaderText = "Waktu Penerbangan";
            this.kolomWaktu.Name = "kolomWaktu";
            this.kolomWaktu.ReadOnly = true;
            //
            // kolomStatus
            //
            this.kolomStatus.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomStatus.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomStatus.FillWeight = 20F;
            this.kolomStatus.HeaderText = "Status Terakhir";
            this.kolomStatus.Name = "kolomStatus";
            this.kolomStatus.ReadOnly = true;
            //
            // lblKosong
            //
            this.lblKosong.AutoSize = true;
            this.lblKosong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKosong.ForeColor = System.Drawing.Color.Gray;
            this.lblKosong.Location = new System.Drawing.Point(375, 216);
            this.lblKosong.Name = "lblKosong";
            this.lblKosong.Size = new System.Drawing.Size(214, 15);
            this.lblKosong.TabIndex = 4;
            this.lblKosong.Text = "Anda belum memiliki tiket aktif.";
            this.lblKosong.Visible = false;
            //
            // FormTiketSaya
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(780, 360);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 393);
            this.Controls.Add(this.lblKosong);
            this.Controls.Add(this.dgvTiket);
            this.Controls.Add(this.lblSubJudul);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnKembali);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(780, 360);
            this.Icon = global::Bromo_Airlines.Properties.Resources.favicon;
            this.Name = "FormTiketSaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Tiket Saya";
            this.Load += new System.EventHandler(this.FormTiketSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnKembali;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.DataGridView dgvTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomStatus;
        private System.Windows.Forms.Label lblKosong;
    }
}
