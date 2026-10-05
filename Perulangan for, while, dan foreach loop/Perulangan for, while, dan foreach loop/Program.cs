// for 
// digunakan ketika jumlah perulangan sudah diketahui.


// isi parameter dari for loop
// int i = 1  -> inisialisasi variabel
// i < 5     -> kondisi perulangan
// i++       -> Menambahkan nilai variabel i setiap perulangan
for (int i = 1; i < 5; i++)
{
    Console.WriteLine("Perulangan ke-" + i);
}

// while loop
int angka = 1;
while (angka < 5)
{
    Console.WriteLine("Perulangan ke-" + angka);
    angka++;
}

// foreach loop
// digunakan untuk menelusuri semua elemen dalam array atau koleksi.
string[] buah = { "Apel", "Jeruk", "Mangga" };
foreach (string item in buah)
{
    Console.WriteLine(item);
}