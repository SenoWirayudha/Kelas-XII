using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Class bantuan untuk memuat logo Bromo Airlines dari folder Resources.
    static class GambarLogo
    {
        // Nama file logo yang dicari di dalam folder Resources.
        // GANTI nama ini kalau file logo Anda berbeda (misalnya "bromo.jpg").
        public static string namaFile = "logo.png";

        // Mengembalikan gambar logo, atau null kalau file tidak ditemukan.
        public static Image Muat()
        {
            // Cari file logo di beberapa tempat yang mungkin
            string[] daftarJalur = new string[3];

            // Contoh: C:\...\bin\Debug\Resources\logo.png
            daftarJalur[0] = Path.Combine(Application.StartupPath, "Resources", namaFile);

            // Contoh: C:\...\bin\Debug\logo.png (folder Resources disalin ke output)
            daftarJalur[1] = Path.Combine(Directory.GetCurrentDirectory(), "Resources", namaFile);

            // Contoh: C:\...\Bromo Airlines\Resources\logo.png (folder proyek)
            daftarJalur[2] = Path.Combine(Application.StartupPath, "..", "..", "Resources", namaFile);

            for (int i = 0; i < daftarJalur.Length; i++)
            {
                if (File.Exists(daftarJalur[i]))
                {
                    return Image.FromFile(daftarJalur[i]);
                }
            }

            // Kalau file tidak ada, kembalikan null (logo tidak ditampilkan).
            return null;
        }
    }
}
