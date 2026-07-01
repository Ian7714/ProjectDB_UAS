using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace Class_CookShares
{
    public class CustomPrint
    {
        Font tipeFont;
        StreamReader namaFile;
        float kiri, kanan, atas, bawah;

        public CustomPrint(Font tipeFont, string namaFile, float atas, float bawah, float kiri, float kanan)
        {
            TipeFont = tipeFont;
            NamaFile = new StreamReader(namaFile);
            Kiri = kiri;
            Kanan = kanan;
            Atas = atas;
            Bawah = bawah;
        }

        public Font TipeFont { get => tipeFont; set => tipeFont = value; }
        public StreamReader NamaFile { get => namaFile; set => namaFile = value; }
        public float Kiri { get => kiri; set => kiri = value; }
        public float Kanan { get => kanan; set => kanan = value; }
        public float Atas { get => atas; set => atas = value; }
        public float Bawah { get => bawah; set => bawah = value; }

        private void Cetak(object sender, PrintPageEventArgs e)
        {
            float tinggiFont = TipeFont.GetHeight(e.Graphics);
            float y;
            float x = Kiri;
            int jumBarisSaatIni = 0;
            int maxBarisDalamHalaman = (int)((e.MarginBounds.Height - Atas - Bawah) / tinggiFont);

            //Ambil 1 baris dari file teks
            String textCetak = NamaFile.ReadLine();

            while (jumBarisSaatIni < maxBarisDalamHalaman && textCetak != null)
            {
                y = Atas + (jumBarisSaatIni * tinggiFont);

                //menulis memory
                e.Graphics.DrawString(textCetak, TipeFont, Brushes.Black, x, y);

                jumBarisSaatIni++;

                //mengambil 1 baris berikutnya
                textCetak = NamaFile.ReadLine();
            }

            if (textCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        public void KirimKePrinter()
        {
            //proses mencetak ke printer    
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print To PDF";

            //Menulis ke memory untuk tiap halaman
            p.PrintPage += new PrintPageEventHandler(Cetak);
            p.Print();

            NamaFile.Close();
        }
    }
}
