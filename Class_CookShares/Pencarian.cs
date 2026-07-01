using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Pencarian
    {
        int id;
        string kataKunci;
        DateTime tglPencarian;
        User user;

        public Pencarian()
        {
            Id = 0;
            KataKunci = "";
            TglPencarian = DateTime.Now;
            User = new User();
        }

        public Pencarian(int id, string kataKunci, DateTime tglPencarian, User user)
        {
            Id = id;
            KataKunci = kataKunci;
            TglPencarian = tglPencarian;
            User = user;
        }

        public int Id { get => id; set => id = value; }
        public string KataKunci { get => kataKunci; set => kataKunci = value; }
        public DateTime TglPencarian { get => tglPencarian; set => tglPencarian = value; }
        public User User { get => user; set => user = value; }

        public static List<Pencarian> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Pencarian> listData = new List<Pencarian>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM pencarian";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM pencarian";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                //buat objek
                Pencarian tampung = new Pencarian();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.KataKunci = reader.GetValue(1).ToString();
                tampung.TglPencarian = DateTime.Parse(reader.GetValue(2).ToString());
                tampung.User.Id = int.Parse(reader.GetValue(3).ToString());

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
        
        public static void TambahData(Pencarian pc)
        {
            string perintah = "INSERT INTO `pencarian` (`pencarian_id`, `kata_kunci`, `tanggal_pencarian`, `Pengguna_pengguna_id`) " +
                "VALUES ('" + pc.Id + "', '" + pc.KataKunci + "', '" + DateTime.Now + "', '" + pc.User.Id + "')";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }

        public static void HapusData(Pencarian pc)
        {
            string perintah = "DELETE FROM `pencarian` WHERE (`pencarian_id` = '" + pc.User.Id + "')";

            Koneksi.JalankanPerintahNonQuery(perintah);
        }
    }
}
