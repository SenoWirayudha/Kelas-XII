using System;

namespace Bromo_Airlines
{
    // Menyimpan data akun yang sedang login,
    // supaya bisa dibaca oleh form-form lain.
    static class SesiLogin
    {
        public static int idAkun = 0;
        public static string username = "";
        public static string nama = "";
        public static bool merupakanAdmin = false;
    }
}
