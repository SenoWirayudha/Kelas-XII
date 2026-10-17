using System;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    // Penolong untuk berpindah antar halaman Admin.
    // Semua halaman Admin berbentuk form penuh (header + sidebar + konten),
    // jadi pindah halaman = buka form baru lalu tutup form lama.
    static class NavigasiAdmin
    {
        // Penanda: sedang pindah halaman lewat menu (bukan menutup aplikasi).
        // Saat bernilai true, tombol X form lama tidak boleh keluar aplikasi.
        public static bool sedangPindah = false;

        // Status sidebar (melebar / mengecil), dipakai bersama semua halaman
        // supaya tetap sama saat berpindah halaman.
        public static bool menuKecil = false;

        // Pindah dari satu halaman Admin ke halaman lain.
        // Posisi jendela disalin dulu supaya terasa tidak berpindah.
        public static void PindahKe(Form dari, Form tujuan)
        {
            sedangPindah = true;

            tujuan.StartPosition = FormStartPosition.Manual;
            tujuan.Location = dari.Location;
            tujuan.Show();
            dari.Close();

            sedangPindah = false;
        }
    }
}
