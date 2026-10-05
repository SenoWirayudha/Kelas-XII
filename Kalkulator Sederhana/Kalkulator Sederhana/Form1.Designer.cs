namespace Kalkulator_Sederhana
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblAngka1 = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.lblAngka2 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.lblHasilJudul = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblAksi = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(306, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Calculator Sederhana";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAngka1
            // 
            this.lblAngka1.Location = new System.Drawing.Point(12, 46);
            this.lblAngka1.Name = "lblAngka1";
            this.lblAngka1.Size = new System.Drawing.Size(306, 20);
            this.lblAngka1.TabIndex = 1;
            this.lblAngka1.Text = "Angka 1";
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(12, 66);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(306, 23);
            this.txtAngka1.TabIndex = 2;
            // 
            // lblAngka2
            // 
            this.lblAngka2.Location = new System.Drawing.Point(12, 94);
            this.lblAngka2.Name = "lblAngka2";
            this.lblAngka2.Size = new System.Drawing.Size(306, 20);
            this.lblAngka2.TabIndex = 3;
            this.lblAngka2.Text = "Angka 2";
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(12, 114);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(306, 23);
            this.txtAngka2.TabIndex = 4;
            // 
            // lblHasilJudul
            // 
            this.lblHasilJudul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHasilJudul.Location = new System.Drawing.Point(12, 143);
            this.lblHasilJudul.Name = "lblHasilJudul";
            this.lblHasilJudul.Size = new System.Drawing.Size(56, 23);
            this.lblHasilJudul.TabIndex = 5;
            this.lblHasilJudul.Text = "Hasil :";
            this.lblHasilJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHasil
            // 
            this.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasil.Location = new System.Drawing.Point(74, 143);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(244, 23);
            this.lblHasil.TabIndex = 6;
            this.lblHasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAksi
            // 
            this.lblAksi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAksi.Location = new System.Drawing.Point(12, 172);
            this.lblAksi.Name = "lblAksi";
            this.lblAksi.Size = new System.Drawing.Size(306, 23);
            this.lblAksi.TabIndex = 7;
            this.lblAksi.Text = "Aksi";
            this.lblAksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 200);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(306, 28);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(12, 232);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(306, 28);
            this.btnKurang.TabIndex = 9;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(12, 264);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(306, 28);
            this.btnKali.TabIndex = 10;
            this.btnKali.Text = "Kali";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(12, 296);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(306, 28);
            this.btnBagi.TabIndex = 11;
            this.btnBagi.Text = "Bagi";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 340);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblAngka1);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.lblAngka2);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.lblHasilJudul);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblAksi);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnBagi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Sederhana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblAngka1;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.Label lblAngka2;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label lblHasilJudul;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblAksi;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
    }
}
