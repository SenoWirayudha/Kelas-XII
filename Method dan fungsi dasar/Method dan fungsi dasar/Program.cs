// Method
static void TampilkanData()
{
    Console.WriteLine("Menampilkan data");
}

TampilkanData(); // Memanggil method TampilkanData

// Method dengan parameter
static void TampilkanDataDiri(string nama, int umur)
{
    Console.WriteLine("Nama: " + nama);
    Console.WriteLine("Umur: " + umur);
}

TampilkanDataDiri("Jane", 25); // Memanggil method TampilkanDataDiri dengan parameter

// Method dengan return value
static int Tambah(int a, int b)
{
    return a + b; // Mengembalikan hasil penjumlahan
}

Console.WriteLine("Hasil penjumlahan: " + Tambah(10, 5)); // Memanggil method Tambah dan menampilkan hasilnya