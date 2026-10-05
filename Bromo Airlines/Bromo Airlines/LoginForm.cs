using System;
using System.Data.SqlClient;
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

            // Tampilkan logo Bromo Airlines (kalau file-nya ada)
            picLogo.Image = GambarLogo.Muat();
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

            // Cari akun di tabel Akun (pakai parameter supaya aman)
            try
            {
                SqlConnection koneksi = new SqlConnection(Koneksi.connectionString);
                koneksi.Open();

                string query = "SELECT ID, Username, Nama, MerupakanAdmin FROM Akun " +
                               "WHERE Username = @username AND Password = @password";

                SqlCommand perintah = new SqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@username", username);
                perintah.Parameters.AddWithValue("@password", password);

                SqlDataReader pembaca = perintah.ExecuteReader();

                // Kalau tidak ada baris yang cocok, berarti login gagal
                if (pembaca.Read() == false)
                {
                    pembaca.Close();
                    koneksi.Close();
                    MessageBox.Show("Username atau password salah", "Login Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Simpan data akun ke SesiLogin
                SesiLogin.idAkun = Convert.ToInt32(pembaca["ID"]);
                SesiLogin.username = pembaca["Username"].ToString();
                SesiLogin.nama = pembaca["Nama"].ToString();
                SesiLogin.merupakanAdmin = Convert.ToBoolean(pembaca["MerupakanAdmin"]);

                pembaca.Close();
                koneksi.Close();

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
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca data database: " + ex.Message,
                    "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ketika link "Daftar Sekarang!" diklik, buka form pendaftaran
        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkunForm formDaftar = new DaftarAkunForm();
            this.Hide();
            formDaftar.Show();
        }
    }
}
