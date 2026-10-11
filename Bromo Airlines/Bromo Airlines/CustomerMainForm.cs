using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form placeholder untuk Customer (isi lengkap dikerjakan di tahap berikutnya)
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        // Kalau form ini ditutup, seluruh aplikasi ikut ditutup
        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
