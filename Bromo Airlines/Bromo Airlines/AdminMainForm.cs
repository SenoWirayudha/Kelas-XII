using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    public partial class AdminMainForm : Form
    {
        // Penanda: apakah form ini ditutup lewat tombol Logout.
        // Kalau iya, aplikasi TIDAK boleh ikut ditutup.
        private bool logoutBerhasil = false;

        // Penanda: apakah menu sedang mengecil (hanya ikon)
        private bool menuKecil = false;

        // Item menu dibuat lewat code (bukan designer):
        // index 0-4 = menu utama, index 5 = logout
        private Panel[] daftarItem;
        private PictureBox[] daftarIkon;
        private Label[] daftarTeks;

        // Gambar ikon tiap item (versi normal dan versi aktif)
        private Image[] gambarNormal;
        private Image[] gambarAktif;
        private Color[] warnaTeksNormal;
        private Color[] warnaTeksAktif;

        // Warna tampilan
        private Color warnaPudar = Color.FromArgb(145, 145, 145);   // teks tidak aktif
        private Color warnaGelap = Color.FromArgb(33, 33, 33);      // teks aktif
        private Color warnaMerah = Color.FromArgb(198, 40, 40);     // logout
        private Color warnaHover = Color.FromArgb(245, 245, 245);   // sangat muda

        public AdminMainForm()
        {
            InitializeComponent();

            // Ikon hamburger (karakter U+E700 dari font Segoe MDL2 Assets)
            btnMenu.Text = ((char)0xE700).ToString();

            // Ikon jendela memakai favicon Bromo Airlines (resource)
            this.Icon = Properties.Resources.favicon;

            SusunItemMenu();
        }

        // Membuat semua item menu di panel kiri
        private void SusunItemMenu()
        {
            string[] teksMenu = new string[5];
            teksMenu[0] = "Master Bandara";
            teksMenu[1] = "Master Maskapai";
            teksMenu[2] = "Master Jadwal Penerbangan";
            teksMenu[3] = "Master Kode Promo";
            teksMenu[4] = "Ubah Status Penerbangan";

            // Gambar ikon tiap menu (resource gambar, dua versi)
            gambarNormal = new Image[6];
            gambarAktif = new Image[6];
            gambarNormal[0] = Properties.Resources.ic_bandara;
            gambarAktif[0] = Properties.Resources.ic_bandara_aktif;
            gambarNormal[1] = Properties.Resources.ic_maskapai;
            gambarAktif[1] = Properties.Resources.ic_maskapai_aktif;
            gambarNormal[2] = Properties.Resources.ic_jadwal;
            gambarAktif[2] = Properties.Resources.ic_jadwal_aktif;
            gambarNormal[3] = Properties.Resources.ic_kode_promo;
            gambarAktif[3] = Properties.Resources.ic_kode_promo_aktif;
            gambarNormal[4] = Properties.Resources.ic_ubah_status;
            gambarAktif[4] = Properties.Resources.ic_ubah_status_aktif;
            // Logout hanya satu versi (merah)
            gambarNormal[5] = Properties.Resources.ic_logout;
            gambarAktif[5] = Properties.Resources.ic_logout;

            // Warna teks tiap item
            warnaTeksNormal = new Color[6];
            warnaTeksAktif = new Color[6];
            for (int i = 0; i < 5; i++)
            {
                warnaTeksNormal[i] = warnaPudar;
                warnaTeksAktif[i] = warnaGelap;
            }
            warnaTeksNormal[5] = warnaMerah;
            warnaTeksAktif[5] = warnaMerah;

            daftarItem = new Panel[6];
            daftarIkon = new PictureBox[6];
            daftarTeks = new Label[6];

            // Buat 5 menu utama
            for (int i = 0; i < 5; i++)
            {
                BuatItemMenu(i, teksMenu[i]);
            }

            // Tambahkan ke panelMenu dengan urutan terbalik,
            // supaya posisi atas ke bawah: menu 0, 1, 2, 3, 4
            for (int i = 4; i >= 0; i--)
            {
                panelMenu.Controls.Add(daftarItem[i]);
            }

            // Buat item Logout (paling bawah, ikon dan teks merah)
            BuatItemMenu(5, "Logout");
            daftarItem[5].Dock = DockStyle.Bottom;
            panelMenu.Controls.Add(daftarItem[5]);

            // Tambahkan ulang panelGaris supaya diproses paling awal
            // saat docking, sehingga garis membentang penuh dari atas ke bawah
            panelMenu.Controls.Add(panelGaris);

            // Saat pertama dibuka belum ada menu aktif
            TandaiMenuAktif(-1);
        }

        // Membuat satu item menu: ikon di kiri (posisi tetap) + teks di kanannya
        private void BuatItemMenu(int index, string teks)
        {
            Panel item = new Panel();
            item.Dock = DockStyle.Top;
            item.Height = 50;
            item.BackColor = Color.White;

            // Ikon: posisi tetap, tidak bergantung lebar sidebar
            PictureBox pic = new PictureBox();
            pic.Image = gambarNormal[index];
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(18, 13);
            pic.Size = new Size(24, 24);
            pic.BackColor = Color.Transparent;

            // Teks: mulai di kanan ikon, ikut melebar/mengecil
            Label lblTeks = new Label();
            lblTeks.Text = teks;
            lblTeks.Font = new Font("Segoe UI", 9F);
            lblTeks.ForeColor = warnaTeksNormal[index];
            lblTeks.TextAlign = ContentAlignment.MiddleLeft;
            lblTeks.Location = new Point(50, 0);
            lblTeks.Size = new Size(190, 50);
            lblTeks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                | AnchorStyles.Left | AnchorStyles.Right;
            lblTeks.BackColor = Color.Transparent;

            // lblTeks ditambahkan dulu supaya ikon berada di atasnya
            item.Controls.Add(lblTeks);
            item.Controls.Add(pic);

            daftarItem[index] = item;
            daftarIkon[index] = pic;
            daftarTeks[index] = lblTeks;

            PasangEventItem(item, index);
            PasangEventItem(pic, index);
            PasangEventItem(lblTeks, index);
        }

        // Memasang event klik dan hover pada satu kontrol
        private void PasangEventItem(Control kontrol, int index)
        {
            kontrol.Tag = index;
            kontrol.Click += Item_Click;
            kontrol.MouseEnter += Item_MouseEnter;
            kontrol.MouseLeave += Item_MouseLeave;
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);
            daftarItem[index].BackColor = warnaHover;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);
            daftarItem[index].BackColor = Color.White;
        }

        // Klik salah satu item menu
        private void Item_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Control)sender).Tag);

            // Klik Logout
            if (index == 5)
            {
                TanyaLogout();
                return;
            }

            if (index == 0)
            {
                MuatFormKeKonten(new FormMasterBandara(), 0);
            }
            else if (index == 1)
            {
                MuatFormKeKonten(new FormMasterMaskapai(), 1);
            }
            else if (index == 2)
            {
                MuatFormKeKonten(new FormMasterJadwal(), 2);
            }
            else if (index == 3)
            {
                MuatFormKeKonten(new FormMasterKodePromo(), 3);
            }
            else if (index == 4)
            {
                MuatFormKeKonten(new FormUbahStatus(), 4);
            }
        }

        // Menandai menu yang sedang aktif:
        // ikon berganti ke versi terisi hitam, teks jadi lebih gelap
        private void TandaiMenuAktif(int index)
        {
            for (int i = 0; i < daftarItem.Length; i++)
            {
                if (i == index)
                {
                    daftarIkon[i].Image = gambarAktif[i];
                    daftarTeks[i].ForeColor = warnaTeksAktif[i];
                }
                else
                {
                    daftarIkon[i].Image = gambarNormal[i];
                    daftarTeks[i].ForeColor = warnaTeksNormal[i];
                }
            }
        }

        // Tombol hamburger: perbesar / perkecil panel menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuKecil = !menuKecil;

            if (menuKecil == true)
            {
                panelMenu.Width = 60;
                for (int i = 0; i < daftarTeks.Length; i++)
                {
                    daftarTeks[i].Visible = false;
                }
            }
            else
            {
                panelMenu.Width = 250;
                for (int i = 0; i < daftarTeks.Length; i++)
                {
                    daftarTeks[i].Visible = true;
                }
            }
        }

        // Memuat sebuah form ke dalam panel konten (bukan jendela baru).
        // Judul di header tetap "Dashboard" untuk semua halaman.
        private void MuatFormKeKonten(Form form, int indexMenu)
        {
            // Kosongkan dulu isi panel konten
            panelKonten.Controls.Clear();

            // Siapkan form supaya tampil di dalam panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Tambahkan form ke panel, lalu tampilkan
            panelKonten.Controls.Add(form);
            form.Show();

            // Tandai menu yang sedang aktif
            TandaiMenuAktif(indexMenu);
        }

        // Tombol Logout: konfirmasi, lalu kembali ke Login Form
        private void TanyaLogout()
        {
            DialogResult jawaban = MessageBox.Show(
                "Yakin ingin logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (jawaban == DialogResult.Yes)
            {
                logoutBerhasil = true;

                // Kosongkan sesi login
                SesiLogin.idAkun = 0;
                SesiLogin.username = "";
                SesiLogin.nama = "";
                SesiLogin.merupakanAdmin = false;

                // Tampilkan Login Form (baru, jadi kolomnya kosong)
                LoginForm formLogin = new LoginForm();
                formLogin.Show();

                // Tutup Admin Main Form tanpa menutup aplikasi
                this.Close();
            }
        }

        // Kalau form ditutup lewat tombol X (bukan Logout), tutup seluruh aplikasi
        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && logoutBerhasil == false)
            {
                Application.Exit();
            }
        }
    }
}
