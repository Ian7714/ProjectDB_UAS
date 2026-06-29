using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class DaftarRecook
    {
        int recook_id;
        string hasil;
        int user_user_id;
        int resep_resep_id;

        public DaftarRecook()
        {
            Recook_id = 0;
            Hasil = "";
            User_user_id = 0;
            Resep_resep_id = 0;
        }

        public DaftarRecook(int recook_id, string hasil, int user_user_id, int resep_resep_id)
        {
            this.Recook_id = recook_id;
            this.Hasil = hasil;
            this.User_user_id = user_user_id;
            this.Resep_resep_id = resep_resep_id;
        }

        public int Recook_id { get => recook_id; set => recook_id = value; }
        public string Hasil { get => hasil; set => hasil = value; }
        public int User_user_id { get => user_user_id; set => user_user_id = value; }
        public int Resep_resep_id { get => resep_resep_id; set => resep_resep_id = value; }


        // Method untuk membaca data dari tabel recook
        public static List<DaftarRecook> BacaData(string filter = "", string nilai = "")
        {
            List<DaftarRecook> listData = new List<DaftarRecook>();

            string perintah = "SELECT * FROM recook";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM recook";
            }
            else if (filter == "recook_id")
            {
                perintah = "SELECT * FROM recook WHERE recook_id LIKE '%" + nilai + "%'";
            }
            else if (filter == "hasil")
            {
                perintah = "SELECT * FROM recook WHERE hasil LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                int id = int.Parse(reader["recook_id"].ToString());
                string hasil = reader["hasil"].ToString();
                int userId = int.Parse(reader["User_user_id"].ToString());
                int resepId = int.Parse(reader["Resep_resep_id"].ToString());

                DaftarRecook data = new DaftarRecook(
                    id,
                    hasil,
                    userId,
                    resepId
                );

                listData.Add(data);
            }

            return listData;
        }
    }
}

