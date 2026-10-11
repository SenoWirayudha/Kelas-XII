using System;

namespace Bromo_Airlines
{
    // =====================================================================
    // KODE LAMA (BELUM DIPAKAI)
    // File ini berisi koneksi ke SQL Server.
    // Saat ini aplikasi memakai DataDummy (di memori), jadi file ini
    // TIDAK dipanggil dari form manapun. Biarkan dulu, nanti ketika
    // mau disambungkan ke database lagi tinggal dipakai ulang.
    // =====================================================================
    static class Koneksi
    {
        // GANTI 2 BAGIAN INI sesuai komputer Anda:
        //   1. Server   = nama server SQL Server (localhost, ., atau localhost\SQLEXPRESS)
        //   2. Database = nama database hasil import file Database.sql
        public static string connectionString = "Server=localhost;Database=NamaDatabase;Trusted_Connection=True;";
    }
}
