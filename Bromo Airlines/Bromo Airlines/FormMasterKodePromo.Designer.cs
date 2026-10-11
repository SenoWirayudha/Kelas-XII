namespace Bromo_Airlines
{
    partial class FormMasterKodePromo
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
            this.dgvKodePromo = new System.Windows.Forms.DataGridView();
            this.kolomKode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomPersentase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomMaksimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomBerlaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblBerlakuSampai = new System.Windows.Forms.Label();
            this.dtpBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.lblPersentase = new System.Windows.Forms.Label();
            this.nudPersentase = new System.Windows.Forms.NumericUpDown();
            this.lblMaksimum = new System.Windows.Forms.Label();
            this.nudMaksimum = new System.Windows.Forms.NumericUpDown();
            this.lblDeskripsiInput = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(25, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(303, 34);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Kode Promo";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(28, 50);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(307, 15);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // dgvKodePromo
            // 
            this.dgvKodePromo.AllowUserToAddRows = false;
            this.dgvKodePromo.AllowUserToDeleteRows = false;
            this.dgvKodePromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKodePromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKodePromo.BackgroundColor = System.Drawing.Color.White;
            this.dgvKodePromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvKodePromo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvKodePromo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvKodePromo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvKodePromo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKodePromo.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKodePromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKodePromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomPersentase,
            this.kolomMaksimum,
            this.kolomBerlaku,
            this.kolomDeskripsi,
            this.kolomUbah,
            this.kolomHapus});
            this.dgvKodePromo.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvKodePromo.EnableHeadersVisualStyles = false;
            this.dgvKodePromo.GridColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.dgvKodePromo.Location = new System.Drawing.Point(25, 78);
            this.dgvKodePromo.MultiSelect = false;
            this.dgvKodePromo.Name = "dgvKodePromo";
            this.dgvKodePromo.ReadOnly = true;
            this.dgvKodePromo.RowHeadersVisible = false;
            this.dgvKodePromo.RowTemplate.Height = 38;
            this.dgvKodePromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKodePromo.Size = new System.Drawing.Size(770, 300);
            this.dgvKodePromo.TabIndex = 2;
            this.dgvKodePromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKodePromo_CellClick);
            // 
            // kolomKode
            // 
            this.kolomKode.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.kolomKode.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.FillWeight = 20F;
            this.kolomKode.HeaderText = "Kode";
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            // 
            // kolomPersentase
            // 
            this.kolomPersentase.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomPersentase.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomPersentase.FillWeight = 15F;
            this.kolomPersentase.HeaderText = "Diskon (%)";
            this.kolomPersentase.Name = "kolomPersentase";
            this.kolomPersentase.ReadOnly = true;
            // 
            // kolomMaksimum
            // 
            this.kolomMaksimum.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomMaksimum.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaksimum.FillWeight = 15F;
            this.kolomMaksimum.HeaderText = "Maks. Diskon";
            this.kolomMaksimum.Name = "kolomMaksimum";
            this.kolomMaksimum.ReadOnly = true;
            // 
            // kolomBerlaku
            // 
            this.kolomBerlaku.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomBerlaku.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomBerlaku.FillWeight = 16F;
            this.kolomBerlaku.HeaderText = "Berlaku Sampai";
            this.kolomBerlaku.Name = "kolomBerlaku";
            this.kolomBerlaku.ReadOnly = true;
            // 
            // kolomDeskripsi
            // 
            this.kolomDeskripsi.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomDeskripsi.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDeskripsi.FillWeight = 28F;
            this.kolomDeskripsi.HeaderText = "Deskripsi";
            this.kolomDeskripsi.Name = "kolomDeskripsi";
            this.kolomDeskripsi.ReadOnly = true;
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
            this.kolomUbah.Width = 100;
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
            this.kolomHapus.Width = 100;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(25, 424);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(70, 15);
            this.lblKode.TabIndex = 3;
            this.lblKode.Text = "Kode Promo";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(145, 420);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(205, 23);
            this.txtKode.TabIndex = 4;
            // 
            // lblBerlakuSampai
            // 
            this.lblBerlakuSampai.AutoSize = true;
            this.lblBerlakuSampai.Location = new System.Drawing.Point(25, 460);
            this.lblBerlakuSampai.Name = "lblBerlakuSampai";
            this.lblBerlakuSampai.Size = new System.Drawing.Size(92, 15);
            this.lblBerlakuSampai.TabIndex = 5;
            this.lblBerlakuSampai.Text = "Berlaku Sampai";
            // 
            // dtpBerlakuSampai
            // 
            this.dtpBerlakuSampai.CustomFormat = "dd-MM-yyyy";
            this.dtpBerlakuSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBerlakuSampai.Location = new System.Drawing.Point(145, 456);
            this.dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            this.dtpBerlakuSampai.Size = new System.Drawing.Size(205, 23);
            this.dtpBerlakuSampai.TabIndex = 6;
            // 
            // lblPersentase
            // 
            this.lblPersentase.AutoSize = true;
            this.lblPersentase.Location = new System.Drawing.Point(25, 496);
            this.lblPersentase.Name = "lblPersentase";
            this.lblPersentase.Size = new System.Drawing.Size(112, 15);
            this.lblPersentase.TabIndex = 7;
            this.lblPersentase.Text = "Persentase Diskon";
            // 
            // nudPersentase
            // 
            this.nudPersentase.Location = new System.Drawing.Point(145, 492);
            this.nudPersentase.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPersentase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersentase.Name = "nudPersentase";
            this.nudPersentase.Size = new System.Drawing.Size(205, 23);
            this.nudPersentase.TabIndex = 8;
            this.nudPersentase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaksimum
            // 
            this.lblMaksimum.AutoSize = true;
            this.lblMaksimum.Location = new System.Drawing.Point(25, 532);
            this.lblMaksimum.Name = "lblMaksimum";
            this.lblMaksimum.Size = new System.Drawing.Size(104, 15);
            this.lblMaksimum.TabIndex = 9;
            this.lblMaksimum.Text = "Maksimum Diskon";
            // 
            // nudMaksimum
            // 
            this.nudMaksimum.Location = new System.Drawing.Point(145, 528);
            this.nudMaksimum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMaksimum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaksimum.Name = "nudMaksimum";
            this.nudMaksimum.Size = new System.Drawing.Size(205, 23);
            this.nudMaksimum.TabIndex = 10;
            this.nudMaksimum.ThousandsSeparator = true;
            this.nudMaksimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDeskripsiInput
            // 
            this.lblDeskripsiInput.AutoSize = true;
            this.lblDeskripsiInput.Location = new System.Drawing.Point(375, 424);
            this.lblDeskripsiInput.Name = "lblDeskripsiInput";
            this.lblDeskripsiInput.Size = new System.Drawing.Size(60, 15);
            this.lblDeskripsiInput.TabIndex = 11;
            this.lblDeskripsiInput.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.AcceptsReturn = true;
            this.txtDeskripsi.Location = new System.Drawing.Point(445, 420);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(295, 60);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(505, 500);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 30);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(630, 500);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 30);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormMasterKodePromo
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(790, 560);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 575);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblDeskripsiInput);
            this.Controls.Add(this.nudMaksimum);
            this.Controls.Add(this.lblMaksimum);
            this.Controls.Add(this.nudPersentase);
            this.Controls.Add(this.lblPersentase);
            this.Controls.Add(this.dtpBerlakuSampai);
            this.Controls.Add(this.lblBerlakuSampai);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.dgvKodePromo);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMasterKodePromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Kode Promo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.DataGridView dgvKodePromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomPersentase;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomMaksimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomBerlaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDeskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomHapus;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblBerlakuSampai;
        private System.Windows.Forms.DateTimePicker dtpBerlakuSampai;
        private System.Windows.Forms.Label lblPersentase;
        private System.Windows.Forms.NumericUpDown nudPersentase;
        private System.Windows.Forms.Label lblMaksimum;
        private System.Windows.Forms.NumericUpDown nudMaksimum;
        private System.Windows.Forms.Label lblDeskripsiInput;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
