using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Master Bandara: menampilkan, menambah, mengubah, dan menghapus bandara.
    // Data masih disimpan di DataDummy (di memori).
    public partial class FormMasterBandara : Form
    {
        // ID bandara yang sedang diubah. Kalau 0 = mode tambah biasa.
        private int idSedangDiubah = 0;

        // Penanda: apakah form ini ditutup lewat tombol Logout.
        private bool logoutBerhasil = false;

        // Warna latar item menu saat kursor masuk (sangat muda)
        private Color warnaHover = Color.FromArgb(245, 245, 245);

        public FormMasterBandara()
        {
            InitializeComponent();

            // Isi ComboBox Negara urut A-Z
            List<Negara> negaraUrut = new List<Negara>(DataDummy.daftarNegara);
            negaraUrut.Sort(delegate (Negara a, Negara b)
            {
                return string.Compare(a.Nama, b.Nama, StringComparison.OrdinalIgnoreCase);
            });
            cmbNegara.DataSource = negaraUrut;
            cmbNegara.DisplayMember = "Nama";
            cmbNegara.ValueMember = "Id";

            // Tampilkan data bandara di grid
            MuatGrid();

            // Sidebar mengikuti status terakhir (melebar / mengecil)
            TerapkanUkuranMenu();
        }

        // Klik salah satu item menu
        private void Item_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);

            // Menu halaman ini: tidak melakukan apa-apa
            if (index == 0)
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
            if (index == 1) tujuan = new FormMasterMaskapai();
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

        // Mengisi ulang grid dari data dummy
        private void MuatGrid()
        {
            dgvBandara.Rows.Clear();

            List<Bandara> daftar = BandaraUrut();
            for (int i = 0; i < daftar.Count; i++)
            {
                Bandara bandara = daftar[i];
                dgvBandara.Rows.Add(
                    bandara.Nama,
                    bandara.KodeIATA,
                    bandara.Kota,
                    NamaNegara(bandara.NegaraId),
                    bandara.JumlahTerminal,
                    bandara.Alamat);

                // Simpan ID bandara di baris, supaya tahu baris mana yang diklik
                dgvBandara.Rows[i].Tag = bandara.ID;
            }
        }

        // Mencari nama negara berdasarkan ID
        private string NamaNegara(int negaraId)
        {
            for (int i = 0; i < DataDummy.daftarNegara.Count; i++)
            {
                if (DataDummy.daftarNegara[i].Id == negaraId)
                {
                    return DataDummy.daftarNegara[i].Nama;
                }
            }
            return "";
        }

        // Mencari data bandara berdasarkan ID. Kalau tidak ketemu = null.
        private Bandara CariBandara(int id)
        {
            for (int i = 0; i < DataDummy.daftarBandara.Count; i++)
            {
                if (DataDummy.daftarBandara[i].ID == id)
                {
                    return DataDummy.daftarBandara[i];
                }
            }
            return null;
        }

        // Mengecek apakah sebuah string hanya berisi huruf A-Z
        private bool HanyaHuruf(string teks)
        {
            for (int i = 0; i < teks.Length; i++)
            {
                if (teks[i] < 'A' || teks[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        // Klik tombol Ubah atau Hapus di grid
        private void dgvBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header kolom
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = Convert.ToInt32(dgvBandara.Rows[e.RowIndex].Tag);

            if (e.ColumnIndex == dgvBandara.Columns["kolomUbah"].Index)
            {
                MuatKeInput(id);
            }
            else if (e.ColumnIndex == dgvBandara.Columns["kolomHapus"].Index)
            {
                HapusBandara(id);
            }
        }

        // Memuat data bandara ke kolom input (masuk mode ubah)
        private void MuatKeInput(int id)
        {
            Bandara bandara = CariBandara(id);
            if (bandara == null)
            {
                return;
            }

            idSedangDiubah = id;
            txtNama.Text = bandara.Nama;
            txtKodeIATA.Text = bandara.KodeIATA;
            txtKota.Text = bandara.Kota;
            cmbNegara.SelectedValue = bandara.NegaraId;
            nudJumlahTerminal.Value = bandara.JumlahTerminal;
            txtAlamat.Text = bandara.Alamat;
        }

        // Tombol Simpan: mode tambah kalau idSedangDiubah = 0, mode ubah kalau tidak
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input
            string nama = txtNama.Text.Trim();
            string kodeIata = txtKodeIATA.Text.Trim().ToUpper();
            string kota = txtKota.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            Negara negaraDipilih = cmbNegara.SelectedItem as Negara;

            // Kumpulkan semua kesalahan dulu, supaya tampil bersamaan
            List<string> daftarError = new List<string>();

            if (nama == "")
            {
                daftarError.Add("Nama bandara wajib diisi.");
            }

            // Kode IATA harus tepat 3 huruf A-Z
            if (kodeIata == "")
            {
                daftarError.Add("Kode IATA wajib diisi.");
            }
            else if (kodeIata.Length != 3 || HanyaHuruf(kodeIata) == false)
            {
                daftarError.Add("Kode IATA harus tepat 3 huruf (A-Z), tidak boleh angka atau simbol.");
            }

            if (kota == "")
            {
                daftarError.Add("Kota wajib diisi.");
            }

            if (negaraDipilih == null)
            {
                daftarError.Add("Negara harus dipilih.");
            }

            if (nudJumlahTerminal.Value < 1)
            {
                daftarError.Add("Jumlah terminal minimal 1.");
            }

            if (alamat == "")
            {
                daftarError.Add("Alamat wajib diisi.");
            }

            // Nama harus unik (bandara lain saja, tidak menghitung dirinya sendiri)
            if (nama != "")
            {
                for (int i = 0; i < DataDummy.daftarBandara.Count; i++)
                {
                    Bandara b = DataDummy.daftarBandara[i];
                    if (b.ID != idSedangDiubah &&
                        string.Equals(b.Nama.Trim(), nama, StringComparison.OrdinalIgnoreCase))
                    {
                        daftarError.Add("Nama bandara \"" + nama + "\" sudah dipakai bandara lain.");
                        break;
                    }
                }
            }

            // Kode IATA harus unik (bandara lain saja)
            if (kodeIata.Length == 3 && HanyaHuruf(kodeIata))
            {
                for (int i = 0; i < DataDummy.daftarBandara.Count; i++)
                {
                    Bandara b = DataDummy.daftarBandara[i];
                    if (b.ID != idSedangDiubah && b.KodeIATA == kodeIata)
                    {
                        daftarError.Add("Kode IATA \"" + kodeIata + "\" sudah dipakai bandara lain.");
                        break;
                    }
                }
            }

            // Kalau ada kesalahan, tampilkan semuanya lalu berhenti
            if (daftarError.Count > 0)
            {
                MessageBox.Show(
                    "Data belum bisa disimpan:\n\n- " + string.Join("\n- ", daftarError),
                    "Master Bandara",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idSedangDiubah == 0)
            {
                // ===== Mode tambah =====
                Bandara baru = new Bandara();
                baru.ID = DataDummy.IdBerikutnyaBandara();
                baru.Nama = nama;
                baru.KodeIATA = kodeIata;
                baru.Kota = kota;
                baru.NegaraId = negaraDipilih.Id;
                baru.JumlahTerminal = Convert.ToInt32(nudJumlahTerminal.Value);
                baru.Alamat = alamat;
                DataDummy.daftarBandara.Add(baru);

                MessageBox.Show("Bandara berhasil disimpan.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ===== Mode ubah =====
                Bandara bandara = CariBandara(idSedangDiubah);
                if (bandara != null)
                {
                    bandara.Nama = nama;
                    bandara.KodeIATA = kodeIata;
                    bandara.Kota = kota;
                    bandara.NegaraId = negaraDipilih.Id;
                    bandara.JumlahTerminal = Convert.ToInt32(nudJumlahTerminal.Value);
                    bandara.Alamat = alamat;
                }

                MessageBox.Show("Perubahan bandara berhasil disimpan.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Segarkan grid lalu kosongkan input
            MuatGrid();
            KosongkanInput();
        }

        // Menghapus bandara (dari tombol Hapus di grid)
        private void HapusBandara(int id)
        {
            Bandara bandara = CariBandara(id);
            if (bandara == null)
            {
                return;
            }

            // Bandara tidak boleh dihapus kalau masih dipakai jadwal penerbangan
            for (int i = 0; i < DataDummy.daftarJadwalPenerbangan.Count; i++)
            {
                JadwalPenerbangan jadwal = DataDummy.daftarJadwalPenerbangan[i];
                if (jadwal.BandaraAsalId == id || jadwal.BandaraTujuanId == id)
                {
                    MessageBox.Show(
                        "Bandara \"" + bandara.Nama + "\" tidak bisa dihapus karena masih dipakai " +
                        "oleh jadwal penerbangan " + jadwal.KodePenerbangan + ".",
                        "Master Bandara",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult jawab = MessageBox.Show(
                "Yakin ingin menghapus bandara \"" + bandara.Nama + "\"?",
                "Master Bandara",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                DataDummy.daftarBandara.Remove(bandara);
                MuatGrid();

                // Kalau yang dihapus sedang dalam mode ubah, kembali ke mode tambah
                if (idSedangDiubah == id)
                {
                    KosongkanInput();
                }

                MessageBox.Show("Bandara berhasil dihapus.", "Master Bandara",
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
            txtKodeIATA.Text = "";
            txtKota.Text = "";
            txtAlamat.Text = "";
            nudJumlahTerminal.Value = 1;

            // Negara kembali ke pilihan pertama
            if (cmbNegara.Items.Count > 0)
            {
                cmbNegara.SelectedIndex = 0;
            }
        }
    }
}
