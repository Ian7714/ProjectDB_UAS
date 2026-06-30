using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public Resep()
        {
            Id = 0;
            Nama = "Siuu Goreng";
            LangkahMemasak = "diGoreng";
            WaktuMemasak = 0;
            JumlahSajian = 0;
            TingkatKesulitan = "mudah";
            VersiResep = "";
        }

        public Resep(int id, string nama, string langkahMemasak, int waktuMemasak, int jumlahSajian, string tingkatKesulitan, string versiResep)
        {
            Id = id;
            Nama = nama;
            LangkahMemasak = langkahMemasak;
            WaktuMemasak = waktuMemasak;
            JumlahSajian = jumlahSajian;
            TingkatKesulitan = tingkatKesulitan;
            VersiResep = versiResep;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string LangkahMemasak { get => langkahMemasak; set => langkahMemasak = value; }
        public int WaktuMemasak { get => waktuMemasak; set => waktuMemasak = value; }
        public int JumlahSajian { get => jumlahSajian; set => jumlahSajian = value; }
        public string TingkatKesulitan { get => tingkatKesulitan; set => tingkatKesulitan = value; }
        public string VersiResep { get => versiResep; set => versiResep = value; }


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

        public override string ToString()
        {
            return Nama;
        }
    }
}
