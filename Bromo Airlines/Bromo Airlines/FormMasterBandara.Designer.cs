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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.nudJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.lblJumlahTerminal = new System.Windows.Forms.Label();
            this.cmbNegara = new System.Windows.Forms.ComboBox();
            this.lblNegara = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKodeIATA = new System.Windows.Forms.TextBox();
            this.lblKodeIATA = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlahTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(21, 17);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(170, 37);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Bandara";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.Black;
            this.lblDeskripsi.Location = new System.Drawing.Point(21, 44);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(402, 25);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // dgvBandara
            // 
            this.dgvBandara.AllowUserToAddRows = false;
            this.dgvBandara.AllowUserToDeleteRows = false;
            this.dgvBandara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBandara.BackgroundColor = System.Drawing.Color.White;
            this.dgvBandara.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBandara.ColumnHeadersHeight = 32;
            this.dgvBandara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolomNama,
            this.kolomKodeIATA,
            this.kolomKota,
            this.kolomNegara,
            this.kolomJumlahTerminal,
            this.kolomAlamat,
            this.kolomUbah,
            this.kolomHapus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBandara.EnableHeadersVisualStyles = false;
            this.dgvBandara.GridColor = System.Drawing.Color.Black;
            this.dgvBandara.Location = new System.Drawing.Point(21, 77);
            this.dgvBandara.MultiSelect = false;
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.ReadOnly = true;
            this.dgvBandara.RowHeadersVisible = false;
            this.dgvBandara.RowHeadersWidth = 62;
            this.dgvBandara.RowTemplate.Height = 33;
            this.dgvBandara.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBandara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBandara.Size = new System.Drawing.Size(722, 215);
            this.dgvBandara.TabIndex = 2;
            this.dgvBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandara_CellClick);
            // 
            // kolomNama
            // 
            this.kolomNama.FillWeight = 18F;
            this.kolomNama.HeaderText = "Nama";
            this.kolomNama.MinimumWidth = 8;
            this.kolomNama.Name = "kolomNama";
            this.kolomNama.ReadOnly = true;
            // 
            // kolomKodeIATA
            // 
            this.kolomKodeIATA.FillWeight = 9F;
            this.kolomKodeIATA.HeaderText = "Kode IATA";
            this.kolomKodeIATA.MinimumWidth = 8;
            this.kolomKodeIATA.Name = "kolomKodeIATA";
            this.kolomKodeIATA.ReadOnly = true;
            // 
            // kolomKota
            // 
            this.kolomKota.FillWeight = 12F;
            this.kolomKota.HeaderText = "Kota";
            this.kolomKota.MinimumWidth = 8;
            this.kolomKota.Name = "kolomKota";
            this.kolomKota.ReadOnly = true;
            // 
            // kolomNegara
            // 
            this.kolomNegara.FillWeight = 11F;
            this.kolomNegara.HeaderText = "Negara";
            this.kolomNegara.MinimumWidth = 8;
            this.kolomNegara.Name = "kolomNegara";
            this.kolomNegara.ReadOnly = true;
            // 
            // kolomJumlahTerminal
            // 
            this.kolomJumlahTerminal.FillWeight = 14F;
            this.kolomJumlahTerminal.HeaderText = "Jumlah Terminal";
            this.kolomJumlahTerminal.MinimumWidth = 8;
            this.kolomJumlahTerminal.Name = "kolomJumlahTerminal";
            this.kolomJumlahTerminal.ReadOnly = true;
            // 
            // kolomAlamat
            // 
            this.kolomAlamat.FillWeight = 20F;
            this.kolomAlamat.HeaderText = "Alamat";
            this.kolomAlamat.MinimumWidth = 8;
            this.kolomAlamat.Name = "kolomAlamat";
            this.kolomAlamat.ReadOnly = true;
            // 
            // kolomUbah
            // 
            this.kolomUbah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomUbah.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.kolomHapus.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(454, 456);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 28);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.AcceptsReturn = true;
            this.txtAlamat.Location = new System.Drawing.Point(422, 342);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlamat.Size = new System.Drawing.Size(241, 84);
            this.txtAlamat.TabIndex = 14;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(323, 345);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(68, 25);
            this.lblAlamat.TabIndex = 13;
            this.lblAlamat.Text = "Alamat";
            // 
            // nudJumlahTerminal
            // 
            this.nudJumlahTerminal.Location = new System.Drawing.Point(422, 321);
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
            this.nudJumlahTerminal.Size = new System.Drawing.Size(241, 31);
            this.nudJumlahTerminal.TabIndex = 12;
            this.nudJumlahTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJumlahTerminal
            // 
            this.lblJumlahTerminal.AutoSize = true;
            this.lblJumlahTerminal.Location = new System.Drawing.Point(323, 324);
            this.lblJumlahTerminal.Name = "lblJumlahTerminal";
            this.lblJumlahTerminal.Size = new System.Drawing.Size(137, 25);
            this.lblJumlahTerminal.TabIndex = 11;
            this.lblJumlahTerminal.Text = "Jumlah Terminal";
            // 
            // cmbNegara
            // 
            this.cmbNegara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegara.FormattingEnabled = true;
            this.cmbNegara.Location = new System.Drawing.Point(107, 414);
            this.cmbNegara.Name = "cmbNegara";
            this.cmbNegara.Size = new System.Drawing.Size(193, 33);
            this.cmbNegara.TabIndex = 10;
            // 
            // lblNegara
            // 
            this.lblNegara.AutoSize = true;
            this.lblNegara.Location = new System.Drawing.Point(21, 417);
            this.lblNegara.Name = "lblNegara";
            this.lblNegara.Size = new System.Drawing.Size(69, 25);
            this.lblNegara.TabIndex = 9;
            this.lblNegara.Text = "Negara";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(107, 383);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(193, 31);
            this.txtKota.TabIndex = 8;
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(21, 386);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(48, 25);
            this.lblKota.TabIndex = 7;
            this.lblKota.Text = "Kota";
            // 
            // txtKodeIATA
            // 
            this.txtKodeIATA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeIATA.Location = new System.Drawing.Point(107, 352);
            this.txtKodeIATA.MaxLength = 3;
            this.txtKodeIATA.Name = "txtKodeIATA";
            this.txtKodeIATA.Size = new System.Drawing.Size(193, 31);
            this.txtKodeIATA.TabIndex = 6;
            // 
            // lblKodeIATA
            // 
            this.lblKodeIATA.AutoSize = true;
            this.lblKodeIATA.Location = new System.Drawing.Point(21, 355);
            this.lblKodeIATA.Name = "lblKodeIATA";
            this.lblKodeIATA.Size = new System.Drawing.Size(94, 25);
            this.lblKodeIATA.TabIndex = 5;
            this.lblKodeIATA.Text = "Kode IATA";
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
            // FormMasterBandara
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.dgvBandara);
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
