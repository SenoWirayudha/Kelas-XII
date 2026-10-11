using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form Master Kode Promo: menampilkan, menambah, mengubah,
    // dan menghapus kode promo.
    // Data masih disimpan di DataDummy (di memori).
    public partial class FormMasterKodePromo : Form
    {
        // ID kode promo yang sedang diubah. Kalau 0 = mode tambah biasa.
        private int idSedangDiubah = 0;

        public FormMasterKodePromo()
        {
            InitializeComponent();

            // Ikon jendela memakai logo Bromo Airlines (kalau file-nya ada)
            Image logo = GambarLogo.Muat();
            if (logo is Bitmap)
            {
                this.Icon = Icon.FromHandle(((Bitmap)logo).GetHicon());
            }

            // Tampilkan data kode promo di grid
            MuatGrid();
        }

        // Mengurutkan daftar kode promo berdasarkan kode A-Z (tidak peka huruf besar/kecil)
        private List<KodePromo> KodePromoUrut()
        {
            List<KodePromo> hasil = new List<KodePromo>(DataDummy.daftarKodePromo);
            hasil.Sort(delegate (KodePromo a, KodePromo b)
            {
                return string.Compare(a.Kode, b.Kode, StringComparison.OrdinalIgnoreCase);
            });
            return hasil;
        }

        // Mengisi ulang grid dari data dummy
        private void MuatGrid()
        {
            dgvKodePromo.Rows.Clear();

            List<KodePromo> daftar = KodePromoUrut();
            for (int i = 0; i < daftar.Count; i++)
            {
                KodePromo promo = daftar[i];
                dgvKodePromo.Rows.Add(
                    promo.Kode,
                    promo.PersentaseDiskon,
                    promo.MaksimumDiskon,
                    promo.BerlakuSampai.ToString("dd-MM-yyyy"),
                    promo.Deskripsi);

                // Simpan ID kode promo di baris, supaya tahu baris mana yang diklik
                dgvKodePromo.Rows[i].Tag = promo.Id;
            }
        }

        // Mencari data kode promo berdasarkan ID. Kalau tidak ketemu = null.
        private KodePromo CariKodePromo(int id)
        {
            for (int i = 0; i < DataDummy.daftarKodePromo.Count; i++)
            {
                if (DataDummy.daftarKodePromo[i].Id == id)
                {
                    return DataDummy.daftarKodePromo[i];
                }
            }
            return null;
        }

        // Klik tombol Ubah atau Hapus di grid
        private void dgvKodePromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header kolom
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = Convert.ToInt32(dgvKodePromo.Rows[e.RowIndex].Tag);

            if (e.ColumnIndex == dgvKodePromo.Columns["kolomUbah"].Index)
            {
                MuatKeInput(id);
            }
            else if (e.ColumnIndex == dgvKodePromo.Columns["kolomHapus"].Index)
            {
                HapusKodePromo(id);
            }
        }

        // Memuat data kode promo ke kolom input (masuk mode ubah)
        private void MuatKeInput(int id)
        {
            KodePromo promo = CariKodePromo(id);
            if (promo == null)
            {
                return;
            }

            idSedangDiubah = id;
            txtKode.Text = promo.Kode;
            dtpBerlakuSampai.Value = promo.BerlakuSampai;
            nudPersentase.Value = promo.PersentaseDiskon;
            nudMaksimum.Value = promo.MaksimumDiskon;
            txtDeskripsi.Text = promo.Deskripsi;
        }

        // Tombol Simpan: mode tambah kalau idSedangDiubah = 0, mode ubah kalau tidak
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari kolom input (kode tidak diubah otomatis menjadi kapital)
            string kode = txtKode.Text.Trim();
            string deskripsi = txtDeskripsi.Text.Trim();
            DateTime berlakuSampai = dtpBerlakuSampai.Value.Date;

            // Kumpulkan semua kesalahan dulu, supaya tampil bersamaan
            List<string> daftarError = new List<string>();

            // ===== Kode promo =====
            if (kode == "")
            {
                daftarError.Add("Kode promo wajib diisi.");
            }
            else
            {
                // Harus huruf kapital semua (tidak diubah otomatis, harus ditolak)
                if (kode != kode.ToUpper())
                {
                    daftarError.Add("Kode promo harus huruf kapital semua.");
                }

                // Tidak boleh mengandung spasi
                if (kode.Contains(" "))
                {
                    daftarError.Add("Kode promo tidak boleh mengandung spasi.");
                }

                // Hanya boleh berisi huruf dan angka
                bool adaKarakterSalah = false;
                for (int i = 0; i < kode.Length; i++)
                {
                    if (char.IsLetterOrDigit(kode[i]) == false)
                    {
                        adaKarakterSalah = true;
                        break;
                    }
                }
                if (adaKarakterSalah)
                {
                    daftarError.Add("Kode promo hanya boleh berisi huruf dan angka.");
                }

                // Harus unik (kode promo lain saja, tidak menghitung dirinya sendiri)
                for (int i = 0; i < DataDummy.daftarKodePromo.Count; i++)
                {
                    KodePromo p = DataDummy.daftarKodePromo[i];
                    if (p.Id != idSedangDiubah &&
                        string.Equals(p.Kode, kode, StringComparison.OrdinalIgnoreCase))
                    {
                        daftarError.Add("Kode promo \"" + kode + "\" sudah dipakai kode promo lain.");
                        break;
                    }
                }
            }

            // ===== Berlaku Sampai =====
            // Saat menambah: tidak boleh sebelum hari ini.
            // Saat mengubah: aturan itu hanya berlaku kalau tanggalnya diubah,
            // supaya kode promo lama yang sudah kedaluwarsa tetap bisa diubah.
            if (idSedangDiubah == 0)
            {
                if (berlakuSampai < DateTime.Today)
                {
                    daftarError.Add("Tanggal Berlaku Sampai tidak boleh sebelum hari ini.");
                }
            }
            else
            {
                KodePromo sedang = CariKodePromo(idSedangDiubah);
                if (sedang != null &&
                    berlakuSampai != sedang.BerlakuSampai.Date &&
                    berlakuSampai < DateTime.Today)
                {
                    daftarError.Add("Tanggal Berlaku Sampai tidak boleh sebelum hari ini.");
                }
            }

            // ===== Persentase diskon =====
            if (nudPersentase.Value < 1)
            {
                daftarError.Add("Persentase diskon minimal 1.");
            }

            if (nudPersentase.Value > 100)
            {
                daftarError.Add("Persentase diskon maksimal 100.");
            }

            // ===== Maksimum diskon =====
            if (nudMaksimum.Value < 1)
            {
                daftarError.Add("Maksimum diskon minimal 1.");
            }

            // ===== Deskripsi =====
            if (deskripsi == "")
            {
                daftarError.Add("Deskripsi wajib diisi.");
            }

            // Kalau ada kesalahan, tampilkan semuanya lalu berhenti
            if (daftarError.Count > 0)
            {
                MessageBox.Show(
                    "Data belum bisa disimpan:\n\n- " + string.Join("\n- ", daftarError),
                    "Master Kode Promo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (idSedangDiubah == 0)
            {
                // ===== Mode tambah =====
                KodePromo baru = new KodePromo();
                baru.Id = DataDummy.IdBerikutnyaKodePromo();
                baru.Kode = kode;
                baru.PersentaseDiskon = Convert.ToInt32(nudPersentase.Value);
                baru.MaksimumDiskon = Convert.ToInt32(nudMaksimum.Value);
                baru.BerlakuSampai = berlakuSampai;
                baru.Deskripsi = deskripsi;
                DataDummy.daftarKodePromo.Add(baru);

                MessageBox.Show("Kode promo berhasil disimpan.", "Master Kode Promo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ===== Mode ubah =====
                KodePromo promo = CariKodePromo(idSedangDiubah);
                if (promo != null)
                {
                    promo.Kode = kode;
                    promo.PersentaseDiskon = Convert.ToInt32(nudPersentase.Value);
                    promo.MaksimumDiskon = Convert.ToInt32(nudMaksimum.Value);
                    promo.BerlakuSampai = berlakuSampai;
                    promo.Deskripsi = deskripsi;
                }

                MessageBox.Show("Perubahan kode promo berhasil disimpan.", "Master Kode Promo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Segarkan grid lalu kosongkan input
            MuatGrid();
            KosongkanInput();
        }

        // Menghapus kode promo (dari tombol Hapus di grid)
        private void HapusKodePromo(int id)
        {
            KodePromo promo = CariKodePromo(id);
            if (promo == null)
            {
                return;
            }

            // Kode promo tidak boleh dihapus kalau masih dipakai di data transaksi
            for (int i = 0; i < DataDummy.daftarTransaksi.Count; i++)
            {
                if (DataDummy.daftarTransaksi[i].KodePromoId == id)
                {
                    MessageBox.Show(
                        "Kode promo \"" + promo.Kode + "\" tidak bisa dihapus karena masih " +
                        "dipakai di data transaksi.",
                        "Master Kode Promo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            DialogResult jawab = MessageBox.Show(
                "Yakin ingin menghapus kode promo \"" + promo.Kode + "\"?",
                "Master Kode Promo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                DataDummy.daftarKodePromo.Remove(promo);
                MuatGrid();

                // Kalau yang dihapus sedang dalam mode ubah, kembali ke mode tambah
                if (idSedangDiubah == id)
                {
                    KosongkanInput();
                }

                MessageBox.Show("Kode promo berhasil dihapus.", "Master Kode Promo",
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
            txtKode.Text = "";
            dtpBerlakuSampai.Value = DateTime.Today;
            nudPersentase.Value = 1;
            nudMaksimum.Value = 1;
            txtDeskripsi.Text = "";
        }
    }
}
