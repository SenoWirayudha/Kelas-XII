using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Form hasil pencarian penerbangan untuk Customer.
    // Menerima asal, tujuan, tanggal, dan jumlah penumpang
    // dari CustomerMainForm, lalu menampilkan jadwal yang cocok.
    public partial class FormListPenerbangan : Form
    {
        // Data pencarian yang diterima dari CustomerMainForm
        private int idBandaraAsal = 0;
        private int idBandaraTujuan = 0;
        private DateTime tanggalKeberangkatan = DateTime.Today;
        private int jumlahPenumpang = 1;

        // Disimpan saat tombol Beli Tiket ditekan,
        // supaya siap dipakai form pembelian tiket nanti.
        private int idJadwalDipilih = 0;

        // Konstruktor tanpa parameter:
        // supaya form ini tetap bisa dibuka di designer Visual Studio.
        public FormListPenerbangan()
        {
            InitializeComponent();
        }

        // Konstruktor yang dipakai saat dibuka dari CustomerMainForm
        public FormListPenerbangan(int idAsal, int idTujuan, DateTime tanggal, int penumpang)
            : this()
        {
            idBandaraAsal = idAsal;
            idBandaraTujuan = idTujuan;
            tanggalKeberangkatan = tanggal;
            jumlahPenumpang = penumpang;
        }

        // Diisi saat form dibuka (bukan di InitializeComponent,
        // supaya designer tidak membaca data dummy)
        private void FormListPenerbangan_Load(object sender, EventArgs e)
        {
            // Ringkasan pencarian
            Bandara asal = CariBandara(idBandaraAsal);
            Bandara tujuan = CariBandara(idBandaraTujuan);

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

            // Contoh hasil: Mon, 22 May 2023 (bahasa Inggris, en-US)
            string teksTanggal = tanggalKeberangkatan.ToString("ddd, dd MMM yyyy",
                new CultureInfo("en-US"));

            lblRingkasan.Text = teksAsal + "  \u2192  " + teksTujuan + "  \u2022  "
                + teksTanggal + "  \u2022  " + jumlahPenumpang + " Penumpang";

            // Muat data (urutan awal mengikuti ComboBox = Harga Terendah)
            MuatData();
        }

        // Mengambil jadwal sesuai pencarian (asal + tujuan + tanggal)
        private List<JadwalPenerbangan> AmbilDataPencarian()
        {
            List<JadwalPenerbangan> hasil = new List<JadwalPenerbangan>();

            for (int i = 0; i < DataDummy.daftarJadwalPenerbangan.Count; i++)
            {
                JadwalPenerbangan jadwal = DataDummy.daftarJadwalPenerbangan[i];
                if (jadwal.BandaraAsalId == idBandaraAsal
                    && jadwal.BandaraTujuanId == idBandaraTujuan
                    && jadwal.TanggalKeberangkatan.Date == tanggalKeberangkatan.Date)
                {
                    hasil.Add(jadwal);
                }
            }

            return hasil;
        }

        // Memuat ulang data: pencarian -> filter waktu -> pengurutan -> grid
        private void MuatData()
        {
            List<JadwalPenerbangan> data = AmbilDataPencarian();

            // ===== Filter waktu keberangkatan =====
            bool waktu1 = chkWaktu1.Checked;
            bool waktu2 = chkWaktu2.Checked;
            bool waktu3 = chkWaktu3.Checked;
            bool waktu4 = chkWaktu4.Checked;

            // Kalau tidak ada yang dicentang, semua waktu ditampilkan
            if (waktu1 || waktu2 || waktu3 || waktu4)
            {
                List<JadwalPenerbangan> terfilter = new List<JadwalPenerbangan>();

                for (int i = 0; i < data.Count; i++)
                {
                    int jam = data[i].TanggalKeberangkatan.Hour;
                    bool masukRentang =
                        (waktu1 && jam >= 0 && jam < 6) ||
                        (waktu2 && jam >= 6 && jam < 12) ||
                        (waktu3 && jam >= 12 && jam < 18) ||
                        (waktu4 && jam >= 18 && jam <= 23);

                    if (masukRentang)
                    {
                        terfilter.Add(data[i]);
                    }
                }

                data = terfilter;
            }

            // ===== Pengurutan =====
            string urutan = "Harga Terendah";
            if (cmbUrutkan.SelectedItem != null)
            {
                urutan = cmbUrutkan.SelectedItem.ToString();
            }

            if (urutan == "Harga Terendah")
            {
                data.Sort((a, b) =>
                {
                    int hasil = a.HargaPerTiket.CompareTo(b.HargaPerTiket);
                    if (hasil != 0)
                    {
                        return hasil;
                    }
                    return a.TanggalKeberangkatan.CompareTo(b.TanggalKeberangkatan);
                });
            }
            else if (urutan == "Harga Tertinggi")
            {
                data.Sort((a, b) =>
                {
                    int hasil = b.HargaPerTiket.CompareTo(a.HargaPerTiket);
                    if (hasil != 0)
                    {
                        return hasil;
                    }
                    return a.TanggalKeberangkatan.CompareTo(b.TanggalKeberangkatan);
                });
            }
            else if (urutan == "Waktu Keberangkatan Terawal")
            {
                data.Sort((a, b) =>
                {
                    int hasil = a.TanggalKeberangkatan.CompareTo(b.TanggalKeberangkatan);
                    if (hasil != 0)
                    {
                        return hasil;
                    }
                    return a.HargaPerTiket.CompareTo(b.HargaPerTiket);
                });
            }
            else if (urutan == "Waktu Keberangkatan Terakhir")
            {
                data.Sort((a, b) =>
                {
                    int hasil = b.TanggalKeberangkatan.CompareTo(a.TanggalKeberangkatan);
                    if (hasil != 0)
                    {
                        return hasil;
                    }
                    return a.HargaPerTiket.CompareTo(b.HargaPerTiket);
                });
            }

            IsiGrid(data);
        }

        // Mengisi grid dari list jadwal (tampilan saja, data tidak diubah)
        private void IsiGrid(List<JadwalPenerbangan> data)
        {
            dgvPenerbangan.Rows.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                JadwalPenerbangan jadwal = data[i];

                Maskapai maskapai = CariMaskapai(jadwal.MaskapaiId);
                Bandara asal = CariBandara(jadwal.BandaraAsalId);
                Bandara tujuan = CariBandara(jadwal.BandaraTujuanId);

                DateTime waktuTiba = jadwal.TanggalKeberangkatan.AddMinutes(jadwal.DurasiMenit);

                int indexBaris = dgvPenerbangan.Rows.Add(
                    jadwal.KodePenerbangan,
                    maskapai != null ? maskapai.Nama : "",
                    asal != null ? asal.Nama : "",
                    tujuan != null ? tujuan.Nama : "",
                    jadwal.HargaPerTiket,
                    jadwal.TanggalKeberangkatan.ToString("dd-MM-yyyy"),
                    jadwal.TanggalKeberangkatan.ToString("HH:mm") + " - "
                        + waktuTiba.ToString("HH:mm"));

                // Simpan Id jadwal di baris (dipakai tombol Beli Tiket)
                dgvPenerbangan.Rows[indexBaris].Tag = jadwal.Id;
            }

            // Label kosong hanya tampil kalau hasilnya 0 baris
            lblKosong.Visible = (data.Count == 0);
            dgvPenerbangan.Visible = (data.Count > 0);

            // Tidak ada baris yang tersorot di awal
            dgvPenerbangan.ClearSelection();
        }

        // Tombol Terapkan Filter: muat ulang data
        private void btnFilter_Click(object sender, EventArgs e)
        {
            MuatData();
        }

        // Tombol kembali: tutup form ini,
        // CustomerMainForm otomatis tampil lagi (ShowDialog selesai)
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Tombol Beli Tiket per baris:
        // buka FormBeliTiket, kirim Id jadwal dan jumlah penumpang pencarian
        private void dgvPenerbangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvPenerbangan.Columns["kolomBeli"].Index)
            {
                idJadwalDipilih = Convert.ToInt32(dgvPenerbangan.Rows[e.RowIndex].Tag);

                // Sembunyikan form ini dulu, lalu buka FormBeliTiket
                this.Hide();
                FormBeliTiket formBeli = new FormBeliTiket(idJadwalDipilih, jumlahPenumpang);
                DialogResult hasil = formBeli.ShowDialog();

                if (hasil == DialogResult.OK)
                {
                    // Pembelian berhasil: form ini ikut tertutup,
                    // alur kembali ke CustomerMainForm
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Kembali atau tombol X: tampilkan lagi form ini
                    // dengan hasil pencarian dan filter yang masih sama
                    this.Show();
                }
            }
        }

        // Pencarian data sederhana (linier, gaya pemula)

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
    }
}
