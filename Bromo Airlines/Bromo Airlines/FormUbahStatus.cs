using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Ubah Status Penerbangan: menampilkan semua jadwal beserta
    // status terakhirnya, dan menambah riwayat perubahan status.
    // Data masih disimpan di DataDummy (di memori).
    public partial class FormUbahStatus : Form
    {
        // ID jadwal yang sedang diubah statusnya lewat tombol Ubah.
        // Kalau 0 = belum ada jadwal dipilih (panel tersembunyi).
        private int idJadwalDipilih = 0;

        // Penanda: apakah form ini ditutup lewat tombol Logout.
        private bool logoutBerhasil = false;

        // Warna latar item menu saat kursor masuk (sangat muda)
        private Color warnaHover = Color.FromArgb(245, 245, 245);

        public FormUbahStatus()
        {
            InitializeComponent();

            // Isi ComboBox status mengikuti urutan list (Sesuai Jadwal, Delay, Dibatalkan)
            cmbStatus.DataSource = new List<StatusPenerbangan>(DataDummy.daftarStatusPenerbangan);
            cmbStatus.DisplayMember = "Nama";
            cmbStatus.ValueMember = "Id";

            // Panel input masih tersembunyi sampai tombol Ubah diklik
            pnlUbahStatus.Visible = false;

            // Tampilkan data jadwal di grid
            MuatGrid();

            // Sidebar mengikuti status terakhir (melebar / mengecil)
            TerapkanUkuranMenu();
        }

        // Klik salah satu item menu
        private void Item_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);

            // Menu halaman ini: tidak melakukan apa-apa
            if (index == 4)
            {
                return;
            }

            // Klik Logout
            if (index == 5)
            {
                TanyaLogout();
                return;
            }

            // Buka halaman lain sesuai menu yang diklik
            Form tujuan = null;
            if (index == 0) tujuan = new FormMasterBandara();
            if (index == 1) tujuan = new FormMasterMaskapai();
            if (index == 2) tujuan = new FormMasterJadwal();
            if (index == 3) tujuan = new FormMasterKodePromo();

            NavigasiAdmin.PindahKe(this, tujuan);
        }

        // Mencari panel item menu berdasarkan index (0-4 menu utama, 5 = logout)
        private Panel PanelMenu(int index)
        {
            if (index == 0) return pnlMenu0;
            if (index == 1) return pnlMenu1;
            if (index == 2) return pnlMenu2;
            if (index == 3) return pnlMenu3;
            if (index == 4) return pnlMenu4;
            return pnlLogout;
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);
            PanelMenu(index).BackColor = warnaHover;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);
            PanelMenu(index).BackColor = Color.White;
        }

        // Tombol hamburger: perbesar / perkecil panel menu.
        // Statusnya disimpan di NavigasiAdmin supaya sama di semua halaman.
        private void btnMenu_Click(object sender, EventArgs e)
        {
            NavigasiAdmin.menuKecil = !NavigasiAdmin.menuKecil;
            TerapkanUkuranMenu();
        }

        // Menerapkan lebar sidebar dan visibilitas teks menu
        // sesuai status NavigasiAdmin.menuKecil
        private void TerapkanUkuranMenu()
        {
            Label[] daftarTeks = { lblMenu0, lblMenu1, lblMenu2, lblMenu3, lblMenu4, lblLogout };

            if (NavigasiAdmin.menuKecil == true)
            {
                panelMenu.Width = 60;
                for (int i = 0; i < daftarTeks.Length; i++)
                {
                    daftarTeks[i].Visible = false;
                }
            }
            else
            {
                panelMenu.Width = 220;
                for (int i = 0; i < daftarTeks.Length; i++)
                {
                    daftarTeks[i].Visible = true;
                }
            }
        }

        // Tombol Logout: konfirmasi, lalu kembali ke Login Form
        private void TanyaLogout()
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

                // Tampilkan Login Form (baru, jadi kolomnya kosong)
                LoginForm formLogin = new LoginForm();
                formLogin.Show();

                // Tutup form ini tanpa menutup aplikasi
                this.Close();
            }
        }

        // Tombol X menutup aplikasi, KECUALI saat logout
        // atau sedang pindah halaman lewat menu.
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing &&
                logoutBerhasil == false &&
                NavigasiAdmin.sedangPindah == false)
            {
                Application.Exit();
            }
        }

        // Mengurutkan jadwal: yang keberangkatannya paling awal di atas
        private List<JadwalPenerbangan> JadwalUrut()
        {
            List<JadwalPenerbangan> hasil = new List<JadwalPenerbangan>(DataDummy.daftarJadwalPenerbangan);
            hasil.Sort(delegate (JadwalPenerbangan a, JadwalPenerbangan b)
            {
                return a.TanggalKeberangkatan.CompareTo(b.TanggalKeberangkatan);
            });
            return hasil;
        }

        // Mengisi ulang grid dari data dummy
        private void MuatGrid()
        {
            dgvStatus.Rows.Clear();

            List<JadwalPenerbangan> daftar = JadwalUrut();
            for (int i = 0; i < daftar.Count; i++)
            {
                JadwalPenerbangan jadwal = daftar[i];
                dgvStatus.Rows.Add(
                    jadwal.KodePenerbangan,
                    NamaMaskapai(jadwal.MaskapaiId),
                    NamaBandara(jadwal.BandaraAsalId),
                    NamaBandara(jadwal.BandaraTujuanId),
                    jadwal.TanggalKeberangkatan.ToString("dd-MM-yyyy"),
                    jadwal.TanggalKeberangkatan.ToString("HH:mm"),
                    DataDummy.FormatDurasi(jadwal.DurasiMenit),
                    DataDummy.TeksStatusTerakhir(jadwal.Id),
                    TeksTerakhirDiubah(jadwal.Id));

                // Simpan ID jadwal di baris, supaya tahu baris mana yang diklik
                dgvStatus.Rows[i].Tag = jadwal.Id;
            }
        }

        // Mencari nama bandara berdasarkan ID. Kalau tidak ketemu = "-"
        private string NamaBandara(int id)
        {
            for (int i = 0; i < DataDummy.daftarBandara.Count; i++)
            {
                if (DataDummy.daftarBandara[i].ID == id)
                {
                    return DataDummy.daftarBandara[i].Nama;
                }
            }
            return "-";
        }

        // Mencari nama maskapai berdasarkan ID. Kalau tidak ketemu = "-"
        private string NamaMaskapai(int id)
        {
            for (int i = 0; i < DataDummy.daftarMaskapai.Count; i++)
            {
                if (DataDummy.daftarMaskapai[i].Id == id)
                {
                    return DataDummy.daftarMaskapai[i].Nama;
                }
            }
            return "-";
        }

        // Mencari data jadwal berdasarkan ID. Kalau tidak ketemu = null.
        private JadwalPenerbangan CariJadwal(int id)
        {
            for (int i = 0; i < DataDummy.daftarJadwalPenerbangan.Count; i++)
            {
                if (DataDummy.daftarJadwalPenerbangan[i].Id == id)
                {
                    return DataDummy.daftarJadwalPenerbangan[i];
                }
            }
            return null;
        }

        // Teks waktu perubahan terakhir untuk ditampilkan di grid.
        // Belum ada riwayat = "-".
        private string TeksTerakhirDiubah(int jadwalId)
        {
            PerubahanStatusJadwal terakhir = DataDummy.CariPerubahanStatusTerakhir(jadwalId);
            if (terakhir == null)
            {
                return "-";
            }
            return terakhir.WaktuPerubahanTerjadi.ToString("dd-MM-yyyy HH:mm:ss");
        }

        // Klik tombol Ubah di grid
        private void dgvStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header kolom
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvStatus.Columns["kolomUbah"].Index)
            {
                int id = Convert.ToInt32(dgvStatus.Rows[e.RowIndex].Tag);
                TampilkanPanel(id);
            }
        }

        // Menampilkan panel input dan memuat data jadwal terpilih ke input
        private void TampilkanPanel(int id)
        {
            JadwalPenerbangan jadwal = CariJadwal(id);
            if (jadwal == null)
            {
                return;
            }

            idJadwalDipilih = id;
            pnlUbahStatus.Visible = true;

            // Pilih status terakhir jadwal ini di ComboBox
            // (jadwal tanpa riwayat = Sesuai Jadwal)
            PerubahanStatusJadwal terakhir = DataDummy.CariPerubahanStatusTerakhir(id);
            int statusId = 1; // Sesuai Jadwal
            int delayMenit = 0;
            if (terakhir != null)
            {
                statusId = terakhir.StatusPenerbanganId;
                delayMenit = terakhir.PerkiraanDelayMenit;
            }
            cmbStatus.SelectedValue = statusId;

            // Kalau statusnya Delay, tampilkan juga input durasi delay
            if (DataDummy.NamaStatus(statusId) == "Delay")
            {
                lblDelay.Visible = true;
                mtbDelay.Visible = true;
                mtbDelay.Text = DataDummy.FormatDurasi(delayMenit);
            }
            else
            {
                lblDelay.Visible = false;
                mtbDelay.Visible = false;
                mtbDelay.Clear();
            }

            // Gulir otomatis supaya panel terlihat
            this.ScrollControlIntoView(pnlUbahStatus);
        }

        // Menyembunyikan panel dan mereset inputnya
        private void SembunyikanPanel()
        {
            idJadwalDipilih = 0;
            pnlUbahStatus.Visible = false;
            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0;
            }
            lblDelay.Visible = false;
            mtbDelay.Visible = false;
            mtbDelay.Clear();
        }

        // Saat status di ComboBox diganti: tampilkan/sembunyikan input delay
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                return;
            }

            StatusPenerbangan status = cmbStatus.SelectedItem as StatusPenerbangan;
            if (status != null && status.Nama == "Delay")
            {
                lblDelay.Visible = true;
                mtbDelay.Visible = true;
            }
            else
            {
                lblDelay.Visible = false;
                mtbDelay.Visible = false;
                mtbDelay.Clear();
            }
        }

        // Membaca jam dan menit dari MaskedTextBox durasi delay
        // (mask "00 j\am 00 menit"). Kalau belum terisi penuh, hasilnya false.
        private bool AmbilDelay(out int jam, out int menit)
        {
            jam = 0;
            menit = 0;

            if (mtbDelay.MaskCompleted == false)
            {
                return false;
            }

            // Contoh teks: "01 jam 30 menit"
            string teks = mtbDelay.Text;
            if (int.TryParse(teks.Substring(0, 2), out jam) == false)
            {
                return false;
            }
            if (int.TryParse(teks.Substring(7, 2), out menit) == false)
            {
                return false;
            }
            return true;
        }

        // Tombol Simpan: menambah satu riwayat perubahan status baru
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Panel memang tersembunyi kalau belum ada jadwal dipilih,
            // tapi tetap dilindungi supaya tidak error
            if (idJadwalDipilih == 0)
            {
                MessageBox.Show(
                    "Tidak ada jadwal yang dipilih. Klik tombol Ubah pada baris jadwal terlebih dahulu.",
                    "Ubah Status Penerbangan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            StatusPenerbangan status = cmbStatus.SelectedItem as StatusPenerbangan;

            // Kumpulkan semua kesalahan dulu, supaya tampil bersamaan
            List<string> daftarError = new List<string>();

            // ===== Status =====
            if (cmbStatus.SelectedItem == null)
            {
                daftarError.Add("Status harus dipilih.");
            }

            // ===== Perkiraan durasi delay (hanya kalau status Delay) =====
            bool delayValid = true;
            int delayMenit = 0;
            if (status != null && status.Nama == "Delay")
            {
                int jam, menit;
                if (AmbilDelay(out jam, out menit) == false)
                {
                    delayValid = false;
                    daftarError.Add("Perkiraan durasi delay wajib diisi dengan format " +
                        "jam dan menit (contoh: 01 jam 30 menit).");
                }
                else if (menit < 0 || menit > 59 || (jam == 0 && menit == 0))
                {
                    delayValid = false;
                    daftarError.Add("Perkiraan durasi delay harus lebih dari 00 jam 00 menit " +
                        "dan menit harus antara 00 sampai 59.");
                }
                else
                {
                    delayMenit = jam * 60 + menit;
                }
            }

            // ===== Tidak boleh sama dengan status terakhir =====
            // Jadwal tanpa riwayat dianggap status terakhirnya "Sesuai Jadwal".
            if (status != null && delayValid)
            {
                int statusTerakhirId = 1;
                int delayTerakhirMenit = 0;
                PerubahanStatusJadwal terakhir = DataDummy.CariPerubahanStatusTerakhir(idJadwalDipilih);
                if (terakhir != null)
                {
                    statusTerakhirId = terakhir.StatusPenerbanganId;
                    delayTerakhirMenit = terakhir.PerkiraanDelayMenit;
                }

                if (status.Id == statusTerakhirId && delayMenit == delayTerakhirMenit)
                {
                    daftarError.Add("Status tidak berubah dari status terakhir.");
                }
            }

            // Kalau ada kesalahan, tampilkan semuanya lalu berhenti
            if (daftarError.Count > 0)
            {
                MessageBox.Show(
                    "Status belum bisa disimpan:\n\n- " + string.Join("\n- ", daftarError),
                    "Ubah Status Penerbangan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Tambah satu riwayat baru (data lama tidak ditimpa)
            PerubahanStatusJadwal baru = new PerubahanStatusJadwal();
            baru.Id = DataDummy.IdBerikutnyaPerubahanStatus();
            baru.JadwalPenerbanganId = idJadwalDipilih;
            baru.StatusPenerbanganId = status.Id;
            baru.WaktuPerubahanTerjadi = DateTime.Now;
            baru.PerkiraanDelayMenit = delayMenit;
            DataDummy.daftarPerubahanStatus.Add(baru);

            MessageBox.Show("Status penerbangan berhasil diubah.", "Ubah Status Penerbangan",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Segarkan grid lalu sembunyikan panel
            MuatGrid();
            SembunyikanPanel();
        }

        // Tombol Batal: sembunyikan panel tanpa menyimpan apa pun
        private void btnBatal_Click(object sender, EventArgs e)
        {
            SembunyikanPanel();
        }
    }
}
