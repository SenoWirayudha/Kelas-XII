namespace Bromo_Airlines
{
    partial class FormBeliTiket
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
            this.pnlPenumpang = new System.Windows.Forms.Panel();
            this.pnlKiri = new System.Windows.Forms.Panel();
            this.pnlGaris = new System.Windows.Forms.Panel();
            this.lblHeaderPenerbangan = new System.Windows.Forms.Label();
            this.lblRute = new System.Windows.Forms.Label();
            this.lblMaskapai = new System.Windows.Forms.Label();
            this.lblHeaderDetail = new System.Windows.Forms.Label();
            this.picIkonKalender = new System.Windows.Forms.PictureBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.picIkonJam = new System.Windows.Forms.PictureBox();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.picIkonGrup = new System.Windows.Forms.PictureBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblHeaderPromo = new System.Windows.Forms.Label();
            this.txtKodePromo = new System.Windows.Forms.TextBox();
            this.btnPakai = new System.Windows.Forms.Button();
            this.lblInfoPromo = new System.Windows.Forms.Label();
            this.lblTotalPembayaran = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.pnlKanan = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).BeginInit();
            this.pnlKiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonKalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonJam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonGrup)).BeginInit();
            this.pnlKanan.SuspendLayout();
            this.SuspendLayout();
            //
            // btnKembali
            //
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.Location = new System.Drawing.Point(20, 20);
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
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(47, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(204, 30);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Detail Penumpang";
            //
            // lblSubJudul
            //
            this.lblSubJudul.AutoSize = true;
            this.lblSubJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubJudul.ForeColor = System.Drawing.Color.Black;
            this.lblSubJudul.Location = new System.Drawing.Point(47, 47);
            this.lblSubJudul.Name = "lblSubJudul";
            this.lblSubJudul.Size = new System.Drawing.Size(213, 15);
            this.lblSubJudul.TabIndex = 2;
            this.lblSubJudul.Text = "Mohon diisi data semua penumpang";
            //
            // pnlPenumpang
            //
            this.pnlPenumpang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenumpang.AutoScroll = true;
            this.pnlPenumpang.Location = new System.Drawing.Point(20, 78);
            this.pnlPenumpang.Name = "pnlPenumpang";
            this.pnlPenumpang.Size = new System.Drawing.Size(525, 400);
            this.pnlPenumpang.TabIndex = 3;
            //
            // pnlKiri
            //
            this.pnlKiri.AutoScroll = true;
            this.pnlKiri.Controls.Add(this.btnKembali);
            this.pnlKiri.Controls.Add(this.lblJudul);
            this.pnlKiri.Controls.Add(this.lblSubJudul);
            this.pnlKiri.Controls.Add(this.pnlPenumpang);
            this.pnlKiri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKiri.Location = new System.Drawing.Point(0, 0);
            this.pnlKiri.Name = "pnlKiri";
            this.pnlKiri.Size = new System.Drawing.Size(566, 493);
            this.pnlKiri.TabIndex = 0;
            //
            // pnlGaris
            //
            this.pnlGaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlGaris.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGaris.Location = new System.Drawing.Point(0, 0);
            this.pnlGaris.Name = "pnlGaris";
            this.pnlGaris.Size = new System.Drawing.Size(1, 493);
            this.pnlGaris.TabIndex = 0;
            //
            // lblHeaderPenerbangan
            //
            this.lblHeaderPenerbangan.AutoSize = true;
            this.lblHeaderPenerbangan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPenerbangan.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPenerbangan.Location = new System.Drawing.Point(16, 12);
            this.lblHeaderPenerbangan.Name = "lblHeaderPenerbangan";
            this.lblHeaderPenerbangan.Size = new System.Drawing.Size(104, 20);
            this.lblHeaderPenerbangan.TabIndex = 1;
            this.lblHeaderPenerbangan.Text = "Penerbangan";
            //
            // lblRute
            //
            this.lblRute.AutoSize = true;
            this.lblRute.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRute.Location = new System.Drawing.Point(16, 36);
            this.lblRute.Name = "lblRute";
            this.lblRute.Size = new System.Drawing.Size(0, 15);
            this.lblRute.TabIndex = 2;
            //
            // lblMaskapai
            //
            this.lblMaskapai.AutoSize = true;
            this.lblMaskapai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaskapai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblMaskapai.Location = new System.Drawing.Point(16, 56);
            this.lblMaskapai.Name = "lblMaskapai";
            this.lblMaskapai.Size = new System.Drawing.Size(0, 15);
            this.lblMaskapai.TabIndex = 3;
            //
            // lblHeaderDetail
            //
            this.lblHeaderDetail.AutoSize = true;
            this.lblHeaderDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderDetail.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderDetail.Location = new System.Drawing.Point(16, 94);
            this.lblHeaderDetail.Name = "lblHeaderDetail";
            this.lblHeaderDetail.Size = new System.Drawing.Size(146, 20);
            this.lblHeaderDetail.TabIndex = 4;
            this.lblHeaderDetail.Text = "Detail Penerbangan";
            //
            // picIkonKalender
            //
            this.picIkonKalender.BackColor = System.Drawing.Color.White;
            this.picIkonKalender.Location = new System.Drawing.Point(16, 118);
            this.picIkonKalender.Name = "picIkonKalender";
            this.picIkonKalender.Size = new System.Drawing.Size(16, 16);
            this.picIkonKalender.Image = global::Bromo_Airlines.Properties.Resources.ic_kalender;
            this.picIkonKalender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonKalender.TabIndex = 5;
            this.picIkonKalender.TabStop = false;
            //
            // lblTanggal
            //
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTanggal.Location = new System.Drawing.Point(40, 119);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(0, 15);
            this.lblTanggal.TabIndex = 6;
            //
            // picIkonJam
            //
            this.picIkonJam.BackColor = System.Drawing.Color.White;
            this.picIkonJam.Location = new System.Drawing.Point(16, 144);
            this.picIkonJam.Name = "picIkonJam";
            this.picIkonJam.Size = new System.Drawing.Size(16, 16);
            this.picIkonJam.Image = global::Bromo_Airlines.Properties.Resources.ic_jam;
            this.picIkonJam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonJam.TabIndex = 7;
            this.picIkonJam.TabStop = false;
            //
            // lblWaktu
            //
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblWaktu.Location = new System.Drawing.Point(40, 145);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(0, 15);
            this.lblWaktu.TabIndex = 8;
            //
            // picIkonGrup
            //
            this.picIkonGrup.BackColor = System.Drawing.Color.White;
            this.picIkonGrup.Location = new System.Drawing.Point(16, 170);
            this.picIkonGrup.Name = "picIkonGrup";
            this.picIkonGrup.Size = new System.Drawing.Size(16, 16);
            this.picIkonGrup.Image = global::Bromo_Airlines.Properties.Resources.ic_grup;
            this.picIkonGrup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonGrup.TabIndex = 9;
            this.picIkonGrup.TabStop = false;
            //
            // lblJumlah
            //
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblJumlah.Location = new System.Drawing.Point(40, 171);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(0, 15);
            this.lblJumlah.TabIndex = 10;
            //
            // lblHeaderPromo
            //
            this.lblHeaderPromo.AutoSize = true;
            this.lblHeaderPromo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPromo.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPromo.Location = new System.Drawing.Point(16, 211);
            this.lblHeaderPromo.Name = "lblHeaderPromo";
            this.lblHeaderPromo.Size = new System.Drawing.Size(100, 20);
            this.lblHeaderPromo.TabIndex = 11;
            this.lblHeaderPromo.Text = "Kode Promo";
            //
            // txtKodePromo
            //
            this.txtKodePromo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKodePromo.Location = new System.Drawing.Point(16, 236);
            this.txtKodePromo.Name = "txtKodePromo";
            this.txtKodePromo.Size = new System.Drawing.Size(208, 23);
            this.txtKodePromo.TabIndex = 12;
            this.txtKodePromo.TextChanged += new System.EventHandler(this.txtKodePromo_TextChanged);
            //
            // btnPakai
            //
            this.btnPakai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPakai.Location = new System.Drawing.Point(230, 235);
            this.btnPakai.Name = "btnPakai";
            this.btnPakai.Size = new System.Drawing.Size(75, 25);
            this.btnPakai.TabIndex = 13;
            this.btnPakai.Text = "Pakai";
            this.btnPakai.UseVisualStyleBackColor = true;
            this.btnPakai.Click += new System.EventHandler(this.btnPakai_Click);
            //
            // lblInfoPromo
            //
            this.lblInfoPromo.AutoSize = true;
            this.lblInfoPromo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoPromo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfoPromo.Location = new System.Drawing.Point(16, 267);
            this.lblInfoPromo.Name = "lblInfoPromo";
            this.lblInfoPromo.Size = new System.Drawing.Size(0, 15);
            this.lblInfoPromo.TabIndex = 14;
            this.lblInfoPromo.Visible = false;
            //
            // lblTotalPembayaran
            //
            this.lblTotalPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPembayaran.AutoSize = true;
            this.lblTotalPembayaran.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPembayaran.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPembayaran.Location = new System.Drawing.Point(16, 420);
            this.lblTotalPembayaran.Name = "lblTotalPembayaran";
            this.lblTotalPembayaran.Size = new System.Drawing.Size(154, 19);
            this.lblTotalPembayaran.TabIndex = 15;
            this.lblTotalPembayaran.Text = "Total Pembayaran";
            //
            // lblTotal
            //
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.lblTotal.Location = new System.Drawing.Point(16, 414);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(289, 30);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnKonfirmasi
            //
            this.btnKonfirmasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKonfirmasi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKonfirmasi.Location = new System.Drawing.Point(16, 448);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(289, 30);
            this.btnKonfirmasi.TabIndex = 17;
            this.btnKonfirmasi.Text = "Konfirmasi Pembayaran";
            this.btnKonfirmasi.UseVisualStyleBackColor = true;
            this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_Click);
            //
            // pnlKanan
            //
            this.pnlKanan.AutoScroll = true;
            this.pnlKanan.Controls.Add(this.pnlGaris);
            this.pnlKanan.Controls.Add(this.lblHeaderPenerbangan);
            this.pnlKanan.Controls.Add(this.lblRute);
            this.pnlKanan.Controls.Add(this.lblMaskapai);
            this.pnlKanan.Controls.Add(this.lblHeaderDetail);
            this.pnlKanan.Controls.Add(this.picIkonKalender);
            this.pnlKanan.Controls.Add(this.lblTanggal);
            this.pnlKanan.Controls.Add(this.picIkonJam);
            this.pnlKanan.Controls.Add(this.lblWaktu);
            this.pnlKanan.Controls.Add(this.picIkonGrup);
            this.pnlKanan.Controls.Add(this.lblJumlah);
            this.pnlKanan.Controls.Add(this.lblHeaderPromo);
            this.pnlKanan.Controls.Add(this.txtKodePromo);
            this.pnlKanan.Controls.Add(this.btnPakai);
            this.pnlKanan.Controls.Add(this.lblInfoPromo);
            this.pnlKanan.Controls.Add(this.lblTotalPembayaran);
            this.pnlKanan.Controls.Add(this.lblTotal);
            this.pnlKanan.Controls.Add(this.btnKonfirmasi);
            this.pnlKanan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlKanan.Location = new System.Drawing.Point(566, 0);
            this.pnlKanan.Name = "pnlKanan";
            this.pnlKanan.Size = new System.Drawing.Size(320, 493);
            this.pnlKanan.TabIndex = 1;
            //
            // FormBeliTiket
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 493);
            this.Controls.Add(this.pnlKiri);
            this.Controls.Add(this.pnlKanan);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Icon = global::Bromo_Airlines.Properties.Resources.favicon;
            this.Name = "FormBeliTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Beli Tiket";
            this.Load += new System.EventHandler(this.FormBeliTiket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnKembali)).EndInit();
            this.pnlKiri.ResumeLayout(false);
            this.pnlKiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonKalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonJam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonGrup)).EndInit();
            this.pnlKanan.ResumeLayout(false);
            this.pnlKanan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnKembali;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Panel pnlPenumpang;
        private System.Windows.Forms.Panel pnlKiri;
        private System.Windows.Forms.Panel pnlGaris;
        private System.Windows.Forms.Label lblHeaderPenerbangan;
        private System.Windows.Forms.Label lblRute;
        private System.Windows.Forms.Label lblMaskapai;
        private System.Windows.Forms.Label lblHeaderDetail;
        private System.Windows.Forms.PictureBox picIkonKalender;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.PictureBox picIkonJam;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.PictureBox picIkonGrup;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblHeaderPromo;
        private System.Windows.Forms.TextBox txtKodePromo;
        private System.Windows.Forms.Button btnPakai;
        private System.Windows.Forms.Label lblInfoPromo;
        private System.Windows.Forms.Label lblTotalPembayaran;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.Panel pnlKanan;
    }
}
