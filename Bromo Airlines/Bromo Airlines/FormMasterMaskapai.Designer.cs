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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.dgvMaskapai = new System.Windows.Forms.DataGridView();
            this.kolomNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomJumlahKru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblPerusahaan = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.lblJumlahKru = new System.Windows.Forms.Label();
            this.nudJumlahKru = new System.Windows.Forms.NumericUpDown();
            this.lblDeskripsiInput = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahKru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(25, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(247, 34);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Maskapai";
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
            this.lblDeskripsi.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // dgvMaskapai
            // 
            this.dgvMaskapai.AllowUserToAddRows = false;
            this.dgvMaskapai.AllowUserToDeleteRows = false;
            this.dgvMaskapai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaskapai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaskapai.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaskapai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMaskapai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMaskapai.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvMaskapai.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvMaskapai.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMaskapai.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaskapai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomNama,
            this.kolomPerusahaan,
            this.kolomJumlahKru,
            this.kolomDeskripsi,
            this.kolomUbah,
            this.kolomHapus});
            this.dgvMaskapai.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMaskapai.EnableHeadersVisualStyles = false;
            this.dgvMaskapai.GridColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.dgvMaskapai.Location = new System.Drawing.Point(25, 78);
            this.dgvMaskapai.MultiSelect = false;
            this.dgvMaskapai.Name = "dgvMaskapai";
            this.dgvMaskapai.ReadOnly = true;
            this.dgvMaskapai.RowHeadersVisible = false;
            this.dgvMaskapai.RowTemplate.Height = 38;
            this.dgvMaskapai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaskapai.Size = new System.Drawing.Size(770, 260);
            this.dgvMaskapai.TabIndex = 2;
            this.dgvMaskapai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaskapai_CellClick);
            // 
            // kolomNama
            // 
            this.kolomNama.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.kolomNama.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.kolomNama.FillWeight = 22F;
            this.kolomNama.HeaderText = "Nama";
            this.kolomNama.Name = "kolomNama";
            this.kolomNama.ReadOnly = true;
            // 
            // kolomPerusahaan
            // 
            this.kolomPerusahaan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomPerusahaan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomPerusahaan.FillWeight = 22F;
            this.kolomPerusahaan.HeaderText = "Perusahaan";
            this.kolomPerusahaan.Name = "kolomPerusahaan";
            this.kolomPerusahaan.ReadOnly = true;
            // 
            // kolomJumlahKru
            // 
            this.kolomJumlahKru.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.kolomJumlahKru.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomJumlahKru.FillWeight = 13F;
            this.kolomJumlahKru.HeaderText = "Jumlah Kru";
            this.kolomJumlahKru.Name = "kolomJumlahKru";
            this.kolomJumlahKru.ReadOnly = true;
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
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(25, 365);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(39, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(105, 361);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(205, 23);
            this.txtNama.TabIndex = 4;
            // 
            // lblPerusahaan
            // 
            this.lblPerusahaan.AutoSize = true;
            this.lblPerusahaan.Location = new System.Drawing.Point(25, 400);
            this.lblPerusahaan.Name = "lblPerusahaan";
            this.lblPerusahaan.Size = new System.Drawing.Size(74, 15);
            this.lblPerusahaan.TabIndex = 5;
            this.lblPerusahaan.Text = "Perusahaan";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.Location = new System.Drawing.Point(105, 396);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(205, 23);
            this.txtPerusahaan.TabIndex = 6;
            // 
            // lblJumlahKru
            // 
            this.lblJumlahKru.AutoSize = true;
            this.lblJumlahKru.Location = new System.Drawing.Point(25, 435);
            this.lblJumlahKru.Name = "lblJumlahKru";
            this.lblJumlahKru.Size = new System.Drawing.Size(67, 15);
            this.lblJumlahKru.TabIndex = 7;
            this.lblJumlahKru.Text = "Jumlah Kru";
            // 
            // nudJumlahKru
            // 
            this.nudJumlahKru.Location = new System.Drawing.Point(105, 431);
            this.nudJumlahKru.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudJumlahKru.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahKru.Name = "nudJumlahKru";
            this.nudJumlahKru.Size = new System.Drawing.Size(205, 23);
            this.nudJumlahKru.TabIndex = 8;
            this.nudJumlahKru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDeskripsiInput
            // 
            this.lblDeskripsiInput.AutoSize = true;
            this.lblDeskripsiInput.Location = new System.Drawing.Point(340, 365);
            this.lblDeskripsiInput.Name = "lblDeskripsiInput";
            this.lblDeskripsiInput.Size = new System.Drawing.Size(60, 15);
            this.lblDeskripsiInput.TabIndex = 9;
            this.lblDeskripsiInput.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.AcceptsReturn = true;
            this.txtDeskripsi.Location = new System.Drawing.Point(420, 361);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskripsi.Size = new System.Drawing.Size(290, 95);
            this.txtDeskripsi.TabIndex = 10;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(475, 475);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(110, 30);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(600, 475);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 30);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormMasterMaskapai
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(790, 525);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 530);
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
            this.Controls.Add(this.dgvMaskapai);
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
