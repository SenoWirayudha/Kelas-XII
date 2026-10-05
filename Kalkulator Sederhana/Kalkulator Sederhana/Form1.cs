using System;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi bantu: mengecek apakah kedua TextBox sudah diisi atau belum.
        // Mengembalikan true kalau sudah terisi, false kalau masih kosong.
        private bool CekTextBoxKosong()
        {
            // Kalau salah satu TextBox masih kosong, munculkan pesan
            if (txtAngka1.Text.Trim() == "" || txtAngka2.Text.Trim() == "")
            {
                MessageBox.Show("Isi kedua angka dulu");
                return true;   // artinya masih ada yang kosong
            }

            return false;      // artinya kedua TextBox sudah terisi
        }

        // Event saat tombol Tambah diklik
        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Cek dulu apakah kedua TextBox sudah diisi
            if (CekTextBoxKosong())
            {
                return;
            }

            // Ambil angka dari TextBox
            double angka1 = double.Parse(txtAngka1.Text);
            double angka2 = double.Parse(txtAngka2.Text);

            // Hitung penjumlahan
            double hasil = angka1 + angka2;

            // Tampilkan hasilnya
            lblHasil.Text = hasil.ToString();
        }

        // Event saat tombol Kurang diklik
        private void btnKurang_Click(object sender, EventArgs e)
        {
            // Cek dulu apakah kedua TextBox sudah diisi
            if (CekTextBoxKosong())
            {
                return;
            }

            // Ambil angka dari TextBox
            double angka1 = double.Parse(txtAngka1.Text);
            double angka2 = double.Parse(txtAngka2.Text);

            // Hitung pengurangan
            double hasil = angka1 - angka2;

            // Tampilkan hasilnya
            lblHasil.Text = hasil.ToString();
        }

        // Event saat tombol Kali diklik
        private void btnKali_Click(object sender, EventArgs e)
        {
            // Cek dulu apakah kedua TextBox sudah diisi
            if (CekTextBoxKosong())
            {
                return;
            }

            // Ambil angka dari TextBox
            double angka1 = double.Parse(txtAngka1.Text);
            double angka2 = double.Parse(txtAngka2.Text);

            // Hitung perkalian
            double hasil = angka1 * angka2;

            // Tampilkan hasilnya
            lblHasil.Text = hasil.ToString();
        }

        // Event saat tombol Bagi diklik
        private void btnBagi_Click(object sender, EventArgs e)
        {
            // Cek dulu apakah kedua TextBox sudah diisi
            if (CekTextBoxKosong())
            {
                return;
            }

            // Ambil angka dari TextBox
            double angka1 = double.Parse(txtAngka1.Text);
            double angka2 = double.Parse(txtAngka2.Text);

            // Cek apakah pembacanya nol
            if (angka2 == 0)
            {
                MessageBox.Show("Tidak bisa dibagi dengan nol");
                return;
            }

            // Hitung pembagian
            double hasil = angka1 / angka2;

            // Tampilkan hasilnya
            lblHasil.Text = hasil.ToString();
        }
    }
}
