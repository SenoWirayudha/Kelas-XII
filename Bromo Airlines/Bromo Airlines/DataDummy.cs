using System;
using System.Collections.Generic;

namespace Bromo_Airlines
{
    // Class biasa untuk menyimpan satu data akun
    class Akun
    {
        public int ID;
        public string Username;
        public string Password;
        public string Nama;
        public DateTime TanggalLahir;
        public string NomorTelepon;
        public bool MerupakanAdmin;
    }

    // Class untuk menyimpan satu data negara.
    // Memakai property supaya bisa dipakai ComboBox (DisplayMember/ValueMember).
    class Negara
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string IbukotaNegara { get; set; }
    }

    // Class untuk menyimpan satu data bandara.
    // Memakai property supaya bisa dipakai ComboBox (DisplayMember/ValueMember).
    class Bandara
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string KodeIATA { get; set; }
        public string Kota { get; set; }
        public int NegaraId { get; set; }
        public int JumlahTerminal { get; set; }
        public string Alamat { get; set; }
    }

    // Class kecil untuk isi ComboBox bandara:
    // tampilan "Nama, Kota (KODE)" dan nilai Id-nya.
    class PilihanBandara
    {
        public int Id { get; set; }
        public string Teks { get; set; }
    }

    // Class untuk menyimpan satu data maskapai.
    // Memakai property supaya bisa dipakai ComboBox (DisplayMember/ValueMember).
    class Maskapai
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Perusahaan { get; set; }
        public int JumlahKru { get; set; }
        public string Deskripsi { get; set; }
    }

    // Class untuk menyimpan satu jadwal penerbangan.
    // TanggalKeberangkatan berisi tanggal DAN jam keberangkatan.
    class JadwalPenerbangan
    {
        public int Id;
        public string KodePenerbangan;
        public int BandaraAsalId;
        public int BandaraTujuanId;
        public int MaskapaiId;
        public DateTime TanggalKeberangkatan;
        public int DurasiMenit;
        public int HargaPerTiket;
    }

    // Class untuk menyimpan satu jenis status penerbangan.
    // Memakai property supaya bisa dipakai ComboBox (DisplayMember/ValueMember).
    class StatusPenerbangan
    {
        public int Id { get; set; }
        public string Nama { get; set; }
    }

    // Class untuk menyimpan satu riwayat perubahan status jadwal.
    // Data lama tidak ditimpa, jadi riwayatnya tetap ada.
    class PerubahanStatusJadwal
    {
        public int Id;
        public int JadwalPenerbanganId;
        public int StatusPenerbanganId;
        public DateTime WaktuPerubahanTerjadi;
        public int PerkiraanDelayMenit;
    }

    // Class untuk menyimpan satu transaksi penjualan tiket.
    // Masih sederhana, akan dilengkapi di tahap Transaksi.
    class Transaksi
    {
        public int Id;
        public int JadwalPenerbanganId;
        public int KodePromoId;
        public string NamaPembeli;
        public int JumlahTiket;
    }

    // Class untuk menyimpan satu header transaksi pembelian tiket.
    class TransaksiHeader
    {
        public int Id;
        public int AkunId;
        public DateTime TanggalTransaksi;
        public int JadwalPenerbanganId;
        public int JumlahPenumpang;
        public int TotalHarga;
        public int? KodePromoId; // null = tanpa promo
    }

    // Class untuk menyimpan satu data penumpang dalam satu transaksi.
    class TransaksiDetail
    {
        public int Id;
        public int TransaksiHeaderId;
        public string TitelPenumpang;
        public string NamaLengkapPenumpang;
    }

    // Class untuk menyimpan satu kode promo.
    class KodePromo
    {
        public int Id;
        public string Kode;
        public int PersentaseDiskon;
        public int MaksimumDiskon;
        public DateTime BerlakuSampai;
        public string Deskripsi;
    }

    // Menyimpan data contoh di memori (pakai List biasa).
    // Data hanya ada selama aplikasi berjalan,
    // hilang ketika aplikasi ditutup. Itu normal.
    static class DataDummy
    {
        // Daftar semua data
        public static List<Akun> daftarAkun = new List<Akun>();
        public static List<Negara> daftarNegara = new List<Negara>();
        public static List<Bandara> daftarBandara = new List<Bandara>();
        public static List<Maskapai> daftarMaskapai = new List<Maskapai>();
        public static List<JadwalPenerbangan> daftarJadwalPenerbangan = new List<JadwalPenerbangan>();
        public static List<PerubahanStatusJadwal> daftarPerubahanStatus = new List<PerubahanStatusJadwal>();
        public static List<StatusPenerbangan> daftarStatusPenerbangan = new List<StatusPenerbangan>();
        public static List<Transaksi> daftarTransaksi = new List<Transaksi>();
        public static List<KodePromo> daftarKodePromo = new List<KodePromo>();
        public static List<TransaksiHeader> daftarTransaksiHeader = new List<TransaksiHeader>();
        public static List<TransaksiDetail> daftarTransaksiDetail = new List<TransaksiDetail>();

        // Isi data contoh, dijalankan sekali saat pertama kali dipakai
        static DataDummy()
        {
            // ===== Akun =====

            // 1 akun admin
            daftarAkun.Add(new Akun
            {
                ID = 1,
                Username = "admin",
                Password = "admin123",
                Nama = "Administrator",
                TanggalLahir = new DateTime(1990, 1, 1),
                NomorTelepon = "081234567890",
                MerupakanAdmin = true
            });

            // Beberapa akun customer
            daftarAkun.Add(new Akun
            {
                ID = 2,
                Username = "user",
                Password = "user1234",
                Nama = "Andi Taulany",
                TanggalLahir = new DateTime(2003, 2, 1),
                NomorTelepon = "08123456789",
                MerupakanAdmin = false
            });

            daftarAkun.Add(new Akun
            {
                ID = 3,
                Username = "siti",
                Password = "siti1234",
                Nama = "Siti Aminah",
                TanggalLahir = new DateTime(1998, 8, 20),
                NomorTelepon = "081377788899",
                MerupakanAdmin = false
            });

            daftarAkun.Add(new Akun
            {
                ID = 4,
                Username = "andi",
                Password = "andi1234",
                Nama = "Andi Wijaya",
                TanggalLahir = new DateTime(2000, 3, 15),
                NomorTelepon = "081555666777",
                MerupakanAdmin = false
            });

            daftarAkun.Add(new Akun
            {
                ID = 5,
                Username = "dewi",
                Password = "dewi1234",
                Nama = "Dewi Lestari",
                TanggalLahir = new DateTime(1997, 12, 1),
                NomorTelepon = "081612345678",
                MerupakanAdmin = false
            });

            daftarAkun.Add(new Akun
            {
                ID = 6,
                Username = "rudi",
                Password = "rudi1234",
                Nama = "Rudi Hartono",
                TanggalLahir = new DateTime(1993, 7, 25),
                NomorTelepon = "081700011122",
                MerupakanAdmin = false
            });

            daftarAkun.Add(new Akun
            {
                ID = 7,
                Username = "maya",
                Password = "maya1234",
                Nama = "Maya Putri",
                TanggalLahir = new DateTime(2001, 2, 14),
                NomorTelepon = "081822233344",
                MerupakanAdmin = false
            });

            // ===== Negara =====

            daftarNegara.Add(new Negara { Id = 1, Nama = "Afghanistan", IbukotaNegara = "Kabul" });
            daftarNegara.Add(new Negara { Id = 2, Nama = "Indonesia", IbukotaNegara = "Jakarta" });
            daftarNegara.Add(new Negara { Id = 3, Nama = "Jepang", IbukotaNegara = "Tokyo" });
            daftarNegara.Add(new Negara { Id = 4, Nama = "Malaysia", IbukotaNegara = "Kuala Lumpur" });
            daftarNegara.Add(new Negara { Id = 5, Nama = "Singapura", IbukotaNegara = "Singapura" });
            daftarNegara.Add(new Negara { Id = 6, Nama = "Thailand", IbukotaNegara = "Bangkok" });
            daftarNegara.Add(new Negara { Id = 7, Nama = "Australia", IbukotaNegara = "Canberra" });
            daftarNegara.Add(new Negara { Id = 8, Nama = "India", IbukotaNegara = "New Delhi" });
            daftarNegara.Add(new Negara { Id = 9, Nama = "Filipina", IbukotaNegara = "Manila" });
            daftarNegara.Add(new Negara { Id = 10, Nama = "Vietnam", IbukotaNegara = "Hanoi" });

            // ===== Bandara (semua di Indonesia, NegaraId = 2) =====

            daftarBandara.Add(new Bandara
            {
                ID = 1,
                Nama = "Abdul Rachman Saleh",
                KodeIATA = "MLG",
                Kota = "Malang",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Dr. Wahidin Sudirohusodo No. 510, Malang"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 2,
                Nama = "Abresso",
                KodeIATA = "RSK",
                Kota = "Manokwari",
                NegaraId = 2,
                JumlahTerminal = 1,
                Alamat = "Jl. Raya Manokwari, Papua Barat"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 3,
                Nama = "Achmad Yani",
                KodeIATA = "SRG",
                Kota = "Semarang",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Bendan Ngisor, Semarang"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 4,
                Nama = "Adi Sucipto",
                KodeIATA = "JOG",
                Kota = "Yogyakarta",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Solo KM. 9, Yogyakarta"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 5,
                Nama = "Adisumarmo",
                KodeIATA = "SOC",
                Kota = "Solo",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Ir. Soekarno, Surakarta"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 6,
                Nama = "Aek Godang",
                KodeIATA = "AEG",
                Kota = "Padang Sidempuan",
                NegaraId = 2,
                JumlahTerminal = 1,
                Alamat = "Jl. Bandara Aek Godang, Sumatera Utara"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 7,
                Nama = "Husein Sastranegara",
                KodeIATA = "BDO",
                Kota = "Bandung",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Pajajaran No. 121, Bandung"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 8,
                Nama = "Juanda",
                KodeIATA = "SUB",
                Kota = "Surabaya",
                NegaraId = 2,
                JumlahTerminal = 3,
                Alamat = "Jl. Bandara Juanda, Surabaya"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 9,
                Nama = "Ngurah Rai",
                KodeIATA = "DPS",
                Kota = "Denpasar",
                NegaraId = 2,
                JumlahTerminal = 3,
                Alamat = "Jl. Ngurah Rai, Badung, Bali"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 10,
                Nama = "Sultan Hasanuddin",
                KodeIATA = "UPG",
                Kota = "Makassar",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Airport No. 1, Makassar"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 11,
                Nama = "Kualanamu",
                KodeIATA = "KNO",
                Kota = "Medan",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Bandara Kualanamu, Deli Serdang"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 12,
                Nama = "Minangkabau",
                KodeIATA = "PDG",
                Kota = "Padang",
                NegaraId = 2,
                JumlahTerminal = 2,
                Alamat = "Jl. Bandara Minangkabau, Padang Pariaman"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 13,
                Nama = "Halim Perdanakusuma",
                KodeIATA = "HLP",
                Kota = "Jakarta",
                NegaraId = 2,
                JumlahTerminal = 1,
                Alamat = "Jl. Halim Perdanakusuma, Jakarta Timur"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 14,
                Nama = "Soekarno-Hatta",
                KodeIATA = "CGK",
                Kota = "Tangerang",
                NegaraId = 2,
                JumlahTerminal = 3,
                Alamat = "Jl. Bandara Soekarno-Hatta, Tangerang"
            });

            daftarBandara.Add(new Bandara
            {
                ID = 15,
                Nama = "Supadio",
                KodeIATA = "PNK",
                Kota = "Pontianak",
                NegaraId = 2,
                JumlahTerminal = 1,
                Alamat = "Jl. Bandara Supadio, Pontianak"
            });

            // ===== Maskapai =====

            daftarMaskapai.Add(new Maskapai
            {
                Id = 1,
                Nama = "Adam Air",
                Perusahaan = "PT Adam Air",
                JumlahKru = 16,
                Deskripsi = "Adam Air adalah salah satu maskapai penerbangan di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 2,
                Nama = "Aviastar",
                Perusahaan = "PT Aviastar",
                JumlahKru = 12,
                Deskripsi = "Aviastar adalah maskapai penerbangan perintis yang melayani rute-rute daerah."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 3,
                Nama = "Batavia Air",
                Perusahaan = "PT Batavia Air",
                JumlahKru = 6,
                Deskripsi = "Batavia Air adalah maskapai penerbangan yang berpusat di Jakarta."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 4,
                Nama = "Batik Air",
                Perusahaan = "PT Batik Air",
                JumlahKru = 17,
                Deskripsi = "Batik Air adalah maskapai penerbangan bertarif rendah di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 5,
                Nama = "Bouraq Indonesia",
                Perusahaan = "PT Bouraq Indonesia",
                JumlahKru = 19,
                Deskripsi = "Bouraq Indonesia adalah maskapai penerbangan domestik di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 6,
                Nama = "Citilink",
                Perusahaan = "PT Citilink",
                JumlahKru = 12,
                Deskripsi = "Citilink adalah maskapai penerbangan berbiaya rendah di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 7,
                Nama = "Garuda Indonesia",
                Perusahaan = "PT Garuda Indonesia",
                JumlahKru = 5,
                Deskripsi = "Garuda Indonesia adalah maskapai penerbangan nasional Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 8,
                Nama = "Lion Air",
                Perusahaan = "PT Lion Air",
                JumlahKru = 12,
                Deskripsi = "Lion Air adalah maskapai penerbangan swasta terbesar di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 9,
                Nama = "Sriwijaya Air",
                Perusahaan = "PT Sriwijaya Air",
                JumlahKru = 10,
                Deskripsi = "Sriwijaya Air adalah maskapai penerbangan yang berpusat di Jakarta."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 10,
                Nama = "Super Air Jet",
                Perusahaan = "PT Super Air Jet",
                JumlahKru = 12,
                Deskripsi = "Super Air Jet adalah maskapai penerbangan bertarif rendah di Indonesia."
            });

            daftarMaskapai.Add(new Maskapai
            {
                Id = 11,
                Nama = "Pelita Air",
                Perusahaan = "PT Pelita Air",
                JumlahKru = 10,
                Deskripsi = "Pelita Air adalah maskapai penerbangan yang berpusat di Jakarta."
            });

            // ===== Jadwal penerbangan =====
            // Semua waktu tiba masih di hari yang sama (tidak lewat tengah malam).

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 1,
                KodePenerbangan = "ID-7518",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 13, // Halim Perdanakusuma (HLP)
                MaskapaiId = 4, // Batik Air
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 19, 55, 0),
                DurasiMenit = 70,
                HargaPerTiket = 829891
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 2,
                KodePenerbangan = "IP-0203",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 11, // Pelita Air
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 19, 50, 0),
                DurasiMenit = 80,
                HargaPerTiket = 684000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 3,
                KodePenerbangan = "QG-0719",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 6, // Citilink
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 19, 30, 0),
                DurasiMenit = 75,
                HargaPerTiket = 1317538
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 4,
                KodePenerbangan = "QG-0173",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 13, // Halim Perdanakusuma (HLP)
                MaskapaiId = 6, // Citilink
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 19, 0, 0),
                DurasiMenit = 85,
                HargaPerTiket = 772601
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 5,
                KodePenerbangan = "GA-0325",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 7, // Garuda Indonesia
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 18, 40, 0),
                DurasiMenit = 90,
                HargaPerTiket = 1536880
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 6,
                KodePenerbangan = "QG-0737",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 6, // Citilink
                TanggalKeberangkatan = new DateTime(2023, 5, 30, 18, 40, 0),
                DurasiMenit = 80,
                HargaPerTiket = 1317538
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 7,
                KodePenerbangan = "GA-321",
                BandaraAsalId = 14, // Soekarno-Hatta (CGK)
                BandaraTujuanId = 9, // Ngurah Rai (DPS)
                MaskapaiId = 7, // Garuda Indonesia
                TanggalKeberangkatan = new DateTime(2023, 6, 1, 8, 0, 0),
                DurasiMenit = 95,
                HargaPerTiket = 1200000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 8,
                KodePenerbangan = "JT-611",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 9, // Ngurah Rai (DPS)
                MaskapaiId = 8, // Lion Air
                TanggalKeberangkatan = new DateTime(2023, 6, 2, 10, 30, 0),
                DurasiMenit = 65,
                HargaPerTiket = 950000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 9,
                KodePenerbangan = "IU-0696",
                BandaraAsalId = 14, // Soekarno-Hatta (CGK)
                BandaraTujuanId = 15, // Supadio (PNK)
                MaskapaiId = 10, // Super Air Jet
                TanggalKeberangkatan = new DateTime(2023, 4, 21, 7, 25, 0),
                DurasiMenit = 95,
                HargaPerTiket = 895000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 10,
                KodePenerbangan = "IU-0697",
                BandaraAsalId = 15, // Supadio (PNK)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 10, // Super Air Jet
                TanggalKeberangkatan = new DateTime(2023, 4, 27, 9, 40, 0),
                DurasiMenit = 85,
                HargaPerTiket = 875000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 11,
                KodePenerbangan = "ID-7508",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 13, // Halim Perdanakusuma (HLP)
                MaskapaiId = 4, // Batik Air
                TanggalKeberangkatan = new DateTime(2023, 5, 22, 5, 0, 0),
                DurasiMenit = 75,
                HargaPerTiket = 745000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = 12,
                KodePenerbangan = "JT-0786",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 8, // Lion Air
                TanggalKeberangkatan = new DateTime(2023, 5, 22, 5, 0, 0),
                DurasiMenit = 95,
                HargaPerTiket = 925000
            });

            // ===== Jadwal dengan tanggal relatif (untuk form List Penerbangan) =====
            // Tanggal dihitung dari hari ini supaya pencarian Customer
            // selalu menemukan data kapan pun aplikasi dijalankan
            // (validasi pencarian menolak tanggal sebelum hari ini).
            // Semua tiba di hari yang sama (tidak lewat tengah malam).

            DateTime besok = DateTime.Today.AddDays(1);
            DateTime lusa = DateTime.Today.AddDays(2);

            // Rute Juanda -> Soekarno-Hatta, hari besok
            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0501",
                BandaraAsalId = 8, // Juanda (SUB)
                BandaraTujuanId = 14, // Soekarno-Hatta (CGK)
                MaskapaiId = 8, // Lion Air
                TanggalKeberangkatan = besok.AddHours(4).AddMinutes(30),
                DurasiMenit = 85,
                HargaPerTiket = 700000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0333",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10, // Super Air Jet
                TanggalKeberangkatan = besok.AddHours(6),
                DurasiMenit = 85,
                HargaPerTiket = 725966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0591",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8, // Lion Air
                TanggalKeberangkatan = besok.AddHours(6).AddMinutes(15),
                DurasiMenit = 85,
                HargaPerTiket = 726331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0573",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = besok.AddHours(7).AddMinutes(40),
                DurasiMenit = 85,
                HargaPerTiket = 726331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0693",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = besok.AddHours(7).AddMinutes(55),
                DurasiMenit = 85,
                HargaPerTiket = 726331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0331",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = besok.AddHours(8),
                DurasiMenit = 85,
                HargaPerTiket = 725966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0697",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = besok.AddHours(11).AddMinutes(20),
                DurasiMenit = 85,
                HargaPerTiket = 726331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0343",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = besok.AddHours(16),
                DurasiMenit = 90,
                HargaPerTiket = 725966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0341",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = besok.AddHours(17),
                DurasiMenit = 90,
                HargaPerTiket = 725966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IP-0203",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 11, // Pelita Air
                TanggalKeberangkatan = besok.AddHours(19).AddMinutes(50),
                DurasiMenit = 95,
                HargaPerTiket = 685000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "GA-0325",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 7, // Garuda Indonesia
                TanggalKeberangkatan = besok.AddHours(21).AddMinutes(30),
                DurasiMenit = 90,
                HargaPerTiket = 1536880
            });

            // Rute Juanda -> Soekarno-Hatta, hari lusa
            // (sama, cuma harga sedikit berbeda)
            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0501",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = lusa.AddHours(4).AddMinutes(30),
                DurasiMenit = 85,
                HargaPerTiket = 704500
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0333",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = lusa.AddHours(6),
                DurasiMenit = 85,
                HargaPerTiket = 728966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0591",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = lusa.AddHours(6).AddMinutes(15),
                DurasiMenit = 85,
                HargaPerTiket = 729331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0573",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = lusa.AddHours(7).AddMinutes(40),
                DurasiMenit = 85,
                HargaPerTiket = 729331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0693",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = lusa.AddHours(7).AddMinutes(55),
                DurasiMenit = 85,
                HargaPerTiket = 729331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0331",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = lusa.AddHours(8),
                DurasiMenit = 85,
                HargaPerTiket = 728966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "JT-0697",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 8,
                TanggalKeberangkatan = lusa.AddHours(11).AddMinutes(20),
                DurasiMenit = 85,
                HargaPerTiket = 729331
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0343",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = lusa.AddHours(16),
                DurasiMenit = 90,
                HargaPerTiket = 728966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IU-0341",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 10,
                TanggalKeberangkatan = lusa.AddHours(17),
                DurasiMenit = 90,
                HargaPerTiket = 728966
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "IP-0203",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 11,
                TanggalKeberangkatan = lusa.AddHours(19).AddMinutes(50),
                DurasiMenit = 95,
                HargaPerTiket = 689500
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "GA-0325",
                BandaraAsalId = 8,
                BandaraTujuanId = 14,
                MaskapaiId = 7,
                TanggalKeberangkatan = lusa.AddHours(21).AddMinutes(30),
                DurasiMenit = 90,
                HargaPerTiket = 1540880
            });

            // Rute lain: Juanda -> Halim Perdanakusuma (besok dan lusa)
            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "ID-7508",
                BandaraAsalId = 8,
                BandaraTujuanId = 13, // Halim Perdanakusuma (HLP)
                MaskapaiId = 4, // Batik Air
                TanggalKeberangkatan = besok.AddHours(5),
                DurasiMenit = 75,
                HargaPerTiket = 745000
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "QG-0173",
                BandaraAsalId = 8,
                BandaraTujuanId = 13,
                MaskapaiId = 6, // Citilink
                TanggalKeberangkatan = besok.AddHours(9),
                DurasiMenit = 85,
                HargaPerTiket = 772601
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "ID-7518",
                BandaraAsalId = 8,
                BandaraTujuanId = 13,
                MaskapaiId = 4,
                TanggalKeberangkatan = besok.AddHours(19).AddMinutes(55),
                DurasiMenit = 70,
                HargaPerTiket = 829891
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "ID-7508",
                BandaraAsalId = 8,
                BandaraTujuanId = 13,
                MaskapaiId = 4,
                TanggalKeberangkatan = lusa.AddHours(5),
                DurasiMenit = 75,
                HargaPerTiket = 748500
            });

            daftarJadwalPenerbangan.Add(new JadwalPenerbangan
            {
                Id = IdBerikutnyaJadwal(),
                KodePenerbangan = "QG-0173",
                BandaraAsalId = 8,
                BandaraTujuanId = 13,
                MaskapaiId = 6,
                TanggalKeberangkatan = lusa.AddHours(9),
                DurasiMenit = 85,
                HargaPerTiket = 776601
            });

            // ===== Status penerbangan =====
            // Nama status harus persis seperti ini.

            daftarStatusPenerbangan.Add(new StatusPenerbangan
            {
                Id = 1,
                Nama = "Sesuai Jadwal"
            });

            daftarStatusPenerbangan.Add(new StatusPenerbangan
            {
                Id = 2,
                Nama = "Delay"
            });

            daftarStatusPenerbangan.Add(new StatusPenerbangan
            {
                Id = 3,
                Nama = "Dibatalkan"
            });

            // ===== Perubahan status & transaksi (contoh sederhana) =====
            // Riwayat perubahan status tidak pernah ditimpa,
            // jadi semua catatan tetap tersimpan.

            // ID-7518: delay selama 90 menit
            daftarPerubahanStatus.Add(new PerubahanStatusJadwal
            {
                Id = 1,
                JadwalPenerbanganId = 1, // ID-7518
                StatusPenerbanganId = 2, // Delay
                WaktuPerubahanTerjadi = new DateTime(2023, 5, 30, 17, 30, 15),
                PerkiraanDelayMenit = 90
            });

            // QG-0719: dibatalkan
            daftarPerubahanStatus.Add(new PerubahanStatusJadwal
            {
                Id = 2,
                JadwalPenerbanganId = 3, // QG-0719
                StatusPenerbanganId = 3, // Dibatalkan
                WaktuPerubahanTerjadi = new DateTime(2023, 5, 30, 14, 5, 40),
                PerkiraanDelayMenit = 0
            });

            // GA-0325: dua perubahan berurutan,
            // yang tampil di grid adalah yang paling baru (Dibatalkan)
            daftarPerubahanStatus.Add(new PerubahanStatusJadwal
            {
                Id = 3,
                JadwalPenerbanganId = 5, // GA-0325
                StatusPenerbanganId = 2, // Delay
                WaktuPerubahanTerjadi = new DateTime(2023, 5, 30, 9, 15, 0),
                PerkiraanDelayMenit = 45
            });

            daftarPerubahanStatus.Add(new PerubahanStatusJadwal
            {
                Id = 4,
                JadwalPenerbanganId = 5, // GA-0325
                StatusPenerbanganId = 3, // Dibatalkan
                WaktuPerubahanTerjadi = new DateTime(2023, 5, 30, 12, 30, 25),
                PerkiraanDelayMenit = 0
            });

            daftarTransaksi.Add(new Transaksi
            {
                Id = 1,
                JadwalPenerbanganId = 8, // JT-611
                KodePromoId = 1, // BROMOAJAYUK
                NamaPembeli = "Budi Santoso",
                JumlahTiket = 2
            });

            // ===== Kode promo =====
            // Dua kode pertama sudah kedaluwarsa (contoh data lama),
            // dua kode terakhir tanggalnya masih berlaku.

            daftarKodePromo.Add(new KodePromo
            {
                Id = 1,
                Kode = "BROMOAJAYUK",
                PersentaseDiskon = 15,
                MaksimumDiskon = 100000,
                BerlakuSampai = new DateTime(2023, 9, 9),
                Deskripsi = "Yuk pakai diskon spesial dari Bromo Airlines untuk perjalananmu."
            });

            daftarKodePromo.Add(new KodePromo
            {
                Id = 2,
                Kode = "NAIKBROMOAIRLINES",
                PersentaseDiskon = 10,
                MaksimumDiskon = 150000,
                BerlakuSampai = new DateTime(2023, 9, 9),
                Deskripsi = "Bromo Airlines memberikan diskon untuk penerbangan pilihan."
            });

            daftarKodePromo.Add(new KodePromo
            {
                Id = 3,
                Kode = "HEMATBROMO",
                PersentaseDiskon = 25,
                MaksimumDiskon = 200000,
                BerlakuSampai = new DateTime(2027, 12, 31),
                Deskripsi = "Diskon spesial akhir tahun untuk semua penerbangan Bromo Airlines."
            });

            daftarKodePromo.Add(new KodePromo
            {
                Id = 4,
                Kode = "TERBANGHEMAT",
                PersentaseDiskon = 20,
                MaksimumDiskon = 175000,
                BerlakuSampai = new DateTime(2027, 6, 30),
                Deskripsi = "Gunakan kode ini dan hemat lebih banyak untuk perjalananmu."
            });

            // ===== Transaksi dummy customer "user" (Andi Taulany, id 2) =====
            // Jadwal IP-0203 besok (Juanda -> Soekarno-Hatta, berangkat 19:50).
            // Tanggalnya relatif supaya selalu valid kapan pun aplikasi dijalankan.

            JadwalPenerbangan jadwalIp = null;
            for (int i = 0; i < daftarJadwalPenerbangan.Count; i++)
            {
                JadwalPenerbangan j = daftarJadwalPenerbangan[i];
                if (j.KodePenerbangan == "IP-0203"
                    && j.TanggalKeberangkatan.Date == DateTime.Today.AddDays(1))
                {
                    jadwalIp = j;
                    break;
                }
            }

            if (jadwalIp != null)
            {
                // Riwayat status: Delay 90 menit, hari ini pukul 08:30:15.
                // Kalau jadwal ini sudah punya riwayat dari data dummy
                // sebelumnya, jangan dibuat ganda.
                bool sudahAdaRiwayat = false;
                for (int i = 0; i < daftarPerubahanStatus.Count; i++)
                {
                    if (daftarPerubahanStatus[i].JadwalPenerbanganId == jadwalIp.Id)
                    {
                        sudahAdaRiwayat = true;
                        break;
                    }
                }

                if (sudahAdaRiwayat == false)
                {
                    daftarPerubahanStatus.Add(new PerubahanStatusJadwal
                    {
                        Id = IdBerikutnyaPerubahanStatus(),
                        JadwalPenerbanganId = jadwalIp.Id,
                        StatusPenerbanganId = 2, // Delay
                        WaktuPerubahanTerjadi = DateTime.Today
                            .AddHours(8).AddMinutes(30).AddSeconds(15),
                        PerkiraanDelayMenit = 90
                    });
                }

                // Transaksi aktif: 1 penumpang, tanpa promo
                TransaksiHeader headerIp = new TransaksiHeader();
                headerIp.Id = IdBerikutnyaTransaksiHeader();
                headerIp.AkunId = 2; // user (Andi Taulany)
                headerIp.TanggalTransaksi = DateTime.Now;
                headerIp.JadwalPenerbanganId = jadwalIp.Id;
                headerIp.JumlahPenumpang = 1;
                headerIp.TotalHarga = jadwalIp.HargaPerTiket;
                headerIp.KodePromoId = null;
                daftarTransaksiHeader.Add(headerIp);

                TransaksiDetail detailIp = new TransaksiDetail();
                detailIp.Id = IdBerikutnyaTransaksiDetail();
                detailIp.TransaksiHeaderId = headerIp.Id;
                detailIp.TitelPenumpang = "Mr";
                detailIp.NamaLengkapPenumpang = "Andi Taulany";
                daftarTransaksiDetail.Add(detailIp);
            }

            // Transaksi kedua: penerbangan yang SUDAH lewat (kemarin),
            // supaya terlihat bahwa tiket yang sudah berangkat
            // tidak muncul di daftar Tiket Saya.
            JadwalPenerbangan jadwalKemarin = new JadwalPenerbangan();
            jadwalKemarin.Id = IdBerikutnyaJadwal();
            jadwalKemarin.KodePenerbangan = "JT-0707";
            jadwalKemarin.BandaraAsalId = 8; // Juanda (SUB)
            jadwalKemarin.BandaraTujuanId = 14; // Soekarno-Hatta (CGK)
            jadwalKemarin.MaskapaiId = 8; // Lion Air
            jadwalKemarin.TanggalKeberangkatan = DateTime.Today.AddDays(-1).AddHours(8);
            jadwalKemarin.DurasiMenit = 85; // tiba 09:25, tidak lewat tengah malam
            jadwalKemarin.HargaPerTiket = 700000;
            daftarJadwalPenerbangan.Add(jadwalKemarin);

            TransaksiHeader headerKemarin = new TransaksiHeader();
            headerKemarin.Id = IdBerikutnyaTransaksiHeader();
            headerKemarin.AkunId = 2; // user (Andi Taulany)
            headerKemarin.TanggalTransaksi = DateTime.Now.AddDays(-1);
            headerKemarin.JadwalPenerbanganId = jadwalKemarin.Id;
            headerKemarin.JumlahPenumpang = 1;
            headerKemarin.TotalHarga = jadwalKemarin.HargaPerTiket;
            headerKemarin.KodePromoId = null;
            daftarTransaksiHeader.Add(headerKemarin);

            TransaksiDetail detailKemarin = new TransaksiDetail();
            detailKemarin.Id = IdBerikutnyaTransaksiDetail();
            detailKemarin.TransaksiHeaderId = headerKemarin.Id;
            detailKemarin.TitelPenumpang = "Mr";
            detailKemarin.NamaLengkapPenumpang = "Andi Taulany";
            daftarTransaksiDetail.Add(detailKemarin);
        }

        // Membuat ID baru untuk akun supaya tidak bertabrakan
        public static int IdBerikutnya()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarAkun.Count; i++)
            {
                if (daftarAkun[i].ID > idTerbesar)
                {
                    idTerbesar = daftarAkun[i].ID;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk bandara
        public static int IdBerikutnyaBandara()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarBandara.Count; i++)
            {
                if (daftarBandara[i].ID > idTerbesar)
                {
                    idTerbesar = daftarBandara[i].ID;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk maskapai
        public static int IdBerikutnyaMaskapai()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarMaskapai.Count; i++)
            {
                if (daftarMaskapai[i].Id > idTerbesar)
                {
                    idTerbesar = daftarMaskapai[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk jadwal penerbangan
        public static int IdBerikutnyaJadwal()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarJadwalPenerbangan.Count; i++)
            {
                if (daftarJadwalPenerbangan[i].Id > idTerbesar)
                {
                    idTerbesar = daftarJadwalPenerbangan[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk kode promo
        public static int IdBerikutnyaKodePromo()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarKodePromo.Count; i++)
            {
                if (daftarKodePromo[i].Id > idTerbesar)
                {
                    idTerbesar = daftarKodePromo[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk riwayat perubahan status
        public static int IdBerikutnyaPerubahanStatus()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarPerubahanStatus.Count; i++)
            {
                if (daftarPerubahanStatus[i].Id > idTerbesar)
                {
                    idTerbesar = daftarPerubahanStatus[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk header transaksi
        public static int IdBerikutnyaTransaksiHeader()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarTransaksiHeader.Count; i++)
            {
                if (daftarTransaksiHeader[i].Id > idTerbesar)
                {
                    idTerbesar = daftarTransaksiHeader[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Membuat ID baru untuk detail transaksi
        public static int IdBerikutnyaTransaksiDetail()
        {
            int idTerbesar = 0;
            for (int i = 0; i < daftarTransaksiDetail.Count; i++)
            {
                if (daftarTransaksiDetail[i].Id > idTerbesar)
                {
                    idTerbesar = daftarTransaksiDetail[i].Id;
                }
            }
            return idTerbesar + 1;
        }

        // Mencari riwayat perubahan status milik sebuah jadwal
        // yang waktunya paling baru. Kalau tidak ada = null.
        // Dipakai bersama oleh FormUbahStatus dan FormTiketSaya.
        public static PerubahanStatusJadwal CariPerubahanStatusTerakhir(int jadwalId)
        {
            PerubahanStatusJadwal hasil = null;
            for (int i = 0; i < daftarPerubahanStatus.Count; i++)
            {
                PerubahanStatusJadwal riwayat = daftarPerubahanStatus[i];
                if (riwayat.JadwalPenerbanganId == jadwalId)
                {
                    if (hasil == null ||
                        riwayat.WaktuPerubahanTerjadi > hasil.WaktuPerubahanTerjadi)
                    {
                        hasil = riwayat;
                    }
                }
            }
            return hasil;
        }

        // Mencari nama status berdasarkan ID. Kalau tidak ketemu = "-"
        public static string NamaStatus(int id)
        {
            for (int i = 0; i < daftarStatusPenerbangan.Count; i++)
            {
                if (daftarStatusPenerbangan[i].Id == id)
                {
                    return daftarStatusPenerbangan[i].Nama;
                }
            }
            return "-";
        }

        // Mengubah jumlah menit menjadi teks "XX jam YY menit" (dua digit)
        public static string FormatDurasi(int totalMenit)
        {
            int jam = totalMenit / 60;
            int menit = totalMenit % 60;
            return string.Format("{0:00} jam {1:00} menit", jam, menit);
        }

        // Teks status terakhir untuk ditampilkan di grid.
        // Belum ada riwayat = "Sesuai Jadwal". Delay ditulis lengkap dengan durasinya.
        public static string TeksStatusTerakhir(int jadwalId)
        {
            PerubahanStatusJadwal terakhir = CariPerubahanStatusTerakhir(jadwalId);
            if (terakhir == null)
            {
                return "Sesuai Jadwal";
            }

            string nama = NamaStatus(terakhir.StatusPenerbanganId);
            if (nama == "Delay")
            {
                return "Delay (selama \u00b1" + FormatDurasi(terakhir.PerkiraanDelayMenit) + ")";
            }
            return nama;
        }

        // Mencari akun berdasarkan username dan password.
        // Username tidak peka huruf besar/kecil, password peka.
        // Kalau tidak ketemu, hasilnya null.
        public static Akun CariAkun(string username, string password)
        {
            for (int i = 0; i < daftarAkun.Count; i++)
            {
                if (daftarAkun[i].Username.ToLower() == username.ToLower()
                    && daftarAkun[i].Password == password)
                {
                    return daftarAkun[i];
                }
            }
            return null;
        }

        // Mengecek apakah username sudah dipakai akun lain
        // (tidak peka huruf besar/kecil)
        public static bool UsernameSudahDipakai(string username)
        {
            for (int i = 0; i < daftarAkun.Count; i++)
            {
                if (daftarAkun[i].Username.ToLower() == username.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        // Menambah akun baru ke daftar
        public static void TambahAkun(Akun akun)
        {
            daftarAkun.Add(akun);
        }
    }
}
