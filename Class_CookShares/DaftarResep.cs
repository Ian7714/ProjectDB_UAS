using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class DaftarResep
    {
        int resep_id;
        string nama_resep;

        public DaftarResep()
        {
           Resep_id = 0;
            Nama_resep = "";
        }

        public DaftarResep(int resep_id, string nama_resep)
        {
            this.Resep_id = resep_id;
            this.Nama_resep = nama_resep;
        }

        public int Resep_id 
        {   get => resep_id;
            set => resep_id = value;
        }
        public string Nama_resep
        {   get => nama_resep; 
            set => nama_resep = value;
        }


        // Method membaca data dari database
        public static List<DaftarResep> BacaData(string filter = "", string nilai = "")
        {
            List<DaftarResep> listData = new List<DaftarResep>();

            string perintah = "SELECT * FROM resep";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM resep";
            }
            else if (filter == "resep_id")
            {
                perintah = "SELECT * FROM resep WHERE resep_id = " + nilai;
            }
            else if (filter == "nama_resep")
            {
                perintah = "SELECT * FROM resep WHERE nama_resep LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            while (reader.Read())
            {
                int id = int.Parse(reader["resep_id"].ToString());
                string nama = reader["nama_resep"].ToString();

                DaftarResep data = new DaftarResep(id, nama);

                listData.Add(data);
            }

            return listData;
        }
    }
}
