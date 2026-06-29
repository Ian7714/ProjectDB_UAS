using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_CookShares
{
    public class Kategori
    {
        int kategori_id;
        string nama_kategori;

        public Kategori()
        {
            Kategori_id = 0;
            Nama_kategori = "Siuu";
        }

        public Kategori(int kategori_id, string nama_kategori)
        {
            Kategori_id = kategori_id;
            Nama_kategori = nama_kategori;
        }

        public int Kategori_id { get => kategori_id; set => kategori_id = value; }
        public string Nama_kategori { get => nama_kategori; set => nama_kategori = value; }

        public static List<Kategori> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Kategori> listData = new List<Kategori>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM Kategori";

            if(filter == "" || nilai =="")
            {
                perintah = "SELECT * FROM Kategori";
            }
            else if (filter == "nama_kategori")
            {
                perintah = "SELECT * FROM Kategori WHERE nama_kategori LIKE '%" + nilai + "%'";
            }
            else if (filter == "kategori_id")
            {
                bool isInteger = int.TryParse(nilai, out _);
                if(isInteger)
                {
                    perintah = "SELECT * FROM Kategori WHERE kategori_id = " + nilai;
                }
                else
                {
                    nilai = "";
                }
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                //ambiul isi data reader, lalu simpan dalam variabel tampung
                int tampungKode = int.Parse(reader.GetValue(0).ToString());
                string tampungNama = reader.GetValue(1).ToString();

                //buat objek kategori untuk menampung data dari variabel tampung
                Kategori tampung = new Kategori(tampungKode, tampungNama);

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }

            return listData;
        }
    }
}
