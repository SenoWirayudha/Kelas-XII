using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Master Bandara: menampilkan, menambah, mengubah, dan menghapus bandara.
    // Data diambil dari database SQL Server lewat Entity Framework.
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

            // Isi ComboBox Negara dari database (urut A-Z)
            IsiComboNegara();

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

        // ====== DATA (Entity Framework) ======

        // Mengisi ComboBox Negara dari tabel Negara, urut A-Z
        private void IsiComboNegara()
        {
            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    List<Models.Negara> daftarNegara = db.Negara.OrderBy(n => n.Nama).ToList();
                    cmbNegara.DataSource = daftarNegara;
                    cmbNegara.DisplayMember = "Nama";
                    cmbNegara.ValueMember = "ID";
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mengisi ulang grid dari tabel Bandara (urut Nama A-Z)
        private void MuatGrid()
        {
            dgvBandara.Rows.Clear();

            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    List<Models.Bandara> daftar = db.Bandara.OrderBy(b => b.Nama).ToList();

                    for (int i = 0; i < daftar.Count; i++)
                    {
                        Models.Bandara bandara = daftar[i];
                        dgvBandara.Rows.Add(
                            bandara.Nama,
                            bandara.KodeIATA,
                            bandara.Kota,
                            bandara.Negara.Nama,
                            bandara.JumlahTerminal,
                            bandara.Alamat);

                        // Simpan ID bandara di baris, supaya tahu baris mana yang diklik
                        dgvBandara.Rows[i].Tag = bandara.ID;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    Models.Bandara bandara = db.Bandara.FirstOrDefault(b => b.ID == id);
                    if (bandara == null)
                    {
                        return;
                    }

                    idSedangDiubah = id;
                    txtNama.Text = bandara.Nama;
                    txtKodeIATA.Text = bandara.KodeIATA;
                    txtKota.Text = bandara.Kota;
                    cmbNegara.SelectedValue = bandara.NegaraID;
                    nudJumlahTerminal.Value = bandara.JumlahTerminal;
                    txtAlamat.Text = bandara.Alamat;

                    // Teks tombol menandai sedang mode ubah
                    btnSimpan.Text = "Simpan Perubahan";
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tombol Simpan: mode tambah kalau idSedangDiubah = 0, mode ubah kalau tidak
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input
            string nama = txtNama.Text.Trim();
            string kodeIata = txtKodeIATA.Text.Trim().ToUpper();
            string kota = txtKota.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            Models.Negara negaraDipilih = cmbNegara.SelectedItem as Models.Negara;

            // Validasi dicek berurutan.
            // Berhenti di error pertama dan tampilkan satu pesan saja.

            // 1. Semua input wajib diisi
            if (nama == "")
            {
                MessageBox.Show("Nama bandara wajib diisi.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (kodeIata == "")
            {
                MessageBox.Show("Kode IATA wajib diisi.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKodeIATA.Focus();
                return;
            }

            if (kota == "")
            {
                MessageBox.Show("Kota wajib diisi.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKota.Focus();
                return;
            }

            if (negaraDipilih == null)
            {
                MessageBox.Show("Negara harus dipilih.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNegara.Focus();
                return;
            }

            if (alamat == "")
            {
                MessageBox.Show("Alamat wajib diisi.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlamat.Focus();
                return;
            }

            // Simpan dulu mode ubah atau tambah, sebelum idSedangDiubah direset
            bool modeUbah = (idSedangDiubah != 0);
            bool tersimpan = false;

            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    // 2. Nama harus unik (kecuali data yang sedang diubah sendiri)
                    bool namaDipakai = db.Bandara.Any(b =>
                        b.ID != idSedangDiubah && b.Nama.ToLower() == nama.ToLower());

                    if (namaDipakai)
                    {
                        MessageBox.Show("Nama bandara \"" + nama + "\" sudah dipakai bandara lain.",
                            "Master Bandara", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNama.Focus();
                        return;
                    }

                    // 3. Kode IATA harus tepat 3 huruf (A-Z)
                    if (kodeIata.Length != 3 || HanyaHuruf(kodeIata) == false)
                    {
                        MessageBox.Show("Kode IATA harus tepat 3 huruf (A-Z), tidak boleh angka atau simbol.",
                            "Master Bandara", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKodeIATA.Focus();
                        return;
                    }

                    // 4. Kode IATA harus unik (kecuali data yang sedang diubah sendiri)
                    bool kodeDipakai = db.Bandara.Any(b =>
                        b.ID != idSedangDiubah && b.KodeIATA.ToLower() == kodeIata.ToLower());

                    if (kodeDipakai)
                    {
                        MessageBox.Show("Kode IATA \"" + kodeIata + "\" sudah dipakai bandara lain.",
                            "Master Bandara", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKodeIATA.Focus();
                        return;
                    }

                    // 5. Jumlah terminal minimal 1
                    if (nudJumlahTerminal.Value < 1)
                    {
                        MessageBox.Show("Jumlah terminal minimal 1.", "Master Bandara",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nudJumlahTerminal.Focus();
                        return;
                    }

                    if (modeUbah == false)
                    {
                        // ===== Mode tambah =====
                        Models.Bandara baru = new Models.Bandara();
                        baru.Nama = nama;
                        baru.KodeIATA = kodeIata;
                        baru.Kota = kota;
                        baru.NegaraID = negaraDipilih.ID;
                        baru.JumlahTerminal = Convert.ToInt32(nudJumlahTerminal.Value);
                        baru.Alamat = alamat;

                        db.Bandara.Add(baru);
                        // Kolom ID identity, jadi terisi otomatis oleh database
                        db.SaveChanges();
                    }
                    else
                    {
                        // ===== Mode ubah =====
                        Models.Bandara bandara = db.Bandara.FirstOrDefault(b => b.ID == idSedangDiubah);
                        if (bandara == null)
                        {
                            return;
                        }

                        bandara.Nama = nama;
                        bandara.KodeIATA = kodeIata;
                        bandara.Kota = kota;
                        bandara.NegaraID = negaraDipilih.ID;
                        bandara.JumlahTerminal = Convert.ToInt32(nudJumlahTerminal.Value);
                        bandara.Alamat = alamat;

                        db.SaveChanges();
                    }

                    tersimpan = true;
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tersimpan == false)
            {
                return;
            }

            if (modeUbah)
            {
                MessageBox.Show("Perubahan bandara berhasil disimpan.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bandara berhasil disimpan.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Segarkan grid lalu kosongkan input
            MuatGrid();
            KosongkanInput();
        }

        // Menghapus bandara (dari tombol Hapus di grid)
        private void HapusBandara(int id)
        {
            try
            {
                using (Models.BandaraEntities db = new Models.BandaraEntities())
                {
                    Models.Bandara bandara = db.Bandara.FirstOrDefault(b => b.ID == id);
                    if (bandara == null)
                    {
                        return;
                    }

                    // Konfirmasi dulu, menyebut nama bandara
                    DialogResult jawab = MessageBox.Show(
                        "Yakin ingin menghapus bandara \"" + bandara.Nama + "\"?",
                        "Master Bandara",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (jawab != DialogResult.Yes)
                    {
                        return;
                    }

                    // Bandara tidak boleh dihapus kalau masih dipakai jadwal penerbangan
                    Models.JadwalPenerbangan jadwalPemakai = db.JadwalPenerbangan
                        .FirstOrDefault(j => j.BandaraKeberangkatanID == id || j.BandaraTujuanID == id);

                    if (jadwalPemakai != null)
                    {
                        MessageBox.Show(
                            "Bandara \"" + bandara.Nama + "\" tidak bisa dihapus karena masih dipakai " +
                            "oleh jadwal penerbangan " + jadwalPemakai.KodePenerbangan + ".",
                            "Master Bandara",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    db.Bandara.Remove(bandara);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Tidak dapat terhubung ke database.", "Master Bandara",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Segarkan grid; kalau yang dihapus sedang mode ubah, kembali ke mode tambah
            MuatGrid();
            if (idSedangDiubah == id)
            {
                KosongkanInput();
            }

            MessageBox.Show("Bandara berhasil dihapus.", "Master Bandara",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnSimpan.Text = "Simpan";

            // Negara kembali ke pilihan pertama
            if (cmbNegara.Items.Count > 0)
            {
                cmbNegara.SelectedIndex = 0;
            }
        }
    }
}
