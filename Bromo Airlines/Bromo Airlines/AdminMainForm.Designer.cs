namespace Bromo_Airlines
{
    partial class AdminMainForm
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
            this.panelKonten = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGaris = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKonten
            // 
            this.panelKonten.AccessibleDescription = "s";
            this.panelKonten.BackColor = System.Drawing.Color.White;
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(375, 92);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(990, 770);
            this.panelKonten.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AccessibleDescription = "s";
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panelGaris);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 92);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(375, 770);
            this.panelMenu.TabIndex = 1;
            // 
            // panelGaris
            // 
            this.panelGaris.AccessibleDescription = "s";
            this.panelGaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelGaris.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGaris.Location = new System.Drawing.Point(373, 0);
            this.panelGaris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGaris.Name = "panelGaris";
            this.panelGaris.Size = new System.Drawing.Size(2, 770);
            this.panelGaris.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.AccessibleDescription = "s";
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.panelHeader.Controls.Add(this.lblJudul);
            this.panelHeader.Controls.Add(this.btnMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1365, 92);
            this.panelHeader.TabIndex = 2;
            // 
            // lblJudul
            // 
            this.lblJudul.AccessibleDescription = "s";
            this.lblJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(75, 0);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblJudul.Size = new System.Drawing.Size(1290, 92);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Dashboard";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMenu
            // 
            this.btnMenu.AccessibleDescription = "s";
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(93)))), ((int)(((byte)(170)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 92);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 862);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1039, 662);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainForm_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGaris;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblJudul;
    }
}
