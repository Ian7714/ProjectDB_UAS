using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class Koneksi
    {
        //Field
        MySqlConnection koneksiDB;

        //Property
        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }

        #region CONSTRUCTOR
        public Koneksi()
        {
            string connectionString = "Server=localhost;Database=cookshare;Uid=root;Pwd=;";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connectionString;

            Connect();
        }

        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string connectionString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=" + pP + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connectionString;

            Connect();
        }

        //Method Connect
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
        #endregion

        #region METHOD
        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            //Membuat/Membuka koneksi ke database
            Koneksi k = new Koneksi();

            //Membuat objek Command
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);

            //Mengeksekusi dengan execute reader, data disimpan/ditampung dalam objek reader
            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public static void JalankanPerintahNonQuery(string perintah)
        {
            //kirimkan perintah SQL ke database untuk dieksekusi
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
