using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bromo_Airlines
{
    // Membuat gambar ikon sidebar memakai GDI+ (tanpa file gambar).
    // Versi normal = outline abu-abu, versi aktif = terisi hitam.
    static class GambarIkon
    {
        // Warna outline (tidak aktif)
        private static Color warnaOutline = Color.FromArgb(120, 120, 120);

        // ---------------------------------------------------------------------
        // Pin lokasi: tetesan dengan lingkaran kecil di tengah
        // ---------------------------------------------------------------------
        public static Bitmap Pin(bool terisi)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                GraphicsPath pin = BentukPin();

                if (terisi)
                {
                    g.FillPath(Brushes.Black, pin);
                    g.FillEllipse(Brushes.White, 9.5f, 6.5f, 5f, 5f);
                }
                else
                {
                    using (Pen pen = new Pen(warnaOutline, 1.7f))
                    {
                        g.DrawPath(pen, pin);
                        g.DrawEllipse(pen, 9.5f, 6.5f, 5f, 5f);
                    }
                }
            }
            return bmp;
        }

        // Bentuk pin: busur lingkaran di atas + dua garis menuju ujung bawah
        private static GraphicsPath BentukPin()
        {
            GraphicsPath path = new GraphicsPath();
            // Busur dari kiri-bawah, melewati atas, ke kanan-bawah
            path.AddArc(5f, 2f, 14f, 14f, 135f, 270f);
            path.AddLine(16.95f, 13.95f, 12f, 22f);
            path.AddLine(12f, 22f, 7.05f, 13.95f);
            path.CloseFigure();
            return path;
        }

        // ---------------------------------------------------------------------
        // Pesawat lepas landas: pesawat diputar + garis landasan di bawah
        // ---------------------------------------------------------------------
        public static Bitmap Pesawat(bool terisi)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Color warna = terisi ? Color.Black : warnaOutline;

                // Garis landasan di bawah
                using (Pen penLandasan = new Pen(warna, terisi ? 2.2f : 1.6f))
                {
                    g.DrawLine(penLandasan, 2f, 21f, 13f, 21f);
                }

                // Pesawat dilihat dari atas, menghadap ke atas
                GraphicsPath pesawat = new GraphicsPath();
                pesawat.AddPolygon(new PointF[]
                {
                    new PointF(12f, 1f),
                    new PointF(13.2f, 7f),
                    new PointF(20f, 12f),
                    new PointF(20f, 14f),
                    new PointF(13.2f, 11.5f),
                    new PointF(13.2f, 17f),
                    new PointF(15.5f, 19.5f),
                    new PointF(15.5f, 21f),
                    new PointF(12f, 19.5f),
                    new PointF(8.5f, 21f),
                    new PointF(8.5f, 19.5f),
                    new PointF(10.8f, 17f),
                    new PointF(10.8f, 11.5f),
                    new PointF(4f, 14f),
                    new PointF(4f, 12f),
                    new PointF(10.8f, 7f)
                });

                // Putar pesawat supaya terlihat sedang lepas landas
                g.TranslateTransform(12f, 11f);
                g.RotateTransform(-40f);
                g.ScaleTransform(0.78f, 0.78f);
                g.TranslateTransform(-12f, -11f);

                if (terisi)
                {
                    g.FillPath(Brushes.Black, pesawat);
                }
                else
                {
                    using (Pen pen = new Pen(warnaOutline, 1.6f))
                    {
                        g.DrawPath(pen, pesawat);
                    }
                }
            }
            return bmp;
        }

        // ---------------------------------------------------------------------
        // Kalender dengan titik-titik grid di dalamnya
        // ---------------------------------------------------------------------
        public static Bitmap Kalender(bool terisi)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                GraphicsPath badan = Bulatkan(new RectangleF(3f, 5f, 18f, 16f), 2.5f);

                if (terisi)
                {
                    g.FillPath(Brushes.Black, badan);

                    // Garis pemisah bagian atas kalender
                    using (Pen putih = new Pen(Color.White, 1.2f))
                    {
                        g.DrawLine(putih, 5f, 9.5f, 19f, 9.5f);
                    }

                    // Titik-titik grid (3 kolom x 2 baris)
                    using (SolidBrush titik = new SolidBrush(Color.White))
                    {
                        float[] daftarX = { 7.5f, 12f, 16.5f };
                        float[] daftarY = { 13.5f, 17.5f };
                        for (int y = 0; y < daftarY.Length; y++)
                        {
                            for (int x = 0; x < daftarX.Length; x++)
                            {
                                g.FillEllipse(titik, daftarX[x] - 1.2f, daftarY[y] - 1.2f, 2.4f, 2.4f);
                            }
                        }
                    }
                }
                else
                {
                    using (Pen pen = new Pen(warnaOutline, 1.6f))
                    {
                        g.DrawPath(pen, badan);

                        // Dua tiang kalender di atas
                        g.DrawLine(pen, 8f, 2.5f, 8f, 6.5f);
                        g.DrawLine(pen, 16f, 2.5f, 16f, 6.5f);

                        // Garis pemisah bagian atas kalender
                        g.DrawLine(pen, 3.5f, 9.5f, 20.5f, 9.5f);
                    }

                    // Titik-titik grid
                    using (SolidBrush titik = new SolidBrush(warnaOutline))
                    {
                        float[] daftarX = { 7.5f, 12f, 16.5f };
                        float[] daftarY = { 13.5f, 17.5f };
                        for (int y = 0; y < daftarY.Length; y++)
                        {
                            for (int x = 0; x < daftarX.Length; x++)
                            {
                                g.FillEllipse(titik, daftarX[x] - 1f, daftarY[y] - 1f, 2f, 2f);
                            }
                        }
                    }
                }
            }
            return bmp;
        }

        // ---------------------------------------------------------------------
        // Kalender dengan beberapa garis teks (untuk Ubah Status)
        // ---------------------------------------------------------------------
        public static Bitmap KalenderCatatan(bool terisi)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                GraphicsPath badan = Bulatkan(new RectangleF(3f, 5f, 18f, 16f), 2.5f);

                if (terisi)
                {
                    g.FillPath(Brushes.Black, badan);

                    using (Pen putih = new Pen(Color.White, 1.2f))
                    {
                        g.DrawLine(putih, 5f, 9.5f, 19f, 9.5f);
                        g.DrawLine(putih, 7f, 13f, 17f, 13f);
                        g.DrawLine(putih, 7f, 16f, 17f, 16f);
                        g.DrawLine(putih, 7f, 19f, 14f, 19f);
                    }
                }
                else
                {
                    using (Pen pen = new Pen(warnaOutline, 1.6f))
                    {
                        g.DrawPath(pen, badan);
                        g.DrawLine(pen, 8f, 2.5f, 8f, 6.5f);
                        g.DrawLine(pen, 16f, 2.5f, 16f, 6.5f);
                        g.DrawLine(pen, 3.5f, 9.5f, 20.5f, 9.5f);
                        g.DrawLine(pen, 7f, 13f, 17f, 13f);
                        g.DrawLine(pen, 7f, 16f, 17f, 16f);
                        g.DrawLine(pen, 7f, 19f, 14f, 19f);
                    }
                }
            }
            return bmp;
        }

        // ---------------------------------------------------------------------
        // Tag / label harga dengan lubang kecil di sudut
        // ---------------------------------------------------------------------
        public static Bitmap Tag(bool terisi)
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Belah ketupat sebagai badan tag
                GraphicsPath tag = new GraphicsPath();
                tag.AddPolygon(new PointF[]
                {
                    new PointF(12f, 3f),
                    new PointF(21f, 12f),
                    new PointF(12f, 21f),
                    new PointF(3f, 12f)
                });

                if (terisi)
                {
                    g.FillPath(Brushes.Black, tag);
                    g.FillEllipse(Brushes.White, 15.2f, 6.2f, 3.6f, 3.6f);
                }
                else
                {
                    using (Pen pen = new Pen(warnaOutline, 1.7f))
                    {
                        g.DrawPath(pen, tag);
                        g.DrawEllipse(pen, 15.2f, 6.2f, 3.6f, 3.6f);
                    }
                }
            }
            return bmp;
        }

        // ---------------------------------------------------------------------
        // Logout: panah keluar dari kotak terbuka (merah, satu versi)
        // ---------------------------------------------------------------------
        public static Bitmap Keluar()
        {
            Bitmap bmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen pen = new Pen(Color.FromArgb(198, 40, 40), 1.8f))
                {
                    pen.LineJoin = LineJoin.Round;
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;

                    // Pintu / kotak yang terbuka di kanan
                    g.DrawLine(pen, 13f, 4f, 5f, 4f);
                    g.DrawLine(pen, 5f, 4f, 5f, 20f);
                    g.DrawLine(pen, 5f, 20f, 13f, 20f);

                    // Panah keluar ke kanan
                    g.DrawLine(pen, 9f, 12f, 20f, 12f);
                    g.DrawLine(pen, 16.5f, 8.5f, 20f, 12f);
                    g.DrawLine(pen, 16.5f, 15.5f, 20f, 12f);
                }
            }
            return bmp;
        }

        // Membuat persegi panjang bersudut bulat
        private static GraphicsPath Bulatkan(RectangleF rect, float radius)
        {
            float diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
