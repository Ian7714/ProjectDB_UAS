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
        User user;
        Resep resep;

        public Post()
        {
            Id = 0;
            Teks = "";
            TglPembuatan = DateTime.Now;
            JenisPost = "biasa";
            User = new User();
            Resep = new Resep();
        }

        public Post(int id, string teks, DateTime tglPembuatan, string jenisPost, User user, Resep resep)
        {
            Id = id;
            Teks = teks;
            TglPembuatan = tglPembuatan;
            JenisPost = jenisPost;
            User = user;
            Resep = resep;
        }

        public int Id { get => id; set => id = value; }
        public string Teks { get => teks; set => teks = value; }
        public DateTime TglPembuatan { get => tglPembuatan; set => tglPembuatan = value; }
        public string JenisPost { get => jenisPost; set => jenisPost = value; }
        public User User { get => user; set => user = value; }
        public Resep Resep { get => resep; set => resep = value; }

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
                tampung.User.Nama = reader.GetValue(4).ToString();
                tampung.Resep.Nama = reader.GetValue(5).ToString();

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }

        public static void TambahData(Post p)
        {
            string perintah = "INSERT INTO `postingan` (`postingan_id`, `teks`, `tanggal_pembuatan`, `jenis_postingan`, `Pengguna_pengguna_id`, `Resep_resep_id`) " +
                "VALUES ('" + p.Id + "', '" + p.Teks + "', '" + p.TglPembuatan + "', '" + p.JenisPost + "', '" + p.User.Id + "', '" + p.Resep.Id + "')";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
        
        public static void UbahData(Post p, string filter)
        {
            string perintah = "";
            if (filter == "resep")
            {
                perintah = "UPDATE `postingan` SET `teks` = '" + p.Teks + "', `tanggal_pembuatan` = '" + DateTime.Now + "', `jenis_postingan` = 'resep', `Pengguna_pengguna_id` = '" + p.User.Id + "', `Resep_resep_id` = '" + p.Resep.Id + "' WHERE (`postingan_id` = '" + p.Id + "')";

            }
            else if (filter == "biasa")
            {
                perintah = "UPDATE `postingan` SET `teks` = '" + p.Teks + "', `tanggal_pembuatan` = '" + DateTime.Now + "', `jenis_postingan` = 'biasa', `Pengguna_pengguna_id` = '" + p.User.Id + "', `Resep_resep_id` = '" + null + "' WHERE (`postingan_id` = '" + p.Id + "')";

            }
            else
            {
                throw new Exception("jenis post tidak ditemukan");
            }

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void HapusData(Post p)
        {
            string perintah = "DELETE FROM `postingan` WHERE (`postingan_id` = '" + p.Id + "')";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
    }
}
