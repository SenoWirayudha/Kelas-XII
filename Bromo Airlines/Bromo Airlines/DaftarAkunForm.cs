using System;
using System.Collections.Generic;
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

            // Ikon jendela + logo dari resource
            this.Icon = Properties.Resources.favicon;
            picLogo.Image = Properties.Resources.logo_register;
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

            // Validasi: semua kesalahan dikumpulkan dulu,
            // lalu ditampilkan sekaligus dalam satu MessageBox.
            List<string> kesalahan = new List<string>();

            if (username == "")
            {
                kesalahan.Add("Username harus diisi.");
            }

            if (nama == "")
            {
                kesalahan.Add("Nama harus diisi.");
            }

            if (telepon == "")
            {
                kesalahan.Add("Nomor telepon harus diisi.");
            }

            if (password.Trim() == "")
            {
                kesalahan.Add("Password harus diisi.");
            }

            // Username harus unik (tidak peka huruf besar/kecil)
            if (username != "" && DataDummy.UsernameSudahDipakai(username))
            {
                kesalahan.Add("Username sudah digunakan, silakan pilih username lain.");
            }

            // Nomor telepon harus angka saja, panjang 10 sampai 15 digit
            if (telepon != "")
            {
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
                    kesalahan.Add("Nomor telepon harus berupa angka saja dan panjangnya 10 sampai 15 digit.");
                }
            }

            // Password minimal 8 karakter
            if (password.Trim() != "" && password.Length < 8)
            {
                kesalahan.Add("Password minimal 8 karakter.");
            }

            // Tanggal lahir tidak boleh hari ini atau di masa depan
            if (tanggalLahir.Date >= DateTime.Today)
            {
                kesalahan.Add("Tanggal lahir tidak boleh hari ini atau di masa depan.");
            }

            if (kesalahan.Count > 0)
            {
                MessageBox.Show(string.Join("\n", kesalahan.ToArray()), "Daftar Akun",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            SesiLogin.akunSaatIni = akunBaru;

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
