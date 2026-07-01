using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class DaftarRivew
    {
        int id;
        string isiReview;
        DateTime tglReview;
        Resep resepReview;
        User userReview;

        public DaftarRivew()
        {
            Id = 0;
            IsiReview = "Siuu";
            TglReview = DateTime.Now;
            ResepReview = new Resep();
            UserReview = new User();
        }

        public DaftarRivew(int id, string isiReview, DateTime tglReview, Resep resepReview, User userReview)
        {
            Id = id;
            IsiReview = isiReview;
            TglReview = tglReview;
            ResepReview = resepReview;
            UserReview = userReview;
        }

        public int Id { get => id; set => id = value; }
        public string IsiReview { get => isiReview; set => isiReview = value; }
        public DateTime TglReview { get => tglReview; set => tglReview = value; }
        public Resep ResepReview { get => resepReview; set => resepReview = value; }
        public User UserReview { get => userReview; set => userReview = value; }


        // Method membaca data review dari database
        public static List<DaftarRivew> BacaData(string filter = "", string nilai = "")
        {
            List<DaftarRivew> listData = new List<DaftarRivew>();

            string perintah = "SELECT * FROM ulasan";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM ulasan";
            }
            else if (filter == "review_id")
            {
                perintah = "SELECT * FROM ulasan WHERE ulasan_id = " + nilai;
            }
            else if (filter == "isi_review")
            {
                perintah = "SELECT * FROM ulasan WHERE isi_ulasan LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                DaftarRivew tampung = new DaftarRivew();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.IsiReview = reader.GetValue(1).ToString();
                tampung.TglReview = DateTime.Parse(reader.GetValue(2).ToString());
                tampung.ResepReview.Nama = reader.GetValue(3).ToString();
                tampung.userReview.Nama = reader.GetValue(4).ToString();

                listData.Add(tampung);
            }

            return listData;
        }
    }
}
