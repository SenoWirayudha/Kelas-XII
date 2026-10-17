using System;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    public partial class LoginForm : Form
    {
        // Referensi ke form login utama, supaya bisa ditampilkan lagi
        // ketika DaftarAkunForm ditutup.
        public static LoginForm formLoginUtama;

        public LoginForm()
        {
            InitializeComponent();

            // Simpan referensi ke diri sendiri
            formLoginUtama = this;
        }

        // Ketika tombol Login ditekan
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi: kolom tidak boleh kosong
            if (username == "")
            {
                MessageBox.Show("Username tidak boleh kosong", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (password.Trim() == "")
            {
                MessageBox.Show("Password tidak boleh kosong", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Cari akun di data dummy (List di memori)
            Akun akunKetemu = DataDummy.CariAkun(username, password);

            // Kalau tidak ketemu, berarti login gagal
            if (akunKetemu == null)
            {
                MessageBox.Show("Username atau password salah.", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simpan data akun ke SesiLogin
            SesiLogin.idAkun = akunKetemu.ID;
            SesiLogin.username = akunKetemu.Username;
            SesiLogin.nama = akunKetemu.Nama;
            SesiLogin.merupakanAdmin = akunKetemu.MerupakanAdmin;
            SesiLogin.akunSaatIni = akunKetemu;

            // Buka form sesuai peran (Admin atau Customer)
            if (SesiLogin.merupakanAdmin == true)
            {
                AdminMainForm formAdmin = new AdminMainForm();
                this.Hide();
                formAdmin.Show();
            }
            else
            {
                CustomerMainForm formCustomer = new CustomerMainForm();
                this.Hide();
                formCustomer.Show();
            }
        }

        // Ketika link "Daftar Sekarang!" diklik, buka form pendaftaran
        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkunForm formDaftar = new DaftarAkunForm();
            this.Hide();
            formDaftar.Show();
        }

        // Kalau form login ditutup (tombol X), tutup seluruh aplikasi.
        // Ini juga menutup form login lama yang masih tersembunyi
        // setelah proses logout.
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
