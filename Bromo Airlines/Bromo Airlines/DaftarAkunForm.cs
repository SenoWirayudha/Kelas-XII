using System;
using System.Data.SqlClient;
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

            // Validasi 2: username harus unik (dicek ke database)
            try
            {
                SqlConnection koneksi = new SqlConnection(Koneksi.connectionString);
                koneksi.Open();

                SqlCommand perintah = new SqlCommand(
                    "SELECT COUNT(*) FROM Akun WHERE Username = @username", koneksi);
                perintah.Parameters.AddWithValue("@username", username);

                int jumlah = Convert.ToInt32(perintah.ExecuteScalar());
                koneksi.Close();

                if (jumlah > 0)
                {
                    MessageBox.Show("Username sudah dipakai, silakan pilih username lain",
                        "Daftar Akun", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca data database: " + ex.Message,
                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Semua validasi lolos -> simpan akun baru ke tabel Akun
            try
            {
                SqlConnection koneksi = new SqlConnection(Koneksi.connectionString);
                koneksi.Open();

                // Masukkan data dengan MerupakanAdmin = 0 (Customer)
                string insert = "INSERT INTO Akun " +
                    "(Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin) " +
                    "VALUES (@username, @password, @nama, @tanggallahir, @nomortelepon, 0)";

                SqlCommand simpan = new SqlCommand(insert, koneksi);
                simpan.Parameters.AddWithValue("@username", username);
                simpan.Parameters.AddWithValue("@password", password);
                simpan.Parameters.AddWithValue("@nama", nama);
                simpan.Parameters.AddWithValue("@tanggallahir", tanggalLahir.Date);
                simpan.Parameters.AddWithValue("@nomortelepon", telepon);
                simpan.ExecuteNonQuery();

                // Ambil ID akun yang baru dibuat
                SqlCommand ambilId = new SqlCommand(
                    "SELECT ID FROM Akun WHERE Username = @username", koneksi);
                ambilId.Parameters.AddWithValue("@username", username);
                int idBaru = Convert.ToInt32(ambilId.ExecuteScalar());

                koneksi.Close();

                // Simpan akun ke SesiLogin
                SesiLogin.idAkun = idBaru;
                SesiLogin.username = username;
                SesiLogin.nama = nama;
                SesiLogin.merupakanAdmin = false;

                // Buka form Customer, lalu tutup form pendaftaran
                pendaftaranBerhasil = true;
                CustomerMainForm formCustomer = new CustomerMainForm();
                formCustomer.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message,
                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
