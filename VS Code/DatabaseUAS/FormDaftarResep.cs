using MySql.Data.MySqlClient;
using System;
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
    public partial class FormDaftarResep : Form
    {
        string connStr = "server=localhost;database=cookshares;uid=root;pwd=;";

        public FormDaftarResep()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDaftarResep_Load(object sender, EventArgs e)
        {
            cboKategori.Items.Clear();

            cboKategori.Items.Add("ID Resep");
            cboKategori.Items.Add("Nama Resep");

            cboKategori.SelectedIndex = 0;

            TampilData();
        }

        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql =
                    @"SELECT resep_id AS 'ID Resep',
                             nama_resep AS 'Nama Resep'
                      FROM resep";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvData.DataSource = dt;
                    dgvData.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string field = "";

                if (cboKategori.Text == "ID Resep")
                    field = "resep_id";
                else if (cboKategori.Text == "Nama Resep")
                    field = "nama_resep";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql =
                    @"SELECT resep_id AS 'ID Resep',
                             nama_resep AS 'Nama Resep'
                      FROM resep
                      WHERE " + field + " LIKE @cari";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cari", "%" + txtCari.Text + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCari.Clear();
            TampilData();
        }
    }
}
