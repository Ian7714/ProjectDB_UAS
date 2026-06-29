using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    // Class DaftarRating digunakan untuk merepresentasikan
    // data pada tabel rating di database
    public class DaftarRating
    {
        // Atribut untuk menyimpan data rating
        int rating_id;
        int skor_rating;
        int user_user_id;
        int resep_resep_id;

        // Constructor default
        // Akan dijalankan ketika objek dibuat tanpa parameter
        public DaftarRating()
        {
            Rating_id = 0;
            Skor_rating = 0;
            User_user_id = 0;
            Resep_resep_id = 0;
        }

        // Constructor berparameter
        // Digunakan untuk langsung mengisi data objek
        public DaftarRating(int rating_id, int skor_rating, int user_user_id, int resep_resep_id)
        {
            this.Rating_id = rating_id;
            this.Skor_rating = skor_rating;
            this.User_user_id = user_user_id;
            this.Resep_resep_id = resep_resep_id;
        }

        // Property untuk mengakses atribut secara aman
        public int Rating_id { get => rating_id; set => rating_id = value; }
        public int Skor_rating { get => skor_rating; set => skor_rating = value; }
        public int User_user_id { get => user_user_id; set => user_user_id = value; }
        public int Resep_resep_id { get => resep_resep_id; set => resep_resep_id = value; }

        public static List<DaftarRating> BacaData(string filter = "", string nilai = "")
        {
            List<DaftarRating> listData = new List<DaftarRating>();

            string perintah = "SELECT * FROM rating";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM rating";
            }
            else if (filter == "rating_id")
            {
                perintah = "SELECT * FROM rating WHERE rating_id LIKE '%" + nilai + "%'";
            }
            else if (filter == "skor_rating")
            {
                perintah = "SELECT * FROM rating WHERE skor_rating LIKE '%" + nilai + "%'";
            }

            // Menjalankan query SELECT ke database
            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            // Membaca setiap baris data hasil query
            while (reader.Read())
            {
                int id = int.Parse(reader["rating_id"].ToString());
                int skor = int.Parse(reader["skor_rating"].ToString());
                int userId = int.Parse(reader["User_user_id"].ToString());
                int resepId = int.Parse(reader["Resep_resep_id"].ToString());

                // Membuat objek DaftarRating
                DaftarRating data = new DaftarRating(id, skor, userId, resepId);

                // Menambahkan objek ke dalam list
                listData.Add(data);
            }

            // Mengembalikan list data rating
            return listData;
        }
    }
}
