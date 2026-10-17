using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Daftar tiket aktif milik Customer yang sedang login.
    // Tiket aktif = keberangkatan belum lewat dan status bukan Dibatalkan.
    public partial class FormTiketSaya : Form
    {
        // Konstruktor tanpa parameter:
        // supaya form ini tetap bisa dibuka di designer Visual Studio.
        public FormTiketSaya()
        {
            InitializeComponent();

            // Ikon jendela dari resource
            this.Icon = Properties.Resources.favicon;

            // Ikon tombol kembali (diisi di sini, bukan di InitializeComponent,
            // supaya designer tidak membaca resource)
            btnKembali.Image = Properties.Resources.ic_kembali;
        }

        // Diisi saat form dibuka (bukan di InitializeComponent,
        // supaya designer tidak membaca data dummy)
        private void FormTiketSaya_Load(object sender, EventArgs e)
        {
            // Akun yang sedang login
            int akunId = SesiLogin.idAkun;
            if (akunId == 0 && SesiLogin.akunSaatIni != null)
            {
                akunId = SesiLogin.akunSaatIni.ID;
            }

            if (akunId == 0)
            {
                MessageBox.Show("Sesi login tidak ditemukan. Silakan login ulang.",
                    "Tiket Saya", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            IsiGrid(AmbilTiketAktif(akunId));
        }

        // Mengambil transaksi milik akun ini yang masih AKTIF:
        // keberangkatan belum lewat DAN status bukan Dibatalkan.
        private List<TransaksiHeader> AmbilTiketAktif(int akunId)
        {
            List<TransaksiHeader> hasil = new List<TransaksiHeader>();

            for (int i = 0; i < DataDummy.daftarTransaksiHeader.Count; i++)
            {
                TransaksiHeader header = DataDummy.daftarTransaksiHeader[i];
                if (header.AkunId != akunId)
                {
                    continue;
                }

                JadwalPenerbangan jadwal = CariJadwal(header.JadwalPenerbanganId);
                if (jadwal == null)
                {
                    continue;
                }

                // Sudah berangkat = tidak aktif
                if (jadwal.TanggalKeberangkatan < DateTime.Now)
                {
                    continue;
                }

                // Dibatalkan = tidak aktif
                PerubahanStatusJadwal riwayat =
                    DataDummy.CariPerubahanStatusTerakhir(jadwal.Id);
                if (riwayat != null
                    && DataDummy.NamaStatus(riwayat.StatusPenerbanganId) == "Dibatalkan")
                {
                    continue;
                }

                hasil.Add(header);
            }

            // Urut: waktu keberangkatan menaik, sama -> kode A-Z
            hasil.Sort(delegate (TransaksiHeader a, TransaksiHeader b)
            {
                JadwalPenerbangan ja = CariJadwal(a.JadwalPenerbanganId);
                JadwalPenerbangan jb = CariJadwal(b.JadwalPenerbanganId);

                int beda = ja.TanggalKeberangkatan.CompareTo(jb.TanggalKeberangkatan);
                if (beda != 0)
                {
                    return beda;
                }
                return ja.KodePenerbangan.CompareTo(jb.KodePenerbangan);
            });

            return hasil;
        }

        // Mengisi grid dari list transaksi (tampilan saja, data tidak diubah)
        private void IsiGrid(List<TransaksiHeader> daftar)
        {
            dgvTiket.Rows.Clear();

            for (int i = 0; i < daftar.Count; i++)
            {
                TransaksiHeader header = daftar[i];
                JadwalPenerbangan jadwal = CariJadwal(header.JadwalPenerbanganId);

                Maskapai maskapai = CariMaskapai(jadwal.MaskapaiId);
                Bandara asal = CariBandara(jadwal.BandaraAsalId);
                Bandara tujuan = CariBandara(jadwal.BandaraTujuanId);

                DateTime waktuTiba = jadwal.TanggalKeberangkatan.AddMinutes(jadwal.DurasiMenit);

                // Waktu pakai InvariantCulture supaya pemisahnya titik dua (19:50)
                string waktu = jadwal.TanggalKeberangkatan.ToString("HH:mm",
                        CultureInfo.InvariantCulture) + " - "
                    + waktuTiba.ToString("HH:mm", CultureInfo.InvariantCulture);

                string status = DataDummy.TeksStatusTerakhir(jadwal.Id);

                int indexBaris = dgvTiket.Rows.Add(
                    jadwal.KodePenerbangan,
                    maskapai != null ? maskapai.Nama : "",
                    asal != null ? asal.Nama : "",
                    tujuan != null ? tujuan.Nama : "",
                    jadwal.TanggalKeberangkatan.ToString("dd-MM-yyyy"),
                    waktu,
                    status);

                // Simpan Id jadwal di baris (keperluan debugging/berikutnya)
                dgvTiket.Rows[indexBaris].Tag = jadwal.Id;

                // Kalau teks status terpotong, baca penuh lewat tooltip
                dgvTiket.Rows[indexBaris].Cells["kolomStatus"].ToolTipText = status;
            }

            // Label kosong hanya tampil kalau hasilnya 0 baris
            lblKosong.Visible = (daftar.Count == 0);
            dgvTiket.Visible = (daftar.Count > 0);
        }

        // Tombol kembali: tutup form ini,
        // CustomerMainForm otomatis tampil lagi (ShowDialog selesai)
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
