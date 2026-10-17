namespace Bromo_Airlines
{
    partial class CustomerMainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picHeaderLogo = new System.Windows.Forms.PictureBox();
            this.picTiketSaya = new System.Windows.Forms.PictureBox();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lblHalo = new System.Windows.Forms.Label();
            this.lblSapaan = new System.Windows.Forms.Label();
            this.picIkonBerangkat = new System.Windows.Forms.PictureBox();
            this.lblBerangkatDari = new System.Windows.Forms.Label();
            this.cmbAsal = new System.Windows.Forms.ComboBox();
            this.picIkonTujuan = new System.Windows.Forms.PictureBox();
            this.lblTujuan = new System.Windows.Forms.Label();
            this.cmbTujuan = new System.Windows.Forms.ComboBox();
            this.picIkonTanggal = new System.Windows.Forms.PictureBox();
            this.lblTanggalBerangkat = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.picIkonPenumpang = new System.Windows.Forms.PictureBox();
            this.lblPenumpang = new System.Windows.Forms.Label();
            this.nudPenumpang = new System.Windows.Forms.NumericUpDown();
            this.btnCari = new System.Windows.Forms.Button();
            this.picMountain = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiketSaya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonBerangkat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonTujuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonPenumpang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.pnlHeader.Controls.Add(this.picHeaderLogo);
            this.pnlHeader.Controls.Add(this.picTiketSaya);
            this.pnlHeader.Controls.Add(this.picLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // picHeaderLogo
            // 
            this.picHeaderLogo.Location = new System.Drawing.Point(20, 15);
            this.picHeaderLogo.Name = "picHeaderLogo";
            this.picHeaderLogo.Size = new System.Drawing.Size(191, 60);
            this.picHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeaderLogo.TabIndex = 0;
            this.picHeaderLogo.TabStop = false;
            // 
            // picTiketSaya
            // 
            this.picTiketSaya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picTiketSaya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTiketSaya.Location = new System.Drawing.Point(659, 31);
            this.picTiketSaya.Name = "picTiketSaya";
            this.picTiketSaya.Size = new System.Drawing.Size(28, 28);
            this.picTiketSaya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTiketSaya.TabIndex = 1;
            this.picTiketSaya.TabStop = false;
            this.toolTip1.SetToolTip(this.picTiketSaya, "Tiket Saya");
            this.picTiketSaya.Click += new System.EventHandler(this.picTiketSaya_Click);
            // 
            // picLogout
            // 
            this.picLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Location = new System.Drawing.Point(712, 31);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(28, 28);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 2;
            this.picLogout.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogout, "Logout");
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // lblHalo
            // 
            this.lblHalo.AutoSize = true;
            this.lblHalo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHalo.ForeColor = System.Drawing.Color.Black;
            this.lblHalo.Location = new System.Drawing.Point(25, 105);
            this.lblHalo.Name = "lblHalo";
            this.lblHalo.Size = new System.Drawing.Size(77, 37);
            this.lblHalo.TabIndex = 1;
            this.lblHalo.Text = "Halo!";
            // 
            // lblSapaan
            // 
            this.lblSapaan.AutoSize = true;
            this.lblSapaan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSapaan.ForeColor = System.Drawing.Color.Black;
            this.lblSapaan.Location = new System.Drawing.Point(27, 145);
            this.lblSapaan.Name = "lblSapaan";
            this.lblSapaan.Size = new System.Drawing.Size(225, 15);
            this.lblSapaan.TabIndex = 2;
            this.lblSapaan.Text = "Mau terbang ke mana hari ini?";
            // 
            // picIkonBerangkat
            // 
            this.picIkonBerangkat.Location = new System.Drawing.Point(25, 180);
            this.picIkonBerangkat.Name = "picIkonBerangkat";
            this.picIkonBerangkat.Size = new System.Drawing.Size(20, 20);
            this.picIkonBerangkat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonBerangkat.TabIndex = 3;
            this.picIkonBerangkat.TabStop = false;
            // 
            // lblBerangkatDari
            // 
            this.lblBerangkatDari.AutoSize = true;
            this.lblBerangkatDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBerangkatDari.ForeColor = System.Drawing.Color.Black;
            this.lblBerangkatDari.Location = new System.Drawing.Point(53, 183);
            this.lblBerangkatDari.Name = "lblBerangkatDari";
            this.lblBerangkatDari.Size = new System.Drawing.Size(96, 15);
            this.lblBerangkatDari.TabIndex = 4;
            this.lblBerangkatDari.Text = "Berangkat Dari";
            // 
            // cmbAsal
            // 
            this.cmbAsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAsal.FormattingEnabled = true;
            this.cmbAsal.Location = new System.Drawing.Point(53, 202);
            this.cmbAsal.Name = "cmbAsal";
            this.cmbAsal.Size = new System.Drawing.Size(215, 23);
            this.cmbAsal.TabIndex = 5;
            // 
            // picIkonTujuan
            // 
            this.picIkonTujuan.Location = new System.Drawing.Point(300, 180);
            this.picIkonTujuan.Name = "picIkonTujuan";
            this.picIkonTujuan.Size = new System.Drawing.Size(20, 20);
            this.picIkonTujuan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonTujuan.TabIndex = 6;
            this.picIkonTujuan.TabStop = false;
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTujuan.ForeColor = System.Drawing.Color.Black;
            this.lblTujuan.Location = new System.Drawing.Point(328, 183);
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(54, 15);
            this.lblTujuan.TabIndex = 7;
            this.lblTujuan.Text = "Tujuan";
            // 
            // cmbTujuan
            // 
            this.cmbTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTujuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTujuan.FormattingEnabled = true;
            this.cmbTujuan.Location = new System.Drawing.Point(328, 202);
            this.cmbTujuan.Name = "cmbTujuan";
            this.cmbTujuan.Size = new System.Drawing.Size(215, 23);
            this.cmbTujuan.TabIndex = 8;
            // 
            // picIkonTanggal
            // 
            this.picIkonTanggal.Location = new System.Drawing.Point(25, 240);
            this.picIkonTanggal.Name = "picIkonTanggal";
            this.picIkonTanggal.Size = new System.Drawing.Size(20, 20);
            this.picIkonTanggal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonTanggal.TabIndex = 9;
            this.picIkonTanggal.TabStop = false;
            // 
            // lblTanggalBerangkat
            // 
            this.lblTanggalBerangkat.AutoSize = true;
            this.lblTanggalBerangkat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggalBerangkat.ForeColor = System.Drawing.Color.Black;
            this.lblTanggalBerangkat.Location = new System.Drawing.Point(53, 243);
            this.lblTanggalBerangkat.Name = "lblTanggalBerangkat";
            this.lblTanggalBerangkat.Size = new System.Drawing.Size(116, 15);
            this.lblTanggalBerangkat.TabIndex = 10;
            this.lblTanggalBerangkat.Text = "Tanggal Berangkat";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd-MM-yyyy";
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(53, 262);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(215, 23);
            this.dtpTanggal.TabIndex = 11;
            // 
            // picIkonPenumpang
            // 
            this.picIkonPenumpang.Location = new System.Drawing.Point(300, 240);
            this.picIkonPenumpang.Name = "picIkonPenumpang";
            this.picIkonPenumpang.Size = new System.Drawing.Size(20, 20);
            this.picIkonPenumpang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIkonPenumpang.TabIndex = 12;
            this.picIkonPenumpang.TabStop = false;
            // 
            // lblPenumpang
            // 
            this.lblPenumpang.AutoSize = true;
            this.lblPenumpang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPenumpang.ForeColor = System.Drawing.Color.Black;
            this.lblPenumpang.Location = new System.Drawing.Point(328, 243);
            this.lblPenumpang.Name = "lblPenumpang";
            this.lblPenumpang.Size = new System.Drawing.Size(114, 15);
            this.lblPenumpang.TabIndex = 13;
            this.lblPenumpang.Text = "Jumlah Penumpang";
            // 
            // nudPenumpang
            // 
            this.nudPenumpang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudPenumpang.Location = new System.Drawing.Point(328, 262);
            this.nudPenumpang.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPenumpang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenumpang.Name = "nudPenumpang";
            this.nudPenumpang.Size = new System.Drawing.Size(215, 23);
            this.nudPenumpang.TabIndex = 14;
            this.nudPenumpang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCari.Location = new System.Drawing.Point(53, 310);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(150, 28);
            this.btnCari.TabIndex = 15;
            this.btnCari.Text = "Cari Penerbangan";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // picMountain
            // 
            this.picMountain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMountain.Enabled = false;
            this.picMountain.Location = new System.Drawing.Point(555, 333);
            this.picMountain.Name = "picMountain";
            this.picMountain.Size = new System.Drawing.Size(200, 77);
            this.picMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMountain.TabIndex = 16;
            this.picMountain.TabStop = false;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.picMountain);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.nudPenumpang);
            this.Controls.Add(this.lblPenumpang);
            this.Controls.Add(this.picIkonPenumpang);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblTanggalBerangkat);
            this.Controls.Add(this.picIkonTanggal);
            this.Controls.Add(this.cmbTujuan);
            this.Controls.Add(this.lblTujuan);
            this.Controls.Add(this.picIkonTujuan);
            this.Controls.Add(this.cmbAsal);
            this.Controls.Add(this.lblBerangkatDari);
            this.Controls.Add(this.picIkonBerangkat);
            this.Controls.Add(this.lblSapaan);
            this.Controls.Add(this.lblHalo);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMainForm_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTiketSaya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonBerangkat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonTujuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIkonPenumpang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picHeaderLogo;
        private System.Windows.Forms.PictureBox picTiketSaya;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lblHalo;
        private System.Windows.Forms.Label lblSapaan;
        private System.Windows.Forms.PictureBox picIkonBerangkat;
        private System.Windows.Forms.Label lblBerangkatDari;
        private System.Windows.Forms.ComboBox cmbAsal;
        private System.Windows.Forms.PictureBox picIkonTujuan;
        private System.Windows.Forms.Label lblTujuan;
        private System.Windows.Forms.ComboBox cmbTujuan;
        private System.Windows.Forms.PictureBox picIkonTanggal;
        private System.Windows.Forms.Label lblTanggalBerangkat;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.PictureBox picIkonPenumpang;
        private System.Windows.Forms.Label lblPenumpang;
        private System.Windows.Forms.NumericUpDown nudPenumpang;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.PictureBox picMountain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
