using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class CookingChallenge
    {
        #region FIELD
        int id;
        string nama;
        string deskripsi;
        DateTime tglMulai;
        DateTime tglSelesai;
        string hadiah;
        #endregion

        #region CONSTRUCTOR
        public CookingChallenge()
        {
            Id = 0;
            Nama = "Siuu";
            Deskripsi = "Tidak ada deskripsi";
            TglMulai = DateTime.Now;
            TglSelesai = DateTime.Now;
            Hadiah = "Tidak ada hadiah";
        }

        public CookingChallenge(int id, string nama, string deskripsi, DateTime tglMulai, DateTime tglSelesai, string hadiah)
        {
            Id = id;
            Nama = nama;
            Deskripsi = deskripsi;
            TglMulai = tglMulai;
            TglSelesai = tglSelesai;
            Hadiah = hadiah;
        }
        #endregion

        #region PROPERTY
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public DateTime TglMulai { get => tglMulai; set => tglMulai = value; }
        public DateTime TglSelesai { get => tglSelesai; set => tglSelesai = value; }
        public string Hadiah { get => hadiah; set => hadiah = value; }
        #endregion

        #region METHOD
        public static List<CookingChallenge> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<CookingChallenge> listData = new List<CookingChallenge>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM tantangan_memasak";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM tantangan_memasak";
            }
            else if (filter == "nama_challenge")
            {
                perintah = "SELECT * FROM tantangan_memasak WHERE nama_challenge LIKE '%" + nilai + "%'";
            }
            else if (filter == "deskripsi")
            {
                perintah = "SELECT * FROM tantangan_memasak WHERE deskripsi LIKE '%" + nilai + "%'";
            }
            else if (filter == "challenge_id")
            {
                bool isInteger = int.TryParse(nilai, out _);
                if (isInteger)
                {
                    perintah = "SELECT * FROM tantangan_memasak WHERE challenge_id =" + nilai;
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
                CookingChallenge tampung = new CookingChallenge();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Nama = reader.GetValue(1).ToString();
                tampung.Deskripsi = reader.GetValue(2).ToString();
                tampung.TglMulai = DateTime.Parse(reader.GetValue(3).ToString());
                tampung.TglSelesai = DateTime.Parse(reader.GetValue(4).ToString());
                tampung.Hadiah = reader.GetValue(5).ToString();

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }
            return listData;
        }
        #endregion
    }
}
