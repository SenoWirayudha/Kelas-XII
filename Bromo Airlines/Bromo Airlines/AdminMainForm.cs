using System;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form placeholder untuk Admin (isi lengkap dikerjakan di tahap berikutnya)
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        // Kalau form ini ditutup, seluruh aplikasi ikut ditutup
        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
