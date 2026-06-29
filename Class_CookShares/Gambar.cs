using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_CookShares
{
    public class Gambar
    {
        #region FIELD
        int id;
        string url;
        int urutan;
        #endregion

        #region CONSTRUCTOR
        public Gambar()
        {
            Id = 0;
            Url = "https://www.mancity.com/meta/media/kppnc3ji/team-lifting-trophy.png?width=976";
            Urutan = 0;
        }

        public Gambar(int id, string url, int urutan)
        {
            Id = id;
            Url = url;
            Urutan = urutan;
        }
        #endregion

        #region PROPERTY
        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public int Urutan { get => urutan; set => urutan = value; }
        #endregion

        #region METHOD
        public static List<Gambar> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Gambar> listData = new List<Gambar>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM gambar";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM gambar";
            }
           
            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                //buat objek
                Gambar tampung = new Gambar();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Url = reader.GetValue(1).ToString();
                tampung.Urutan = int.Parse(reader.GetValue(2).ToString());

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
        #endregion
    }
}
