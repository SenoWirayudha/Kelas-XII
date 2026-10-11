namespace Bromo_Airlines
{
    partial class FormMasterBandara
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
            this.dgvBandara = new System.Windows.Forms.DataGridView();
            this.kolomNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomKodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomKota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomNegara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomJumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kolomHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblKodeIATA = new System.Windows.Forms.Label();
            this.txtKodeIATA = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.lblNegara = new System.Windows.Forms.Label();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.lblJumlahTerminal = new System.Windows.Forms.Label();
            this.nudJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTerminal)).BeginInit();
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
            this.lblJudul.Text = "Master Bandara";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(28, 50);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(291, 15);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // dgvBandara
            // 
            this.dgvBandara.AllowUserToAddRows = false;
            this.dgvBandara.AllowUserToDeleteRows = false;
            this.dgvBandara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBandara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBandara.BackgroundColor = System.Drawing.Color.White;
            this.dgvBandara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBandara.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBandara.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvBandara.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomNama,
            this.kolomKodeIATA,
            this.kolomKota,
            this.kolomNegara,
            this.kolomJumlahTerminal,
            this.kolomAlamat,
            this.kolomUbah,
            this.kolomHapus});
            this.dgvBandara.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvBandara.EnableHeadersVisualStyles = false;
            this.dgvBandara.GridColor = System.Drawing.Color.Black;
            this.dgvBandara.Location = new System.Drawing.Point(25, 78);
            this.dgvBandara.MultiSelect = false;
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.ReadOnly = true;
            this.dgvBandara.RowHeadersVisible = false;
            this.dgvBandara.RowTemplate.Height = 36;
            this.dgvBandara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBandara.Size = new System.Drawing.Size(750, 215);
            this.dgvBandara.TabIndex = 2;
            this.dgvBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandara_CellClick);
            // 
            // kolomNama
            // 
            this.kolomNama.FillWeight = 18F;
            this.kolomNama.HeaderText = "Nama";
            this.kolomNama.Name = "kolomNama";
            this.kolomNama.ReadOnly = true;
            // 
            // kolomKodeIATA
            // 
            this.kolomKodeIATA.FillWeight = 9F;
            this.kolomKodeIATA.HeaderText = "Kode IATA";
            this.kolomKodeIATA.Name = "kolomKodeIATA";
            this.kolomKodeIATA.ReadOnly = true;
            // 
            // kolomKota
            // 
            this.kolomKota.FillWeight = 12F;
            this.kolomKota.HeaderText = "Kota";
            this.kolomKota.Name = "kolomKota";
            this.kolomKota.ReadOnly = true;
            // 
            // kolomNegara
            // 
            this.kolomNegara.FillWeight = 11F;
            this.kolomNegara.HeaderText = "Negara";
            this.kolomNegara.Name = "kolomNegara";
            this.kolomNegara.ReadOnly = true;
            // 
            // kolomJumlahTerminal
            // 
            this.kolomJumlahTerminal.FillWeight = 11F;
            this.kolomJumlahTerminal.HeaderText = "Jumlah Terminal";
            this.kolomJumlahTerminal.Name = "kolomJumlahTerminal";
            this.kolomJumlahTerminal.ReadOnly = true;
            // 
            // kolomAlamat
            // 
            this.kolomAlamat.FillWeight = 22F;
            this.kolomAlamat.HeaderText = "Alamat";
            this.kolomAlamat.Name = "kolomAlamat";
            this.kolomAlamat.ReadOnly = true;
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
            this.kolomUbah.Width = 80;
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
            this.kolomHapus.Width = 80;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(25, 322);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(39, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(105, 318);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(220, 23);
            this.txtNama.TabIndex = 4;
            // 
            // lblKodeIATA
            // 
            this.lblKodeIATA.AutoSize = true;
            this.lblKodeIATA.Location = new System.Drawing.Point(25, 358);
            this.lblKodeIATA.Name = "lblKodeIATA";
            this.lblKodeIATA.Size = new System.Drawing.Size(63, 15);
            this.lblKodeIATA.TabIndex = 5;
            this.lblKodeIATA.Text = "Kode IATA";
            // 
            // txtKodeIATA
            // 
            this.txtKodeIATA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeIATA.Location = new System.Drawing.Point(105, 354);
            this.txtKodeIATA.MaxLength = 3;
            this.txtKodeIATA.Name = "txtKodeIATA";
            this.txtKodeIATA.Size = new System.Drawing.Size(220, 23);
            this.txtKodeIATA.TabIndex = 6;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(25, 394);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(33, 15);
            this.lblKota.TabIndex = 7;
            this.lblKota.Text = "Kota";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(105, 390);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(220, 23);
            this.txtKota.TabIndex = 8;
            // 
            // lblNegara
            // 
            this.lblNegara.AutoSize = true;
            this.lblNegara.Location = new System.Drawing.Point(25, 430);
            this.lblNegara.Name = "lblNegara";
            this.lblNegara.Size = new System.Drawing.Size(51, 15);
            this.lblNegara.TabIndex = 9;
            this.lblNegara.Text = "Negara";
            // 
            // cmbNegara
            // 
            this.cmbNegara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(105, 426);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(220, 23);
            this.cmbNegara.TabIndex = 10;
            // 
            // lblJumlahTerminal
            // 
            this.lblJumlahTerminal.AutoSize = true;
            this.lblJumlahTerminal.Location = new System.Drawing.Point(360, 322);
            this.lblJumlahTerminal.Name = "lblJumlahTerminal";
            this.lblJumlahTerminal.Size = new System.Drawing.Size(96, 15);
            this.lblJumlahTerminal.TabIndex = 11;
            this.lblJumlahTerminal.Text = "Jumlah Terminal";
            // 
            // nudJumlahTerminal
            // 
            this.nudJumlahTerminal.Location = new System.Drawing.Point(470, 318);
            this.nudJumlahTerminal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudJumlahTerminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJumlahTerminal.Name = "nudJumlahTerminal";
            this.nudJumlahTerminal.Size = new System.Drawing.Size(170, 23);
            this.nudJumlahTerminal.TabIndex = 12;
            this.nudJumlahTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(360, 350);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(47, 15);
            this.lblAlamat.TabIndex = 13;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.AcceptsReturn = true;
            this.txtAlamat.Location = new System.Drawing.Point(470, 348);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(170, 100);
            this.txtAlamat.TabIndex = 14;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(470, 470);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(85, 28);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(565, 470);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 28);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormMasterBandara
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(760, 560);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.nudJumlahTerminal);
            this.Controls.Add(this.lblJumlahTerminal);
            this.Controls.Add(this.cmbNegara);
            this.Controls.Add(this.lblNegara);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.lblKota);
            this.Controls.Add(this.txtKodeIATA);
            this.Controls.Add(this.lblKodeIATA);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dgvBandara);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormMasterBandara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Bandara";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.DataGridView dgvBandara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKodeIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomKota;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomNegara;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomJumlahTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomAlamat;
        private System.Windows.Forms.DataGridViewButtonColumn kolomUbah;
        private System.Windows.Forms.DataGridViewButtonColumn kolomHapus;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKodeIATA;
        private System.Windows.Forms.TextBox txtKodeIATA;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label lblNegara;
        private System.Windows.Forms.ComboBox cmbNegara;
        private System.Windows.Forms.Label lblJumlahTerminal;
        private System.Windows.Forms.NumericUpDown nudJumlahTerminal;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
    }
}
