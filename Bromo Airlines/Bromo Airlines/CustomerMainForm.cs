using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form utama Customer: sapaan, form pencarian penerbangan,
    // tombol Tiket Saya, dan tombol Logout.
    public partial class CustomerMainForm : Form
    {
        // Penanda: apakah form ini ditutup lewat tombol Logout.
        // Kalau iya, aplikasi TIDAK boleh ikut ditutup.
        private bool logoutBerhasil = false;

        public CustomerMainForm()
        {
            InitializeComponent();

            // Ilustrasi gunung selalu di paling belakang
            picMountain.SendToBack();

            // Sapaan memakai nama akun yang sedang login
            lblSapaan.Text = "Mau terbang ke mana hari ini, " + SesiLogin.nama + "?";

            // Isi ComboBox bandara, diurutkan A-Z berdasarkan nama bandara.
            // Tiap ComboBox memakai list sendiri-sendiri supaya
            // pilihan di satu ComboBox tidak menggeser yang lain.
            List<Bandara> bandaraUrut = new List<Bandara>(DataDummy.daftarBandara);
            bandaraUrut.Sort((a, b) => a.Nama.CompareTo(b.Nama));

            List<PilihanBandara> pilihanAsal = new List<PilihanBandara>();
            List<PilihanBandara> pilihanTujuan = new List<PilihanBandara>();
            foreach (Bandara bandara in bandaraUrut)
            {
                PilihanBandara pilihan = new PilihanBandara();
                pilihan.Id = bandara.ID;
                pilihan.Teks = bandara.Nama + ", " + bandara.Kota + " (" + bandara.KodeIATA + ")";
                pilihanAsal.Add(pilihan);
                pilihanTujuan.Add(pilihan);
            }

            cmbAsal.DisplayMember = "Teks";
            cmbAsal.ValueMember = "Id";
            cmbAsal.DataSource = pilihanAsal;

            cmbTujuan.DisplayMember = "Teks";
            cmbTujuan.ValueMember = "Id";
            cmbTujuan.DataSource = pilihanTujuan;

            // Pilihan awal: Juanda (SUB) -> Soekarno-Hatta (CGK),
            // kalau tidak ada pakai bandara pertama dan kedua.
            int indexAsal = CariIndexBandara(pilihanAsal, "(SUB)");
            int indexTujuan = CariIndexBandara(pilihanTujuan, "(CGK)");
            if (indexAsal < 0)
            {
                indexAsal = 0;
            }
            if (indexTujuan < 0)
            {
                indexTujuan = pilihanTujuan.Count > 1 ? 1 : 0;
            }
            cmbAsal.SelectedIndex = indexAsal;
            cmbTujuan.SelectedIndex = indexTujuan;

            // Tanggal awal = hari ini
            dtpTanggal.Value = DateTime.Today;
        }

        // Mencari index bandara yang teksnya diakhiri kode IATA,
        // misalnya "(SUB)". Hasil -1 berarti tidak ketemu.
        private int CariIndexBandara(List<PilihanBandara> daftar, string kode)
        {
            for (int i = 0; i < daftar.Count; i++)
            {
                if (daftar[i].Teks.EndsWith(kode))
                {
                    return i;
                }
            }
            return -1;
        }

        // Tombol Tiket Saya: buka daftar tiket aktif milik akun ini
        private void picTiketSaya_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTiketSaya formTiket = new FormTiketSaya();
            formTiket.ShowDialog();
            this.Show();
        }

        // Tombol Logout: konfirmasi, kosongkan sesi, kembali ke Login
        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult jawaban = MessageBox.Show(
                "Yakin ingin logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawaban == DialogResult.Yes)
            {
                logoutBerhasil = true;

                // Kosongkan sesi login
                SesiLogin.idAkun = 0;
                SesiLogin.username = "";
                SesiLogin.nama = "";
                SesiLogin.merupakanAdmin = false;
                SesiLogin.akunSaatIni = null;

                // Tampilkan Login Form baru (kolomnya kosong)
                LoginForm formLogin = new LoginForm();
                formLogin.Show();

                // Tutup Customer Main Form tanpa menutup aplikasi
                this.Close();
            }
        }

        // Tombol Cari Penerbangan: validasi dulu, lalu buka form hasil pencarian.
        private void btnCari_Click(object sender, EventArgs e)
        {
            PilihanBandara asal = cmbAsal.SelectedItem as PilihanBandara;
            PilihanBandara tujuan = cmbTujuan.SelectedItem as PilihanBandara;

            // Kumpulkan semua kesalahan dulu, tampilkan sekaligus
            List<string> kesalahan = new List<string>();

            if (asal == null)
            {
                kesalahan.Add("Bandara asal wajib dipilih.");
            }

            if (tujuan == null)
            {
                kesalahan.Add("Bandara tujuan wajib dipilih.");
            }

            if (asal != null && tujuan != null && asal.Id == tujuan.Id)
            {
                kesalahan.Add("Bandara asal dan tujuan tidak boleh sama.");
            }

            if (dtpTanggal.Value.Date < DateTime.Today)
            {
                kesalahan.Add("Tanggal berangkat tidak boleh sebelum hari ini.");
            }

            if (nudPenumpang.Value < 1)
            {
                kesalahan.Add("Jumlah penumpang minimal 1.");
            }

            if (kesalahan.Count > 0)
            {
                MessageBox.Show(string.Join("\n", kesalahan.ToArray()), "Cari Penerbangan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buka form hasil pencarian, lalu tampilkan lagi form ini
            // setelah form hasil ditutup.
            this.Hide();
            FormListPenerbangan formList = new FormListPenerbangan(
                asal.Id, tujuan.Id, dtpTanggal.Value.Date, (int)nudPenumpang.Value);
            formList.ShowDialog();
            this.Show();
        }

        // Kalau form ini ditutup lewat tombol X (bukan Logout),
        // tutup seluruh aplikasi
        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && logoutBerhasil == false)
            {
                Application.Exit();
            }
        }
    }
}
