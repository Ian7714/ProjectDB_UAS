using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class User
    {
        #region FIELD
        int id;
        string email;
        string nama;
        string noTelp;
        DateTime tglLahir;
        DateTime createdAt;
        #endregion

        #region CONSTRUCTOR
        public User()
        {
            Id = 0;
            Email = "TidakAda@gmail.com";
            Nama = "Siuu";
            NoTelp = "08123456789";
            TglLahir = DateTime.Now;
            CreatedAt = DateTime.Now;
        }

        public User(int id, string email, string nama, string noTelp, DateTime tglLahir, DateTime createdAt)
        {
            Id = id;
            Email = email;
            Nama = nama;
            NoTelp = noTelp;
            TglLahir = tglLahir;
            CreatedAt = createdAt;
        }
        #endregion

        #region PROPERTY
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Nama { get => nama; set => nama = value; }
        public string NoTelp { get => noTelp; set => noTelp = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        #endregion

        #region METHOD
        /*public static User CekLogin(string username, string password)
        {

        }*/

        public static List<User> BacaData(string filter = "", string nilai = "")
        {
            //Membuat objek list untuk menampung data kategori yang akan dibaca dari database
            List<User> listData = new List<User>();

            //Menyiapkan perintah SQL
            string perintah = "SELECT * FROM pengguna";

            if (filter == "" || nilai == "")
            {
                perintah = "SELECT * FROM pengguna";
            }
            else if (filter == "nama_kategori")
            {
                perintah = "SELECT pengguna_id, nama_lengkap FROM pengguna WHERE nama_lengkap LIKE '%" + nilai + "%'";
            }

            MySqlDataReader reader = Koneksi.JalankanPerintahSelect(perintah);

            //Menyimpan data dari objek reader ke dalam listData
            while (reader.Read() == true)
            {
                User tampung = new User();
                tampung.Id = int.Parse(reader.GetValue(0).ToString());
                tampung.Nama = reader.GetValue(1).ToString();
                tampung.Email = reader.GetValue(2).ToString();
                tampung.NoTelp = reader.GetValue(3).ToString();
                tampung.TglLahir = DateTime.Parse(reader.GetValue(4).ToString());
                tampung.CreatedAt = DateTime.Parse(reader.GetValue(5).ToString());

                //Menambahkan objek kategori yang sudah diisi dengan data dari variabel tampung ke dalam listData
                listData.Add(tampung);
            }

            return listData;
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
