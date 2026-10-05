using System;

namespace Bromo_Airlines
{
    // Class sederhana yang berisi koneksi database.
    // Cukup diganti satu kali di sini, dipakai oleh semua form.
    static class Koneksi
    {
        // GANTI 2 BAGIAN INI sesuai komputer Anda:
        //   1. Server   = nama server SQL Server (localhost, ., atau localhost\SQLEXPRESS)
        //   2. Database = nama database hasil import file Database.sql
        public static string connectionString = "Server=localhost;Database=NamaDatabase;Trusted_Connection=True;";
    }
}
