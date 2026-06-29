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
        int review_id;
        string isi_review;
        int user_user_id;
        int resep_resep_id;

        public DaftarRivew()
        {
           Review_id = 0;
            Isi_review = "";
            User_user_id = 0;
            Resep_resep_id = 0;
        }

        public DaftarRivew(int review_id, string isi_review, int user_user_id, int resep_resep_id)
        {
            this.Review_id = review_id;
            this.Isi_review = isi_review;
            this.User_user_id = user_user_id;
            this.Resep_resep_id = resep_resep_id;
        }

        public int Review_id { get => review_id; set => review_id = value; }
        public string Isi_review { get => isi_review; set => isi_review = value; }
        public int User_user_id { get => user_user_id; set => user_user_id = value; }
        public int Resep_resep_id { get => resep_resep_id; set => resep_resep_id = value; }


        // Method membaca data review dari database
        public static List<DaftarRivew> BacaData(string filter = "", string nilai = "")
        {
            List<DaftarRivew> listData = new List<DaftarRivew>();

            string perintah = "SELECT * FROM review";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM review";
            }
            else if (filter == "review_id")
            {
                perintah = "SELECT * FROM review WHERE review_id = " + nilai;
            }
            else if (filter == "isi_review")
            {
                perintah = "SELECT * FROM review WHERE isi_review LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                int id = int.Parse(reader["review_id"].ToString());
                string isi = reader["isi_review"].ToString();
                int userId = int.Parse(reader["User_user_id"].ToString());
                int resepId = int.Parse(reader["Resep_resep_id"].ToString());

                DaftarRivew data = new DaftarRivew(
                    id,
                    isi,
                    userId,
                    resepId
                );

                listData.Add(data);
            }

            return listData;
        }
    }
}
