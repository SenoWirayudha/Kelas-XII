using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Master Jadwal Penerbangan: menampilkan, menambah, mengubah,
    // dan menghapus jadwal penerbangan.
    // Data masih disimpan di DataDummy (di memori).
    public partial class FormMasterJadwal : Form
    {
        // ID jadwal yang sedang diubah. Kalau 0 = mode tambah biasa.
        private int idSedangDiubah = 0;

        // Penanda: apakah form ini ditutup lewat tombol Logout.
        private bool logoutBerhasil = false;

        // Warna latar item menu saat kursor masuk (sangat muda)
        private Color warnaHover = Color.FromArgb(245, 245, 245);

        public FormMasterJadwal()
        {
            InitializeComponent();

            // Isi ComboBox bandara urut A-Z.
            // cmbDari dan cmbKe memakai salinan list terpisah,
            // supaya pilihan di satu combo tidak ikut menggeser combo lain.
            cmbDari.DataSource = BandaraUrut();
            cmbDari.DisplayMember = "Nama";
            cmbDari.ValueMember = "ID";

            cmbKe.DataSource = BandaraUrut();
            cmbKe.DisplayMember = "Nama";
            cmbKe.ValueMember = "ID";

            // Isi ComboBox maskapai urut A-Z
            List<Maskapai> maskapaiUrut = new List<Maskapai>(DataDummy.daftarMaskapai);
            maskapaiUrut.Sort(delegate (Maskapai a, Maskapai b)
            {
                return string.Compare(a.Nama, b.Nama, StringComparison.OrdinalIgnoreCase);
            });
            cmbMaskapai.DataSource = maskapaiUrut;
            cmbMaskapai.DisplayMember = "Nama";
            cmbMaskapai.ValueMember = "Id";

            // Siapkan input kosong lalu tampilkan data di grid
            KosongkanInput();
            MuatGrid();

            // Sidebar mengikuti status terakhir (melebar / mengecil)
            TerapkanUkuranMenu();
        }

        // Klik salah satu item menu
        private void Item_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);

            // Menu halaman ini: tidak melakukan apa-apa
            if (index == 2)
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
            if (index == 3) tujuan = new FormMasterKodePromo();
            if (index == 4) tujuan = new FormUbahStatus();

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

        // Mengurutkan daftar bandara berdasarkan nama A-Z (tidak peka huruf besar/kecil)
        private List<Bandara> BandaraUrut()
        {
            List<Bandara> hasil = new List<Bandara>(DataDummy.daftarBandara);
            hasil.Sort(delegate (Bandara a, Bandara b)
            {
                return string.Compare(a.Nama, b.Nama, StringComparison.OrdinalIgnoreCase);
            });
            return hasil;
        }

        // Mengurutkan jadwal: yang keberangkatannya paling baru di atas
        private List<JadwalPenerbangan> JadwalUrut()
        {
            List<JadwalPenerbangan> hasil = new List<JadwalPenerbangan>(DataDummy.daftarJadwalPenerbangan);
            hasil.Sort(delegate (JadwalPenerbangan a, JadwalPenerbangan b)
            {
                return b.TanggalKeberangkatan.CompareTo(a.TanggalKeberangkatan);
            });
            return hasil;
        }

        // Mengisi ulang grid dari data dummy
        private void MuatGrid()
        {
            dgvJadwal.Rows.Clear();

            List<JadwalPenerbangan> daftar = JadwalUrut();
            for (int i = 0; i < daftar.Count; i++)
            {
                JadwalPenerbangan jadwal = daftar[i];
                dgvJadwal.Rows.Add(
                    jadwal.KodePenerbangan,
                    NamaBandara(jadwal.BandaraAsalId),
                    NamaBandara(jadwal.BandaraTujuanId),
                    NamaMaskapai(jadwal.MaskapaiId),
                    jadwal.TanggalKeberangkatan.ToString("dd-MM-yyyy"),
                    jadwal.TanggalKeberangkatan.ToString("HH:mm"),
                    FormatDurasi(jadwal.DurasiMenit),
                    jadwal.HargaPerTiket);

                // Simpan ID jadwal di baris, supaya tahu baris mana yang diklik
                dgvJadwal.Rows[i].Tag = jadwal.Id;
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

        // Mengubah jumlah menit menjadi teks "XX jam YY menit"
        private string FormatDurasi(int totalMenit)
        {
            int jam = totalMenit / 60;
            int menit = totalMenit % 60;
            return string.Format("{0:00} jam {1:00} menit", jam, menit);
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

        // Klik tombol Ubah atau Hapus di grid
        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header kolom
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = Convert.ToInt32(dgvJadwal.Rows[e.RowIndex].Tag);

            if (e.ColumnIndex == dgvJadwal.Columns["kolomUbah"].Index)
            {
                MuatKeInput(id);
            }
            else if (e.ColumnIndex == dgvJadwal.Columns["kolomHapus"].Index)
            {
                HapusJadwal(id);
            }
        }

        // Memuat data jadwal ke kolom input (masuk mode ubah)
        private void MuatKeInput(int id)
        {
            JadwalPenerbangan jadwal = CariJadwal(id);
            if (jadwal == null)
            {
                return;
            }

            idSedangDiubah = id;
            mtbKode.Text = jadwal.KodePenerbangan;
            cmbDari.SelectedValue = jadwal.BandaraAsalId;
            cmbKe.SelectedValue = jadwal.BandaraTujuanId;
            cmbMaskapai.SelectedValue = jadwal.MaskapaiId;
            dtpTanggal.Value = jadwal.TanggalKeberangkatan.Date;
            mtbWaktu.Text = jadwal.TanggalKeberangkatan.ToString("HH:mm");
            mtbDurasi.Text = FormatDurasi(jadwal.DurasiMenit);
            nudHarga.Value = jadwal.HargaPerTiket;
        }

        // Membaca jam dan menit dari MaskedTextBox waktu (mask "00:00").
        // Kalau belum terisi penuh, hasilnya false.
        private bool AmbilWaktu(out int jam, out int menit)
        {
            jam = 0;
            menit = 0;

            if (mtbWaktu.MaskCompleted == false)
            {
                return false;
            }

            // Contoh teks: "19:55"
            string teks = mtbWaktu.Text;
            if (int.TryParse(teks.Substring(0, 2), out jam) == false)
            {
                return false;
            }
            if (int.TryParse(teks.Substring(3, 2), out menit) == false)
            {
                return false;
            }
            return true;
        }

        // Membaca jam dan menit dari MaskedTextBox durasi
        // (mask "00 j\am 00 menit"). Kalau belum terisi penuh, hasilnya false.
        private bool AmbilDurasi(out int jam, out int menit)
        {
            jam = 0;
            menit = 0;

            if (mtbDurasi.MaskCompleted == false)
            {
                return false;
            }

            // Contoh teks: "01 jam 10 menit"
            string teks = mtbDurasi.Text;
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

        // Tombol Simpan: mode tambah kalau idSedangDiubah = 0, mode ubah kalau tidak
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string kode = mtbKode.Text.Trim().ToUpper();
            DateTime tanggal = dtpTanggal.Value.Date;

            // Kumpulkan semua kesalahan dulu, supaya tampil bersamaan
            List<string> daftarError = new List<string>();

            // ===== Kode penerbangan =====
            bool kodeFormatBenar = false;
            if (mtbKode.MaskCompleted == false || kode.Length != 7)
            {
                daftarError.Add("Kode penerbangan wajib diisi dengan format dua huruf, strip, empat digit angka (contoh: ID-7518).");
            }
            else
            {
                kodeFormatBenar =
                    char.IsLetter(kode[0]) && char.IsLetter(kode[1]) && kode[2] == '-' &&
                    char.IsDigit(kode[3]) && char.IsDigit(kode[4]) &&
                    char.IsDigit(kode[5]) && char.IsDigit(kode[6]);

                if (kodeFormatBenar == false)
                {
                    daftarError.Add("Kode penerbangan harus berupa dua huruf, strip, empat digit angka (contoh: ID-7518).");
                }
            }

            // Kode tidak boleh dipakai dua kali untuk tanggal yang sama
            if (kodeFormatBenar)
            {
                for (int i = 0; i < DataDummy.daftarJadwalPenerbangan.Count; i++)
                {
                    JadwalPenerbangan j = DataDummy.daftarJadwalPenerbangan[i];
                    if (j.Id != idSedangDiubah &&
                        j.KodePenerbangan == kode &&
                        j.TanggalKeberangkatan.Date == tanggal)
                    {
                        daftarError.Add("Kode penerbangan \"" + kode + "\" sudah dipakai pada tanggal " +
                            tanggal.ToString("dd-MM-yyyy") + ".");
                        break;
                    }
                }
            }

            // ===== Bandara asal, tujuan, dan maskapai =====
            Bandara bandaraAsal = cmbDari.SelectedItem as Bandara;
            Bandara bandaraTujuan = cmbKe.SelectedItem as Bandara;

            if (cmbDari.SelectedItem == null)
            {
                daftarError.Add("Bandara asal harus dipilih.");
            }

            if (cmbKe.SelectedItem == null)
            {
                daftarError.Add("Bandara tujuan harus dipilih.");
            }

            if (cmbMaskapai.SelectedItem == null)
            {
                daftarError.Add("Maskapai harus dipilih.");
            }

            if (bandaraAsal != null && bandaraTujuan != null && bandaraAsal.ID == bandaraTujuan.ID)
            {
                daftarError.Add("Bandara asal dan bandara tujuan tidak boleh sama.");
            }

            // ===== Waktu keberangkatan =====
            int jam, menit;
            bool waktuValid = AmbilWaktu(out jam, out menit);
            if (waktuValid == false)
            {
                daftarError.Add("Waktu keberangkatan wajib diisi dengan format jam dan menit (contoh: 19:55).");
            }
            else if (jam < 0 || jam > 23 || menit < 0 || menit > 59)
            {
                waktuValid = false;
                daftarError.Add("Waktu keberangkatan harus antara 00:00 sampai 23:59.");
            }

            // ===== Durasi penerbangan =====
            int jamDurasi, menitDurasi;
            bool durasiValid = AmbilDurasi(out jamDurasi, out menitDurasi);
            if (durasiValid == false)
            {
                daftarError.Add("Durasi penerbangan wajib diisi (contoh: 01 jam 10 menit).");
            }
            else if (menitDurasi < 0 || menitDurasi > 59 || (jamDurasi == 0 && menitDurasi == 0))
            {
                durasiValid = false;
                daftarError.Add("Durasi penerbangan tidak boleh 0 dan menit harus antara 00 sampai 59.");
            }

            // ===== Waktu tiba harus masih hari yang sama =====
            if (waktuValid && durasiValid)
            {
                int totalKeberangkatan = jam * 60 + menit;
                int totalDurasi = jamDurasi * 60 + menitDurasi;
                if (totalKeberangkatan + totalDurasi > 23 * 60 + 59)
                {
                    daftarError.Add("Waktu tiba melewati tengah malam. " +
                        "Penerbangan harus tiba di hari yang sama dengan keberangkatan.");
                }
            }

            // ===== Harga per tiket =====
            if (nudHarga.Value < 1)
            {
                daftarError.Add("Harga per tiket minimal 1.");
            }

            // Kalau ada kesalahan, tampilkan semuanya lalu berhenti
            if (daftarError.Count > 0)
            {
                MessageBox.Show(
                    "Data belum bisa disimpan:\n\n- " + string.Join("\n- ", daftarError),
                    "Master Jadwal Penerbangan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Gabungkan tanggal dengan jam keberangkatan
            DateTime waktuKeberangkatan = tanggal + new TimeSpan(jam, menit, 0);

            if (idSedangDiubah == 0)
            {
                // ===== Mode tambah =====
                JadwalPenerbangan baru = new JadwalPenerbangan();
                baru.Id = DataDummy.IdBerikutnyaJadwal();
                baru.KodePenerbangan = kode;
                baru.BandaraAsalId = bandaraAsal.ID;
                baru.BandaraTujuanId = bandaraTujuan.ID;
                baru.MaskapaiId = ((Maskapai)cmbMaskapai.SelectedItem).Id;
                baru.TanggalKeberangkatan = waktuKeberangkatan;
                baru.DurasiMenit = jamDurasi * 60 + menitDurasi;
                baru.HargaPerTiket = Convert.ToInt32(nudHarga.Value);
                DataDummy.daftarJadwalPenerbangan.Add(baru);

                MessageBox.Show("Jadwal penerbangan berhasil disimpan.", "Master Jadwal Penerbangan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ===== Mode ubah =====
                JadwalPenerbangan jadwal = CariJadwal(idSedangDiubah);
                if (jadwal != null)
                {
                    jadwal.KodePenerbangan = kode;
                    jadwal.BandaraAsalId = bandaraAsal.ID;
                    jadwal.BandaraTujuanId = bandaraTujuan.ID;
                    jadwal.MaskapaiId = ((Maskapai)cmbMaskapai.SelectedItem).Id;
                    jadwal.TanggalKeberangkatan = waktuKeberangkatan;
                    jadwal.DurasiMenit = jamDurasi * 60 + menitDurasi;
                    jadwal.HargaPerTiket = Convert.ToInt32(nudHarga.Value);
                }

                MessageBox.Show("Perubahan jadwal penerbangan berhasil disimpan.", "Master Jadwal Penerbangan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Segarkan grid lalu kosongkan input
            MuatGrid();
            KosongkanInput();
        }

        // Menghapus jadwal (dari tombol Hapus di grid)
        private void HapusJadwal(int id)
        {
            JadwalPenerbangan jadwal = CariJadwal(id);
            if (jadwal == null)
            {
                return;
            }

            // Jadwal tidak boleh dihapus kalau masih punya data perubahan status
            for (int i = 0; i < DataDummy.daftarPerubahanStatus.Count; i++)
            {
                if (DataDummy.daftarPerubahanStatus[i].JadwalPenerbanganId == id)
                {
                    MessageBox.Show(
                        "Jadwal \"" + jadwal.KodePenerbangan + "\" tidak bisa dihapus karena masih " +
                        "memiliki data perubahan status.",
                        "Master Jadwal Penerbangan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // Jadwal tidak boleh dihapus kalau masih punya data transaksi
            for (int i = 0; i < DataDummy.daftarTransaksi.Count; i++)
            {
                if (DataDummy.daftarTransaksi[i].JadwalPenerbanganId == id)
                {
                    MessageBox.Show(
                        "Jadwal \"" + jadwal.KodePenerbangan + "\" tidak bisa dihapus karena masih " +
                        "memiliki data transaksi.",
                        "Master Jadwal Penerbangan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult jawab = MessageBox.Show(
                "Yakin ingin menghapus jadwal \"" + jadwal.KodePenerbangan + "\"?",
                "Master Jadwal Penerbangan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                DataDummy.daftarJadwalPenerbangan.Remove(jadwal);
                MuatGrid();

                // Kalau yang dihapus sedang dalam mode ubah, kembali ke mode tambah
                if (idSedangDiubah == id)
                {
                    KosongkanInput();
                }

                MessageBox.Show("Jadwal penerbangan berhasil dihapus.", "Master Jadwal Penerbangan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tombol Batal: kosongkan semua input dan kembali ke mode tambah
        private void btnBatal_Click(object sender, EventArgs e)
        {
            KosongkanInput();
        }

        // Mengosongkan kolom input dan mengembalikan Simpan ke mode tambah
        private void KosongkanInput()
        {
            idSedangDiubah = 0;
            mtbKode.Clear();
            if (cmbDari.Items.Count > 0)
            {
                cmbDari.SelectedIndex = 0;
            }
            if (cmbKe.Items.Count > 0)
            {
                cmbKe.SelectedIndex = 0;
            }
            if (cmbMaskapai.Items.Count > 0)
            {
                cmbMaskapai.SelectedIndex = 0;
            }
            dtpTanggal.Value = DateTime.Today;
            mtbWaktu.Text = "00:00";
            mtbDurasi.Clear();
            nudHarga.Value = 1;
        }
    }
}
