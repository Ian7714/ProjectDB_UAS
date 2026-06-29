<<<<<<< HEAD
﻿using MySql.Data.MySqlClient;
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
    public partial class FormDaftarRecook : Form
    {
        public FormDaftarRecook()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        string connStr = "server=localhost;database=cookshares;uid=root;pwd=;";

        private void TampilData()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);

                string sql =
                @"SELECT r.recook_id AS 'ID Recook',
                         r.tgl_percobaan AS 'Tanggal',
                         r.hasil AS 'Hasil',
                         u.nama_lengkap AS 'User',
                         rp.nama_resep AS 'Resep'
                FROM recook r
                INNER JOIN user u         
                ON r.User_user_id = u.user_id
                INNER JOIN resep rp
                ON r.Resep_resep_id = rp.resep_id;";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvData.DataSource = dt;
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

=======
>>>>>>> origin/main
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

<<<<<<< HEAD
            CariData();
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
            //belum bisa di buat karena form tambah datar recook belum ada
=======

>>>>>>> origin/main
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void FormDaftarRecook_Load(object sender, EventArgs e)
        {
            cboKategori.Items.Clear();
            cboKategori.Items.Add("ID Recook");
            cboKategori.Items.Add("User");
            cboKategori.Items.Add("Resep");

            cboKategori.SelectedIndex = 0;

            TampilData();
        }

        private void CariData()
        {
            try
            {
                string field = "";

                if (cboKategori.Text == "ID Recook")
                    field = "r.recook_id";
                else if (cboKategori.Text == "User")
                    field = "u.nama_lengkap";
                else if (cboKategori.Text == "Resep")
                    field = "rp.nama_resep";

                MySqlConnection conn = new MySqlConnection(connStr);

                string sql =
                @"SELECT r.recook_id AS 'ID Recook',
                         r.tgl_recook AS 'Tanggal',
                         r.hasil AS 'Hasil',
                         u.nama_lengkap AS 'User',
                         rp.nama_resep AS 'Resep'
                  FROM recook r
                  INNER JOIN user u
                      ON r.User_user_id = u.user_id
                  INNER JOIN resep rp
                      ON r.Resep_resep_id = rp.resep_id
                  WHERE " + field + " LIKE @cari";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
=======
>>>>>>> origin/main
    }
}
