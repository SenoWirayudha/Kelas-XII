using System;
using System.Linq;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    public partial class DaftarAkunForm : Form
    {
        // Penanda: apakah pendaftaran sudah berhasil.
        // Kalau sudah berhasil, LoginForm tidak perlu ditampilkan lagi.
        private bool pendaftaranBerhasil = false;

        public DaftarAkunForm()
        {
            InitializeComponent();
        }

        // Ketika tombol Daftar ditekan
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input
            string username = txtUsername.Text.Trim();
            string nama = txtNama.Text.Trim();
            string telepon = txtTelepon.Text.Trim();
            string password = txtPassword.Text;
            DateTime tanggalLahir = dtpTanggalLahir.Value;

            // Validasi dicek berurutan.
            // Berhenti di error pertama dan tampilkan satu pesan saja.

            // 1. Semua field wajib diisi
            if (username == "")
            {
                MessageBox.Show("Username harus diisi.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (nama == "")
            {
                MessageBox.Show("Nama harus diisi.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (telepon == "")
            {
                MessageBox.Show("Nomor telepon harus diisi.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelepon.Focus();
                return;
            }

            if (password.Trim() == "")
            {
                MessageBox.Show("Password harus diisi.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 2. Username harus unik di tabel Akun (tidak peka huruf besar/kecil)
            bool usernameSudahDipakai = false;
            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    usernameSudahDipakai = db.Akun
                        .Any(a => a.Username.ToLower() == username.ToLower());
                }
            }
            catch
            {
                // Database tidak bisa diakses: jangan sampai aplikasi crash
                MessageBox.Show("Tidak dapat terhubung ke database.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usernameSudahDipakai)
            {
                MessageBox.Show("Username sudah dipakai, silakan pilih username lain.",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            // 3. Nomor telepon harus angka saja, panjang 10 sampai 15 digit
            bool teleponAngka = true;
            for (int i = 0; i < telepon.Length; i++)
            {
                if (char.IsDigit(telepon[i]) == false)
                {
                    teleponAngka = false;
                }
            }

            if (teleponAngka == false || telepon.Length < 10 || telepon.Length > 15)
            {
                MessageBox.Show("Nomor telepon harus angka saja dan panjangnya 10 sampai 15 digit.",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelepon.Focus();
                return;
            }

            // 4. Password minimal 8 karakter
            if (password.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // 5. Tanggal lahir tidak boleh hari ini atau di masa depan
            if (tanggalLahir.Date >= DateTime.Today)
            {
                MessageBox.Show("Tanggal lahir tidak boleh hari ini atau di masa depan.",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTanggalLahir.Focus();
                return;
            }

            // Semua validasi lolos -> simpan akun baru ke database
            Models.Akun akunBaru = null;
            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    akunBaru = new Models.Akun();
                    akunBaru.Username = username;
                    akunBaru.Password = password;
                    akunBaru.Nama = nama;
                    akunBaru.TanggalLahir = tanggalLahir.Date;
                    akunBaru.NomorTelepon = telepon;
                    // Pendaftaran dari form ini selalu customer (bukan admin)
                    akunBaru.MerupakanAdmin = false;

                    db.Akun.Add(akunBaru);
                    // Kolom ID identity, jadi terisi otomatis oleh database
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simpan akun ke SesiLogin, sama seperti setelah login
            SesiLogin.idAkun = akunBaru.ID;
            SesiLogin.username = akunBaru.Username;
            SesiLogin.nama = akunBaru.Nama;
            SesiLogin.merupakanAdmin = false;

            // Kosongkan input, buka form Customer, lalu tutup form pendaftaran
            KosongkanInput();
            pendaftaranBerhasil = true;
            CustomerMainForm formCustomer = new CustomerMainForm();
            formCustomer.Show();
            this.Close();
        }

        // Kosongkan semua kolom input
        private void KosongkanInput()
        {
            txtUsername.Text = "";
            txtNama.Text = "";
            txtTelepon.Text = "";
            txtPassword.Text = "";
            dtpTanggalLahir.Value = DateTime.Today;
        }

        // Ketika link "Login" diklik, tutup form ini.
        // FormClosing di bawah akan menampilkan LoginForm kembali.
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // Kalau form ini ditutup (tombol X atau link Login), tampilkan lagi LoginForm
        private void DaftarAkunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && pendaftaranBerhasil == false)
            {
                if (LoginForm.formLoginUtama != null)
                {
                    LoginForm.formLoginUtama.Show();
                }
            }
        }
    }
}
