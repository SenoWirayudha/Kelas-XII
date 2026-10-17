namespace Bromo_Airlines
{
    partial class FormMasterMaskapai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.dgvMaskapai = new System.Windows.Forms.DataGridView();
            this.kolomNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomJumlahKru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblDeskripsiInput = new System.Windows.Forms.Label();
            this.nudJumlahKru = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahKru = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.lblPerusahaan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahKru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(21, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(196, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Maskapai";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(413, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // dgvMaskapai
            // 
            this.dgvMaskapai.AllowUserToAddRows = false;
            this.dgvMaskapai.AllowUserToDeleteRows = false;
            this.dgvMaskapai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaskapai.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaskapai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaskapai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaskapai.ColumnHeadersHeight = 32;
            this.dgvMaskapai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomNama,
            this.kolomPerusahaan,
            this.kolomJumlahKru,
            this.kolomDeskripsi,
            this.kolomUbah,
            this.kolomHapus});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaskapai.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMaskapai.EnableHeadersVisualStyles = false;
            this.dgvMaskapai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dgvMaskapai.Location = new System.Drawing.Point(21, 77);
            this.dgvMaskapai.MultiSelect = false;
            this.dgvMaskapai.Name = "dgvMaskapai";
            this.dgvMaskapai.ReadOnly = true;
            this.dgvMaskapai.RowHeadersVisible = false;
            this.dgvMaskapai.RowHeadersWidth = 62;
            this.dgvMaskapai.RowTemplate.Height = 33;
            this.dgvMaskapai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMaskapai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaskapai.Size = new System.Drawing.Size(722, 215);
            this.dgvMaskapai.TabIndex = 2;
            this.dgvMaskapai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaskapai_CellClick);
            // 
            // kolomNama
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.kolomNama.DefaultCellStyle = dataGridViewCellStyle2;
            this.kolomNama.FillWeight = 22F;
            this.kolomNama.HeaderText = "Nama";
            this.kolomNama.MinimumWidth = 8;
            this.kolomNama.Name = "kolomNama";
            this.kolomNama.ReadOnly = true;
            // 
            // kolomPerusahaan
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomPerusahaan.DefaultCellStyle = dataGridViewCellStyle3;
            this.kolomPerusahaan.FillWeight = 22F;
            this.kolomPerusahaan.HeaderText = "Perusahaan";
            this.kolomPerusahaan.MinimumWidth = 8;
            this.kolomPerusahaan.Name = "kolomPerusahaan";
            this.kolomPerusahaan.ReadOnly = true;
            // 
            // kolomJumlahKru
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomJumlahKru.DefaultCellStyle = dataGridViewCellStyle4;
            this.kolomJumlahKru.FillWeight = 13F;
            this.kolomJumlahKru.HeaderText = "Jumlah Kru";
            this.kolomJumlahKru.MinimumWidth = 8;
            this.kolomJumlahKru.Name = "kolomJumlahKru";
            this.kolomJumlahKru.ReadOnly = true;
            // 
            // kolomDeskripsi
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomDeskripsi.DefaultCellStyle = dataGridViewCellStyle5;
            this.kolomDeskripsi.FillWeight = 28F;
            this.kolomDeskripsi.HeaderText = "Deskripsi";
            this.kolomDeskripsi.MinimumWidth = 8;
            this.kolomDeskripsi.Name = "kolomDeskripsi";
            this.kolomDeskripsi.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(454, 456);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 11;
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
            this.txtDeskripsi.TabIndex = 10;
            // 
            // lblDeskripsiInput
            // 
            this.lblDeskripsiInput.AutoSize = true;
            this.lblDeskripsiInput.Location = new System.Drawing.Point(323, 345);
            this.lblDeskripsiInput.Name = "lblDeskripsiInput";
            this.lblDeskripsiInput.Size = new System.Drawing.Size(84, 25);
            this.lblDeskripsiInput.TabIndex = 9;
            this.lblDeskripsiInput.Text = "Deskripsi";
            // 
            // nudJumlahKru
            // 
            this.nudJumlahKru.Location = new System.Drawing.Point(107, 383);
            this.nudJumlahKru.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahKru.Name = "nudJumlahKru";
            this.nudJumlahKru.Size = new System.Drawing.Size(193, 31);
            this.nudJumlahKru.TabIndex = 8;
            this.nudJumlahKru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJumlahKru
            // 
            this.lblJumlahKru.AutoSize = true;
            this.lblJumlahKru.Location = new System.Drawing.Point(21, 386);
            this.lblJumlahKru.Name = "lblJumlahKru";
            this.lblJumlahKru.Size = new System.Drawing.Size(98, 25);
            this.lblJumlahKru.TabIndex = 7;
            this.lblJumlahKru.Text = "Jumlah Kru";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.Location = new System.Drawing.Point(107, 352);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(193, 31);
            this.txtPerusahaan.TabIndex = 6;
            // 
            // lblPerusahaan
            // 
            this.lblPerusahaan.AutoSize = true;
            this.lblPerusahaan.Location = new System.Drawing.Point(21, 355);
            this.lblPerusahaan.Name = "lblPerusahaan";
            this.lblPerusahaan.Size = new System.Drawing.Size(101, 25);
            this.lblPerusahaan.TabIndex = 5;
            this.lblPerusahaan.Text = "Perusahaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(107, 321);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 31);
            this.txtNama.TabIndex = 4;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(21, 324);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 25);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // FormMasterMaskapai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.dgvMaskapai);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblDeskripsiInput);
            this.Controls.Add(this.nudJumlahKru);
            this.Controls.Add(this.lblJumlahKru);
            this.Controls.Add(this.txtPerusahaan);
            this.Controls.Add(this.lblPerusahaan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMasterMaskapai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Maskapai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahKru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.DataGridView dgvMaskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomJumlahKru;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDeskripsi;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomHapus;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblPerusahaan;
        private System.Windows.Forms.TextBox txtPerusahaan;
        private System.Windows.Forms.Label lblJumlahKru;
        private System.Windows.Forms.NumericUpDown nudJumlahKru;
        private System.Windows.Forms.Label lblDeskripsiInput;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
