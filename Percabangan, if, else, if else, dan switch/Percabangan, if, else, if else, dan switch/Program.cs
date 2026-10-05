// if
int umur = 18;

if (umur >= 17) // If digunakan untuk mengecek kondisi, kondisi akan menghasilkan nilai true atau false.
{
    Console.WriteLine("Belum membuat KTP");
}
else // Else dijalankam jika kondisi false, if digunakan sebagai alternatif ketika kondisi if tidak terpenuhi.
{
    Console.WriteLine("Anda boleh membuat KTP");
}

// else if
int nilai = 85;

if (nilai >= 90)
{
    Console.WriteLine("Nilai A");
}
else if (nilai >= 75)
{
    Console.WriteLine("Nilai B");
}
else
{
    Console.WriteLine("Nilai C");
}

// Switch

string hari = "Senin";

switch (hari) // Switch digunakan untuk mengecek kondisi yang memiliki banyak kemungkinan.
{
    case "Senin": // Pilihan kondisi
        Console.WriteLine("Hari pertama");
        break; // Break 
    case "Minggu":
        Console.WriteLine("Hari Ketujuh");
        break;
    default:
        Console.WriteLine("Hari lain");
        break;
}