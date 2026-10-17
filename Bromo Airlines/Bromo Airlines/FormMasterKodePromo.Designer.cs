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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblDeskripsiInput = new System.Windows.Forms.Label();
            this.nudMaksimum = new System.Windows.Forms.NumericUpDown();
            this.lblMaksimum = new System.Windows.Forms.Label();
            this.nudPersentase = new System.Windows.Forms.NumericUpDown();
            this.lblPersentase = new System.Windows.Forms.Label();
            this.dtpBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.lblBerlakuSampai = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblKode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentase)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(21, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(233, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Kode Promo";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(438, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // dgvKodePromo
            // 
            this.dgvKodePromo.AllowUserToAddRows = false;
            this.dgvKodePromo.AllowUserToDeleteRows = false;
            this.dgvKodePromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKodePromo.BackgroundColor = System.Drawing.Color.White;
            this.dgvKodePromo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKodePromo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKodePromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKodePromo.ColumnHeadersHeight = 32;
            this.dgvKodePromo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomKode,
            this.kolomPersentase,
            this.kolomMaksimum,
            this.kolomBerlaku,
            this.kolomDeskripsi,
            this.kolomUbah,
            this.kolomHapus});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKodePromo.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKodePromo.EnableHeadersVisualStyles = false;
            this.dgvKodePromo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dgvKodePromo.Location = new System.Drawing.Point(21, 77);
            this.dgvKodePromo.MultiSelect = false;
            this.dgvKodePromo.Name = "dgvKodePromo";
            this.dgvKodePromo.ReadOnly = true;
            this.dgvKodePromo.RowHeadersVisible = false;
            this.dgvKodePromo.RowHeadersWidth = 62;
            this.dgvKodePromo.RowTemplate.Height = 33;
            this.dgvKodePromo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKodePromo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKodePromo.Size = new System.Drawing.Size(722, 215);
            this.dgvKodePromo.TabIndex = 2;
            this.dgvKodePromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKodePromo_CellClick);
            // 
            // kolomKode
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.kolomKode.DefaultCellStyle = dataGridViewCellStyle2;
            this.kolomKode.FillWeight = 20F;
            this.kolomKode.HeaderText = "Kode";
            this.kolomKode.MinimumWidth = 8;
            this.kolomKode.Name = "kolomKode";
            this.kolomKode.ReadOnly = true;
            // 
            // kolomPersentase
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomPersentase.DefaultCellStyle = dataGridViewCellStyle3;
            this.kolomPersentase.FillWeight = 15F;
            this.kolomPersentase.HeaderText = "Diskon (%)";
            this.kolomPersentase.MinimumWidth = 8;
            this.kolomPersentase.Name = "kolomPersentase";
            this.kolomPersentase.ReadOnly = true;
            // 
            // kolomMaksimum
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomMaksimum.DefaultCellStyle = dataGridViewCellStyle4;
            this.kolomMaksimum.FillWeight = 15F;
            this.kolomMaksimum.HeaderText = "Maks. Diskon";
            this.kolomMaksimum.MinimumWidth = 8;
            this.kolomMaksimum.Name = "kolomMaksimum";
            this.kolomMaksimum.ReadOnly = true;
            // 
            // kolomBerlaku
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomBerlaku.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolomBerlaku.FillWeight = 16F;
            this.kolomBerlaku.HeaderText = "Berlaku Sampai";
            this.kolomBerlaku.MinimumWidth = 8;
            this.kolomBerlaku.Name = "kolomBerlaku";
            this.kolomBerlaku.ReadOnly = true;
            // 
            // kolomDeskripsi
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDeskripsi.DefaultCellStyle = dataGridViewCellStyle6;
            this.kolomDeskripsi.FillWeight = 28F;
            this.kolomDeskripsi.HeaderText = "Deskripsi";
            this.kolomDeskripsi.MinimumWidth = 8;
            this.kolomDeskripsi.Name = "kolomDeskripsi";
            this.kolomDeskripsi.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHapus.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(454, 456);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.AcceptsReturn = true;
            this.txtDeskripsi.Location = new System.Drawing.Point(422, 342);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(241, 84);
            this.txtDeskripsi.TabIndex = 12;
            // 
            // lblDeskripsiInput
            // 
            this.lblDeskripsiInput.AutoSize = true;
            this.lblDeskripsiInput.Location = new System.Drawing.Point(323, 345);
            this.lblDeskripsiInput.Name = "lblDeskripsiInput";
            this.lblDeskripsiInput.Size = new System.Drawing.Size(84, 25);
            this.lblDeskripsiInput.TabIndex = 11;
            this.lblDeskripsiInput.Text = "Deskripsi";
            // 
            // nudMaksimum
            // 
            this.nudMaksimum.Location = new System.Drawing.Point(107, 414);
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
            this.nudMaksimum.Size = new System.Drawing.Size(193, 31);
            this.nudMaksimum.TabIndex = 10;
            this.nudMaksimum.ThousandsSeparator = true;
            this.nudMaksimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMaksimum
            // 
            this.lblMaksimum.AutoSize = true;
            this.lblMaksimum.Location = new System.Drawing.Point(21, 417);
            this.lblMaksimum.Name = "lblMaksimum";
            this.lblMaksimum.Size = new System.Drawing.Size(160, 25);
            this.lblMaksimum.TabIndex = 9;
            this.lblMaksimum.Text = "Maksimum Diskon";
            // 
            // nudPersentase
            // 
            this.nudPersentase.Location = new System.Drawing.Point(107, 383);
            this.nudPersentase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersentase.Name = "nudPersentase";
            this.nudPersentase.Size = new System.Drawing.Size(193, 31);
            this.nudPersentase.TabIndex = 8;
            this.nudPersentase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPersentase
            // 
            this.lblPersentase.AutoSize = true;
            this.lblPersentase.Location = new System.Drawing.Point(21, 386);
            this.lblPersentase.Name = "lblPersentase";
            this.lblPersentase.Size = new System.Drawing.Size(155, 25);
            this.lblPersentase.TabIndex = 7;
            this.lblPersentase.Text = "Persentase Diskon";
            // 
            // dtpBerlakuSampai
            // 
            this.dtpBerlakuSampai.CustomFormat = "dd-MM-yyyy";
            this.dtpBerlakuSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBerlakuSampai.Location = new System.Drawing.Point(107, 352);
            this.dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            this.dtpBerlakuSampai.Size = new System.Drawing.Size(193, 31);
            this.dtpBerlakuSampai.TabIndex = 6;
            // 
            // lblBerlakuSampai
            // 
            this.lblBerlakuSampai.AutoSize = true;
            this.lblBerlakuSampai.Location = new System.Drawing.Point(21, 355);
            this.lblBerlakuSampai.Name = "lblBerlakuSampai";
            this.lblBerlakuSampai.Size = new System.Drawing.Size(133, 25);
            this.lblBerlakuSampai.TabIndex = 5;
            this.lblBerlakuSampai.Text = "Berlaku Sampai";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(107, 321);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(193, 31);
            this.txtKode.TabIndex = 4;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(21, 324);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(112, 25);
            this.lblKode.TabIndex = 3;
            this.lblKode.Text = "Kode Promo";
            // 
            // FormMasterKodePromo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.dgvKodePromo);
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
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMasterKodePromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Kode Promo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaksimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersentase)).EndInit();
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
