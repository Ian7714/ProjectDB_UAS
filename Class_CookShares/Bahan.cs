using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Bahan
    {
        #region FIELD
        int id;
        string nama;
        string satuan;
        int kaloriPerUnit;
        #endregion

        #region CONSTRUCTOR
        public Bahan()
        {
            Id = 0;
            Nama = "Siuu";
            Satuan = "N";
            KaloriPerUnit = 0;
        }

        public Bahan(int id, string nama, string satuan, int kaloriPerUnit)
        {
            Id = id;
            Nama = nama;
            Satuan = satuan;
            KaloriPerUnit = kaloriPerUnit;
        }
        #endregion

        #region PROPERTY
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Satuan { get => satuan; set => satuan = value; }
        public int KaloriPerUnit { get => kaloriPerUnit; set => kaloriPerUnit = value; }
        #endregion

        #region METHOD
        public static List<Bahan> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<Bahan> listData = new List<Bahan>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM bahan";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM bahan";
            }
            else if (filter == "nama_bahan")
            {
                perintah = "SELECT * FROM bahan WHERE nama_bahan LIKE '%" + nilai + "%'";
            }
            else if (filter == "satuan")
            {
                perintah = "SELECT * FROM bahan WHERE satuan LIKE '%" + nilai + "%'";
            }
            else if (filter == "bahan_id")
            {
                bool isInteger = int.TryParse(nilai, out _);
                if (isInteger)
                {
                    perintah = "SELECT * FROM bahan WHERE bahan_id = " + nilai;
                }
                else
                {
                    nilai = "";
                }
            }
            else if (filter == "kalori_per_unit")
            {
                bool isInteger = int.TryParse(nilai, out _);
                if (isInteger)
                {
                    perintah = "SELECT * FROM bahan WHERE kalori_per_unit = " + nilai;
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
                //buat objek
                Bahan tampung = new Bahan();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Nama = reader.GetValue(1).ToString();
                tampung.Satuan = reader.GetValue(2).ToString();
                tampung.KaloriPerUnit = int.Parse(reader.GetValue(3).ToString());

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
        #endregion
    }
}
