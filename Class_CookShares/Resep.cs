using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Resep
    {
        int id;
        string nama;
        string langkahMemasak;
        int waktuMemasak;
        int jumlahSajian;
        string tingkatKesulitan;
        string versiResep;
        List<ResepBahan> listResepBahan;

        public Resep()
        {
            Id = 0;
            Nama = "Siuu Goreng";
            LangkahMemasak = "diGoreng";
            WaktuMemasak = 0;
            JumlahSajian = 0;
            TingkatKesulitan = "mudah";
            VersiResep = "";
            ListResepBahan = new List<ResepBahan>();
        }

        public Resep(int id, string nama, string langkahMemasak, int waktuMemasak, int jumlahSajian, string tingkatKesulitan, string versiResep, List<ResepBahan> listResepBahan)
        {
            Id = id;
            Nama = nama;
            LangkahMemasak = langkahMemasak;
            WaktuMemasak = waktuMemasak;
            JumlahSajian = jumlahSajian;
            TingkatKesulitan = tingkatKesulitan;
            VersiResep = versiResep;
            ListResepBahan = listResepBahan;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string LangkahMemasak { get => langkahMemasak; set => langkahMemasak = value; }
        public int WaktuMemasak { get => waktuMemasak; set => waktuMemasak = value; }
        public int JumlahSajian { get => jumlahSajian; set => jumlahSajian = value; }
        public string TingkatKesulitan { get => tingkatKesulitan; set => tingkatKesulitan = value; }
        public string VersiResep { get => versiResep; set => versiResep = value; }
        public List<ResepBahan> ListResepBahan { get => listResepBahan; set => listResepBahan = value; }


        // Method membaca data dari database
        public static List<Resep> BacaData(string filter = "", string nilai = "")
        {
            List<Resep> listData = new List<Resep>();

            string perintah = "SELECT * FROM resep";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM resep";
            }
            else if (filter == "resep_id")
            {
                perintah = "SELECT * FROM resep WHERE resep_id = " + nilai;
            }
            else if (filter == "nama_resep")
            {
                perintah = "SELECT * FROM resep WHERE nama_resep LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                Resep tampung = new Resep();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Nama = reader.GetValue(1).ToString();
                tampung.langkahMemasak = reader.GetValue(2).ToString();
                tampung.WaktuMemasak = int.Parse(reader.GetValue(3).ToString());
                tampung.JumlahSajian = int.Parse(reader.GetValue(4).ToString());
                tampung.TingkatKesulitan = reader.GetValue(5).ToString();
                tampung.VersiResep = reader.GetValue(6).ToString();

                listData.Add(tampung);
            }

            return listData;
        }

        public static void BacaDataBahan(Resep r)
        {
            string perintah = "SELECT * FROM resep_bahan WHERE Resep_resep_id =" + r.Id;

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                ResepBahan tampung = new ResepBahan();
                tampung.Resep = Resep.BacaData("resep_id", reader.GetValue(0).ToString())[0];
                tampung.Bahan = Bahan.BacaData("bahan_id", reader.GetValue(1).ToString())[0];
                tampung.Jumlah = float.Parse(reader.GetValue(2).ToString());

                r.ListResepBahan.Add(tampung);
            }
        }

        public static void TambahData(Resep r)
        {
            //1. Insert header nota ke tabel notajual
            string perintah = "INSERT INTO `resep` (`resep_id`, `nama_resep`, `langkah_memasak`, `waktu_memasak`, `jumlah_sajian`, `tingkat_kesulitan`, `versi_resep`) " +
                "VALUES ('" + r.Id + "', '" + r.Nama + "', '" + r.LangkahMemasak + "', '" + r.WaktuMemasak + "', '" + r.JumlahSajian + "', '" + r.TingkatKesulitan + "', '" + r.VersiResep + "');";

            Koneksi.JalankanPerintahNonQuery(perintah);

            for (int i = 0; i < r.ListResepBahan.Count; i++)
            {
                perintah = "INSERT INTO `resep_bahan` (`Bahan_bahan_id`, `Resep_resep_id`, `jumlah`) VALUES ('" + r.ListResepBahan[i].Bahan.Id + "', '" + r.ListResepBahan[i].Resep.Id + "', '" + r.ListResepBahan[i].Jumlah + "')";

                Koneksi.JalankanPerintahNonQuery(perintah);
            }
        }

        public static void Cetak(string pNamaFile, Font pTipeFont)
        {
            List<Resep> listhasil = Resep.BacaData();
            int n = listhasil.Count - 1;

            StreamWriter fileCetak = new StreamWriter(pNamaFile);
            fileCetak.WriteLine("CookShare");
            fileCetak.WriteLine("------------------------------------------------------");
            fileCetak.WriteLine("");

            fileCetak.WriteLine(listhasil[n].Nama + listhasil[n].VersiResep);
            fileCetak.WriteLine("Waktu Memasak : " + listhasil[n].WaktuMemasak + " menit");
            fileCetak.WriteLine("Jumlah Sajian : " + listhasil[n].JumlahSajian);
            fileCetak.WriteLine("Tingkat Kesulitan : " + listhasil[n].TingkatKesulitan);
            Resep.BacaDataBahan(listhasil[n]);

            fileCetak.WriteLine("------------------------------------------------------");
            for (int j = 0; j < listhasil[n].ListResepBahan.Count; j++)
            {
                fileCetak.WriteLine(listhasil[n].ListResepBahan[j].Bahan.Nama + " " + listhasil[n].ListResepBahan[j].Jumlah);
            }

            fileCetak.WriteLine();
            fileCetak.WriteLine("------------------------------------------------------");
            fileCetak.WriteLine("Tanggal Cetak = " + DateTime.Now.ToString("dd/MM/yyyy"));
            fileCetak.Close();

            CustomPrint p = new CustomPrint(pTipeFont, pNamaFile, 100, 50, 50, 50);
            p.KirimKePrinter();
        }

        public override string ToString()
        {
            return Nama;
        }
    }
}
