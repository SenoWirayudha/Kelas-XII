using System;
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

            // Tampilkan logo Bromo Airlines (kalau file-nya ada)
            picLogo.Image = GambarLogo.Muat();
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

            // Validasi 1: semua kolom wajib diisi
            if (username == "")
            {
                MessageBox.Show("Username harus diisi", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (nama == "")
            {
                MessageBox.Show("Nama harus diisi", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (telepon == "")
            {
                MessageBox.Show("Nomor telepon harus diisi", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelepon.Focus();
                return;
            }

            if (password.Trim() == "")
            {
                MessageBox.Show("Password harus diisi", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Validasi 2: username harus unik (dicek ke data dummy)
            if (DataDummy.UsernameSudahDipakai(username))
            {
                MessageBox.Show("Username sudah dipakai, silakan pilih username lain",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            // Validasi 3: nomor telepon harus angka saja, panjang 10 sampai 15 digit
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
                MessageBox.Show("Nomor telepon harus berupa angka saja dan panjangnya 10 sampai 15 digit",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelepon.Focus();
                return;
            }

            // Validasi 4: password minimal 8 karakter
            if (password.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter", "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Validasi 5: tanggal lahir tidak boleh lebih dari hari ini
            if (tanggalLahir.Date > DateTime.Today)
            {
                MessageBox.Show("Tanggal lahir tidak boleh lebih dari hari ini",
                    "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Semua validasi lolos -> simpan akun baru ke data dummy
            Akun akunBaru = new Akun();
            akunBaru.ID = DataDummy.IdBerikutnya();
            akunBaru.Username = username;
            akunBaru.Password = password;
            akunBaru.Nama = nama;
            akunBaru.TanggalLahir = tanggalLahir.Date;
            akunBaru.NomorTelepon = telepon;
            // Pendaftaran dari form ini selalu customer (bukan admin)
            akunBaru.MerupakanAdmin = false;

            DataDummy.TambahAkun(akunBaru);

            // Simpan akun ke SesiLogin
            SesiLogin.idAkun = akunBaru.ID;
            SesiLogin.username = akunBaru.Username;
            SesiLogin.nama = akunBaru.Nama;
            SesiLogin.merupakanAdmin = false;

            // Buka form Customer, lalu tutup form pendaftaran
            pendaftaranBerhasil = true;
            CustomerMainForm formCustomer = new CustomerMainForm();
            formCustomer.Show();
            this.Close();
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
