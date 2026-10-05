// array
string[] namaBuah = { "Apel", "Jeruk", "Mangga" };
//Console.WriteLine(namaBuah[0]); // Menampilkan Apel
//Console.WriteLine(namaBuah[1]); // Menampilkan Jeruk

foreach (string buah in namaBuah) // Foreach digunakan untuk menampilkan semua data array.
{
    Console.WriteLine(buah);
}

// list
List<string> namaBinatang = new List<string>();
namaBinatang.Add("Kucing");
namaBinatang.Add("Anjing");
foreach (string binatang in namaBinatang)
{
    Console.WriteLine(binatang);
}
