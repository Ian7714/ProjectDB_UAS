using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Interaksi
    {
        int id;
        string tipe;
        DateTime tglInteraksi;
        string teksKomentar;

        public Interaksi()
        {
            Id = 0;
            Tipe = "simpan";
            TglInteraksi = DateTime.Now;
            TeksKomentar = "";
        }

        public Interaksi(int id, string tipe, DateTime tglInteraksi, string teksKomentar = "")
        {
            Id = id;
            Tipe = tipe;
            TglInteraksi = tglInteraksi;
            TeksKomentar = teksKomentar;
        }

        public int Id { get => id; set => id = value; }
        public string Tipe { get => tipe; set => tipe = value; }
        public DateTime TglInteraksi { get => tglInteraksi; set => tglInteraksi = value; }
        public string TeksKomentar { get => teksKomentar; set => teksKomentar = value; }

        public static List<Interaksi> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Interaksi> listData = new List<Interaksi>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM interaksi";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM interaksi";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                //buat objek
                Interaksi tampung = new Interaksi();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Tipe = reader.GetValue(1).ToString();
                tampung.TglInteraksi = DateTime.Parse(reader.GetValue(2).ToString()) ;
                tampung.TeksKomentar = reader.GetValue(3).ToString();

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
    }
}
