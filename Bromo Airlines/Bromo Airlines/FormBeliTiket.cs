using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form pembelian tiket: data tiap penumpang dan pembayaran.
    // Menerima Id jadwal dan jumlah penumpang dari FormListPenerbangan.
    public partial class FormBeliTiket : Form
    {
        // Data yang diterima dari FormListPenerbangan
        private int idJadwal = 0;
        private int jumlahPenumpang = 1;

        // Jadwal yang sedang dibeli (diambil dari DataDummy di event Load)
        private JadwalPenerbangan jadwal;

        // Kontrol dinamis isian tiap penumpang,
        // disimpan di list supaya mudah divalidasi dan dibaca
        private List<ComboBox> daftarTitel = new List<ComboBox>();
        private List<TextBox> daftarNama = new List<TextBox>();

        // Promo yang sedang berlaku (null = tidak ada promo)
        private KodePromo promoBerlaku = null;

        // Konstruktor tanpa parameter:
        // supaya form ini tetap bisa dibuka di designer Visual Studio.
        public FormBeliTiket()
        {
            InitializeComponent();
        }

        // Konstruktor yang dipakai saat dibuka dari FormListPenerbangan
        public FormBeliTiket(int idJadwalPenerbangan, int jumlahPenumpangPenerbangan)
            : this()
        {
            idJadwal = idJadwalPenerbangan;
            jumlahPenumpang = jumlahPenumpangPenerbangan;
        }

        // Diisi saat form dibuka (bukan di InitializeComponent,
        // supaya designer tidak membaca data dummy)
        private void FormBeliTiket_Load(object sender, EventArgs e)
        {
            jadwal = CariJadwal(idJadwal);

            if (jadwal != null)
            {
                Bandara asal = CariBandara(jadwal.BandaraAsalId);
                Bandara tujuan = CariBandara(jadwal.BandaraTujuanId);
                Maskapai maskapai = CariMaskapai(jadwal.MaskapaiId);

                string teksAsal = "";
                if (asal != null)
                {
                    teksAsal = asal.Nama + " (" + asal.KodeIATA + ")";
                }

                string teksTujuan = "";
                if (tujuan != null)
                {
                    teksTujuan = tujuan.Nama + " (" + tujuan.KodeIATA + ")";
                }

                lblRute.Text = teksAsal + "  \u2192  " + teksTujuan;
                lblMaskapai.Text = maskapai != null ? maskapai.Nama : "";

                // Pengecualian format tanggal: bahasa Inggris (en-US),
                // sama seperti baris ringkasan di FormListPenerbangan
                lblTanggal.Text = jadwal.TanggalKeberangkatan.ToString(
                    "dddd, dd MMMM yyyy", new CultureInfo("en-US"));

                DateTime waktuTiba = jadwal.TanggalKeberangkatan.AddMinutes(jadwal.DurasiMenit);
                // Pakai InvariantCulture supaya pemisahnya selalu titik dua (04:30),
                // bukan pemisah jam lokal (bisa jadi titik)
                lblWaktu.Text = jadwal.TanggalKeberangkatan.ToString("HH:mm",
                        CultureInfo.InvariantCulture) + " - "
                    + waktuTiba.ToString("HH:mm", CultureInfo.InvariantCulture);
            }

            lblJumlah.Text = jumlahPenumpang + " penumpang";

            // Buat blok isian data tiap penumpang lewat kode
            BuatBlokPenumpang();

            // Total awal = harga per tiket x jumlah penumpang (tanpa promo)
            PerbaruiTotal();
        }

        // Membuat blok isian untuk tiap penumpang, ditumpuk ke bawah.
        // Kontrol dibuat HANYA di event Load, bukan di InitializeComponent.
        private void BuatBlokPenumpang()
        {
            pnlPenumpang.Controls.Clear();
            daftarTitel.Clear();
            daftarNama.Clear();

            int posisiY = 5;
            for (int i = 1; i <= jumlahPenumpang; i++)
            {
                // Judul blok: "Penumpang #1", "Penumpang #2", dst.
                Label lblNomor = new Label();
                lblNomor.AutoSize = true;
                lblNomor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lblNomor.Location = new Point(0, posisiY);
                lblNomor.Text = "Penumpang #" + i;
                pnlPenumpang.Controls.Add(lblNomor);

                // Baris Titel
                Label lblTitel = new Label();
                lblTitel.AutoSize = true;
                lblTitel.Font = new Font("Segoe UI", 9F);
                lblTitel.Location = new Point(0, posisiY + 32);
                lblTitel.Text = "Titel";
                pnlPenumpang.Controls.Add(lblTitel);

                ComboBox cmbTitel = new ComboBox();
                cmbTitel.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTitel.Font = new Font("Segoe UI", 9F);
                cmbTitel.Location = new Point(90, posisiY + 29);
                cmbTitel.Size = new Size(115, 23);
                cmbTitel.Items.Add("- Pilih Titel -");
                cmbTitel.Items.Add("Mr");
                cmbTitel.Items.Add("Mrs");
                cmbTitel.Items.Add("Ms");
                cmbTitel.SelectedIndex = 0;
                pnlPenumpang.Controls.Add(cmbTitel);

                // Baris Nama Lengkap (ikut melebar saat window membesar)
                Label lblNama = new Label();
                lblNama.AutoSize = true;
                lblNama.Font = new Font("Segoe UI", 9F);
                lblNama.Location = new Point(0, posisiY + 62);
                lblNama.Text = "Nama Lengkap";
                pnlPenumpang.Controls.Add(lblNama);

                TextBox txtNama = new TextBox();
                txtNama.Font = new Font("Segoe UI", 9F);
                txtNama.Location = new Point(90, posisiY + 59);
                txtNama.Size = new Size(415, 23);
                txtNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                pnlPenumpang.Controls.Add(txtNama);

                // Petunjuk di bawah kotak nama
                Label lblPetunjuk = new Label();
                lblPetunjuk.AutoSize = true;
                lblPetunjuk.Font = new Font("Segoe UI", 9F);
                lblPetunjuk.ForeColor = Color.FromArgb(160, 160, 160);
                lblPetunjuk.Location = new Point(90, posisiY + 86);
                lblPetunjuk.Text = "Isi sesuai KTP/Paspor/SIM (tanpa tanda baca dan gelar)";
                pnlPenumpang.Controls.Add(lblPetunjuk);

                daftarTitel.Add(cmbTitel);
                daftarNama.Add(txtNama);

                // Tinggi blok sekitar 100 px, jarak antar blok sekitar 25 px
                posisiY += 125;
            }
        }

        // Tombol Pakai: terapkan kode promo
        private void btnPakai_Click(object sender, EventArgs e)
        {
            string kode = txtKodePromo.Text.Trim();

            if (kode == "")
            {
                MessageBox.Show("Masukkan kode promo terlebih dahulu.", "Kode Promo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cari kode di DataDummy (abaikan spasi, tidak peka huruf besar/kecil)
            KodePromo promo = null;
            for (int i = 0; i < DataDummy.daftarKodePromo.Count; i++)
            {
                if (DataDummy.daftarKodePromo[i].Kode.Trim().ToUpper() == kode.ToUpper())
                {
                    promo = DataDummy.daftarKodePromo[i];
                    break;
                }
            }

            if (promo == null)
            {
                MessageBox.Show("Kode promo tidak ditemukan.", "Kode Promo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tanggal hari ini masih dianggap berlaku
            if (promo.BerlakuSampai.Date < DateTime.Today)
            {
                MessageBox.Show("Kode promo sudah kedaluwarsa (berlaku sampai "
                    + promo.BerlakuSampai.ToString("dd-MM-yyyy") + ").", "Kode Promo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Berhasil: simpan promo lalu hitung ulang total
            promoBerlaku = promo;
            PerbaruiTotal();

            long diskon = HitungDiskon();
            lblInfoPromo.Text = "Kode " + promo.Kode + " diterapkan. Diskon IDR "
                + diskon.ToString("N0", new CultureInfo("id-ID")) + ".";
            lblInfoPromo.ForeColor = Color.DarkGreen;
            lblInfoPromo.Visible = true;
        }

        // Kalau isi kolom kode promo diubah, promo yang sudah
        // diterapkan dibatalkan dan total dihitung ulang tanpa diskon
        private void txtKodePromo_TextChanged(object sender, EventArgs e)
        {
            promoBerlaku = null;
            lblInfoPromo.Text = "";
            lblInfoPromo.Visible = false;
            PerbaruiTotal();
        }

        // Diskon promo dalam rupiah:
        // persentase x subtotal, dibulatkan ke bawah, dibatasi maksimum diskon
        private long HitungDiskon()
        {
            if (promoBerlaku == null || jadwal == null)
            {
                return 0;
            }

            long subtotal = (long)jadwal.HargaPerTiket * jumlahPenumpang;
            long diskon = subtotal * promoBerlaku.PersentaseDiskon / 100;

            if (diskon > promoBerlaku.MaksimumDiskon)
            {
                diskon = promoBerlaku.MaksimumDiskon;
            }

            if (diskon > subtotal)
            {
                diskon = subtotal;
            }

            return diskon;
        }

        // Total yang harus dibayar (tidak pernah negatif)
        private long HitungTotal()
        {
            if (jadwal == null)
            {
                return 0;
            }

            long subtotal = (long)jadwal.HargaPerTiket * jumlahPenumpang;
            long total = subtotal - HitungDiskon();

            if (total < 0)
            {
                total = 0;
            }

            return total;
        }

        // Menampilkan total di lblTotal, contoh: "IDR 685.000"
        private void PerbaruiTotal()
        {
            lblTotal.Text = "IDR " + HitungTotal().ToString("N0",
                new CultureInfo("id-ID"));
        }

        // Tombol Konfirmasi Pembayaran
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            // ===== Validasi (semua kesalahan dikumpulkan dulu) =====
            List<string> kesalahan = new List<string>();
            Control kontrolSalah = null;

            if (jadwal == null)
            {
                kesalahan.Add("Data penerbangan tidak ditemukan.");
                kontrolSalah = btnKonfirmasi;
            }

            // Data tiap penumpang
            for (int i = 0; i < daftarTitel.Count; i++)
            {
                string nomor = "Penumpang #" + (i + 1);

                if (daftarTitel[i].SelectedIndex <= 0)
                {
                    kesalahan.Add(nomor + ": Titel wajib dipilih.");
                    if (kontrolSalah == null)
                    {
                        kontrolSalah = daftarTitel[i];
                    }
                }

                string nama = RapikanNama(daftarNama[i].Text);
                if (nama == "")
                {
                    kesalahan.Add(nomor + ": Nama lengkap wajib diisi.");
                    if (kontrolSalah == null)
                    {
                        kontrolSalah = daftarNama[i];
                    }
                }
                else if (!NamaHanyaHurufDanSpasi(nama))
                {
                    kesalahan.Add(nomor + ": Nama lengkap hanya boleh berisi huruf dan spasi"
                        + " (tanpa tanda baca dan gelar).");
                    if (kontrolSalah == null)
                    {
                        kontrolSalah = daftarNama[i];
                    }
                }
            }

            // Kode promo harus sudah diterapkan lewat tombol Pakai
            string kode = txtKodePromo.Text.Trim();
            if (kode != "")
            {
                bool promoSesuai = promoBerlaku != null
                    && promoBerlaku.Kode.Trim().ToUpper() == kode.ToUpper();

                if (!promoSesuai)
                {
                    kesalahan.Add("Kode promo belum diterapkan. Klik tombol Pakai"
                        + " atau kosongkan kolom kode promo.");
                    if (kontrolSalah == null)
                    {
                        kontrolSalah = txtKodePromo;
                    }
                }
            }

            // Penerbangan yang sudah berangkat tidak bisa dibeli
            if (jadwal != null && jadwal.TanggalKeberangkatan < DateTime.Now)
            {
                kesalahan.Add("Penerbangan ini sudah berangkat, tiket tidak dapat dibeli.");
                if (kontrolSalah == null)
                {
                    kontrolSalah = btnKonfirmasi;
                }
            }

            if (kesalahan.Count > 0)
            {
                MessageBox.Show(string.Join("\n", kesalahan.ToArray()),
                    "Konfirmasi Pembayaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (kontrolSalah != null)
                {
                    kontrolSalah.Focus();
                }
                return;
            }

            // ===== Konfirmasi Yes/No =====
            string totalTeks = "IDR " + HitungTotal().ToString("N0",
                new CultureInfo("id-ID"));

            DialogResult jawab = MessageBox.Show(
                "Konfirmasi pembayaran sebesar " + totalTeks + "?",
                "Konfirmasi Pembayaran",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == DialogResult.No)
            {
                return;
            }

            // ===== Akun yang sedang login =====
            int akunId = SesiLogin.idAkun;
            if (akunId == 0 && SesiLogin.akunSaatIni != null)
            {
                akunId = SesiLogin.akunSaatIni.ID;
            }

            if (akunId == 0)
            {
                MessageBox.Show("Sesi login tidak ditemukan. Silakan login ulang.",
                    "Beli Tiket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ===== Simpan header transaksi =====
            TransaksiHeader header = new TransaksiHeader();
            header.Id = DataDummy.IdBerikutnyaTransaksiHeader();
            header.AkunId = akunId;
            header.TanggalTransaksi = DateTime.Now;
            header.JadwalPenerbanganId = jadwal.Id;
            header.JumlahPenumpang = jumlahPenumpang;
            header.TotalHarga = (int)HitungTotal();
            header.KodePromoId = promoBerlaku != null ? promoBerlaku.Id : (int?)null;
            DataDummy.daftarTransaksiHeader.Add(header);

            // ===== Simpan detail tiap penumpang =====
            for (int i = 0; i < daftarTitel.Count; i++)
            {
                TransaksiDetail detail = new TransaksiDetail();
                detail.Id = DataDummy.IdBerikutnyaTransaksiDetail();
                detail.TransaksiHeaderId = header.Id;
                detail.TitelPenumpang = daftarTitel[i].SelectedItem.ToString();
                detail.NamaLengkapPenumpang = RapikanNama(daftarNama[i].Text);
                DataDummy.daftarTransaksiDetail.Add(detail);
            }

            MessageBox.Show("Pembelian tiket berhasil.", "Beli Tiket",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Tombol kembali: tutup form ini tanpa membeli,
        // FormListPenerbangan tampil lagi dengan data yang sama
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ===== Kumpulan fungsi kecil =====

        // Merapikan nama: buang spasi awal/akhir,
        // gabungkan spasi ganda di tengah jadi satu spasi
        private string RapikanNama(string teks)
        {
            string hasil = teks.Trim();
            while (hasil.Contains("  "))
            {
                hasil = hasil.Replace("  ", " ");
            }
            return hasil;
        }

        // Nama hanya boleh berisi huruf A-Z, a-z, dan spasi
        private bool NamaHanyaHurufDanSpasi(string teks)
        {
            for (int i = 0; i < teks.Length; i++)
            {
                char c = teks[i];
                bool huruf = (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
                if (!huruf && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        // Pencarian data sederhana (linier, gaya pemula)

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
    }
}
