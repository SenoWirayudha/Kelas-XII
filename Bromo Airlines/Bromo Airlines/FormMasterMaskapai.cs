using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Master Maskapai: menampilkan, menambah, mengubah, dan menghapus maskapai.
    // Data masih disimpan di DataDummy (di memori).
    public partial class FormMasterMaskapai : Form
    {
        // ID maskapai yang sedang diubah. Kalau 0 = mode tambah biasa.
        private int idSedangDiubah = 0;

        // Penanda: apakah form ini ditutup lewat tombol Logout.
        private bool logoutBerhasil = false;

        // Warna latar item menu saat kursor masuk (sangat muda)
        private Color warnaHover = Color.FromArgb(245, 245, 245);

        public FormMasterMaskapai()
        {
            InitializeComponent();

            // Tampilkan data maskapai di grid
            MuatGrid();

            // Sidebar mengikuti status terakhir (melebar / mengecil)
            TerapkanUkuranMenu();
        }

        // Klik salah satu item menu
        private void Item_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);

            // Menu halaman ini: tidak melakukan apa-apa
            if (index == 1)
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
            if (index == 2) tujuan = new FormMasterJadwal();
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

        // Mengurutkan daftar maskapai berdasarkan nama A-Z (tidak peka huruf besar/kecil)
        private List<Maskapai> MaskapaiUrut()
        {
            List<Maskapai> hasil = new List<Maskapai>(DataDummy.daftarMaskapai);
            hasil.Sort(delegate (Maskapai a, Maskapai b)
            {
                return string.Compare(a.Nama, b.Nama, StringComparison.OrdinalIgnoreCase);
            });
            return hasil;
        }

        // Mengisi ulang grid dari data dummy
        private void MuatGrid()
        {
            dgvMaskapai.Rows.Clear();

            List<Maskapai> daftar = MaskapaiUrut();
            for (int i = 0; i < daftar.Count; i++)
            {
                Maskapai maskapai = daftar[i];
                dgvMaskapai.Rows.Add(
                    maskapai.Nama,
                    maskapai.Perusahaan,
                    maskapai.JumlahKru,
                    maskapai.Deskripsi);

                // Simpan ID maskapai di baris, supaya tahu baris mana yang diklik
                dgvMaskapai.Rows[i].Tag = maskapai.Id;
            }
        }

        // Mencari data maskapai berdasarkan ID. Kalau tidak ketemu = null.
        private Maskapai CariMaskapai(int id)
        {
            for (int i = 0; i < DataDummy.daftarMaskapai.Count; i++)
            {
                if (DataDummy.daftarMaskapai[i].Id == id)
                {
                    return DataDummy.daftarMaskapai[i];
                }
            }
            return null;
        }

        // Klik tombol Ubah atau Hapus di grid
        private void dgvMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header kolom
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = Convert.ToInt32(dgvMaskapai.Rows[e.RowIndex].Tag);

            if (e.ColumnIndex == dgvMaskapai.Columns["kolomUbah"].Index)
            {
                MuatKeInput(id);
            }
            else if (e.ColumnIndex == dgvMaskapai.Columns["kolomHapus"].Index)
            {
                HapusMaskapai(id);
            }
        }

        // Memuat data maskapai ke kolom input (masuk mode ubah)
        private void MuatKeInput(int id)
        {
            Maskapai maskapai = CariMaskapai(id);
            if (maskapai == null)
            {
                return;
            }

            idSedangDiubah = id;
            txtNama.Text = maskapai.Nama;
            txtPerusahaan.Text = maskapai.Perusahaan;
            nudJumlahKru.Value = maskapai.JumlahKru;
            txtDeskripsi.Text = maskapai.Deskripsi;
        }

        // Tombol Simpan: mode tambah kalau idSedangDiubah = 0, mode ubah kalau tidak
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input
            string nama = txtNama.Text.Trim();
            string perusahaan = txtPerusahaan.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();

            // Kumpulkan semua kesalahan dulu, supaya tampil bersamaan
            List<string> daftarError = new List<string>();

            if (nama == "")
            {
                daftarError.Add("Nama maskapai wajib diisi.");
            }

            if (perusahaan == "")
            {
                daftarError.Add("Perusahaan wajib diisi.");
            }

            if (nudJumlahKru.Value < 1)
            {
                daftarError.Add("Jumlah kru minimal 1.");
            }

            if (deskripsi == "")
            {
                daftarError.Add("Deskripsi wajib diisi.");
            }

            // Nama harus unik (maskapai lain saja, tidak menghitung dirinya sendiri)
            if (nama != "")
            {
                for (int i = 0; i < DataDummy.daftarMaskapai.Count; i++)
                {
                    Maskapai m = DataDummy.daftarMaskapai[i];
                    if (m.Id != idSedangDiubah &&
                        string.Equals(m.Nama.Trim(), nama, StringComparison.OrdinalIgnoreCase))
                    {
                        daftarError.Add("Nama maskapai \"" + nama + "\" sudah dipakai maskapai lain.");
                        break;
                    }
                }
            }

            // Kalau ada kesalahan, tampilkan semuanya lalu berhenti
            if (daftarError.Count > 0)
            {
                MessageBox.Show(
                    "Data belum bisa disimpan:\n\n- " + string.Join("\n- ", daftarError),
                    "Master Maskapai",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idSedangDiubah == 0)
            {
                // ===== Mode tambah =====
                Maskapai baru = new Maskapai();
                baru.Id = DataDummy.IdBerikutnyaMaskapai();
                baru.Nama = nama;
                baru.Perusahaan = perusahaan;
                baru.JumlahKru = Convert.ToInt32(nudJumlahKru.Value);
                baru.Deskripsi = deskripsi;
                DataDummy.daftarMaskapai.Add(baru);

                MessageBox.Show("Maskapai berhasil disimpan.", "Master Maskapai",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ===== Mode ubah =====
                Maskapai maskapai = CariMaskapai(idSedangDiubah);
                if (maskapai != null)
                {
                    maskapai.Nama = nama;
                    maskapai.Perusahaan = perusahaan;
                    maskapai.JumlahKru = Convert.ToInt32(nudJumlahKru.Value);
                    maskapai.Deskripsi = deskripsi;
                }

                MessageBox.Show("Perubahan maskapai berhasil disimpan.", "Master Maskapai",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Segarkan grid lalu kosongkan input
            MuatGrid();
            KosongkanInput();
        }

        // Menghapus maskapai (dari tombol Hapus di grid)
        private void HapusMaskapai(int id)
        {
            Maskapai maskapai = CariMaskapai(id);
            if (maskapai == null)
            {
                return;
            }

            // Maskapai tidak boleh dihapus kalau masih dipakai jadwal penerbangan
            for (int i = 0; i < DataDummy.daftarJadwalPenerbangan.Count; i++)
            {
                JadwalPenerbangan jadwal = DataDummy.daftarJadwalPenerbangan[i];
                if (jadwal.MaskapaiId == id)
                {
                    MessageBox.Show(
                        "Maskapai \"" + maskapai.Nama + "\" tidak bisa dihapus karena masih dipakai " +
                        "oleh jadwal penerbangan " + jadwal.KodePenerbangan + ".",
                        "Master Maskapai",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult jawab = MessageBox.Show(
                "Yakin ingin menghapus maskapai \"" + maskapai.Nama + "\"?",
                "Master Maskapai",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                DataDummy.daftarMaskapai.Remove(maskapai);
                MuatGrid();

                // Kalau yang dihapus sedang dalam mode ubah, kembali ke mode tambah
                if (idSedangDiubah == id)
                {
                    KosongkanInput();
                }

                MessageBox.Show("Maskapai berhasil dihapus.", "Master Maskapai",
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
            txtNama.Text = "";
            txtPerusahaan.Text = "";
            nudJumlahKru.Value = 1;
            txtDeskripsi.Text = "";
        }
    }
}
