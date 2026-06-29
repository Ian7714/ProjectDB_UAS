<<<<<<< HEAD
﻿using Class_CookShares;
using MySql.Data.MySqlClient;
using System;
=======
﻿using System;
>>>>>>> origin/main
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseUAS
{
    public partial class FormDaftarRating : Form
    {
        public FormDaftarRating()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        public void TampilData()
        {
            string koneksi = "server=localhost;database=db_resep;uid=root;pwd=;";

            MySqlConnection con = new MySqlConnection(koneksi);

            string query =
                @"SELECT r.rating_id,
                 r.skor_rating,
                 u.nama_lengkap AS User,
                 rp.nama_resep AS Resep
          FROM rating r
          INNER JOIN user u
              ON r.User_user_id = u.user_id
          INNER JOIN resep rp
              ON r.Resep_resep_id = rp.resep_id";

            MySqlDataAdapter da = new MySqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvData.DataSource = dt;
        }

=======
>>>>>>> origin/main
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string koneksi = "server=localhost;database=db_resep;uid=root;pwd=;";

            MySqlConnection con = new MySqlConnection(koneksi);

            string field = "";

            if (cboKategori.Text == "ID Rating")
            {
                field = "r.id_rating";
            }
            else if (cboKategori.Text == "User")
            {
                field = "u.nama_lengkap";
            }
            else if (cboKategori.Text == "Resep")
            {
                field = "rp.nama_resep";
            }

            string query =
                @"SELECT r.id_rating,
                 r.skor_rating,
                 u.nama_lengkap AS User,
                 rp.nama_resep AS Resep
          FROM rating r
          INNER JOIN user u
              ON r.User_user_id = u.user_id
          INNER JOIN resep rp
              ON r.Resep_resep_id = rp.resep_id
          WHERE " + field + " LIKE '%" + txtCari.Text + "%'";

            MySqlDataAdapter da = new MySqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvData.DataSource = dt;
=======

>>>>>>> origin/main
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            txtCari.Clear();
            TampilData();
=======

>>>>>>> origin/main
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //FormTambahRating frm = new FormTambahRating();
            //frm.ShowDialog();

            //belum ada form tambah rating

            TampilData();
=======

>>>>>>> origin/main
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void FormDaftarRating_Load(object sender, EventArgs e)
        {
            List<DaftarRating> listData = DaftarRating.BacaData();
            dgvData.DataSource = listData;

            cboKategori.Items.Add("ID Rating");
            cboKategori.Items.Add("User");
            cboKategori.Items.Add("Resep");

            cboKategori.SelectedIndex = 0;

            TampilData();
        }
=======
>>>>>>> origin/main
    }
}
