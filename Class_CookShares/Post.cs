using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Post
    {
        int id;
        string teks;
        DateTime tglPembuatan;
        string jenisPost;

        public Post()
        {
            Id = 0;
            Teks = "";
            TglPembuatan = DateTime.Now;
            JenisPost = "biasa";
        }

        public Post(int id, string teks, DateTime tglPembuatan, string jenisPost)
        {
            Id = id;
            Teks = teks;
            TglPembuatan = tglPembuatan;
            JenisPost = jenisPost;
        }

        public int Id { get => id; set => id = value; }
        public string Teks { get => teks; set => teks = value; }
        public DateTime TglPembuatan { get => tglPembuatan; set => tglPembuatan = value; }
        public string JenisPost { get => jenisPost; set => jenisPost = value; }

        public static List<Post> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Post> listData = new List<Post>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM postingan";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM postingan";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                //buat objek
                Post tampung = new Post();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Teks = reader.GetValue(1).ToString();
                tampung.TglPembuatan = DateTime.Parse(reader.GetValue(2).ToString());
                tampung.JenisPost = reader.GetValue(3).ToString();

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
    }
}
