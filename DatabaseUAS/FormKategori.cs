using Class_CookShares;
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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            List<Kategori> listData = Kategori.BacaData();
            dgvData.DataSource = listData;

            cboKategori.Items.Add("kategori_id");
            cboKategori.Items.Add("nama_kategori");

            cboKategori.SelectedIndex = 0;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string filter;
            if (cboKategori.SelectedIndex == 0)
            {
                filter = "kategori_id";
            }
            else
            {
                filter = "nama_kategori";
            }

            string nilai = txtCari.Text;

            List<Kategori> listData = Kategori.BacaData(filter, nilai);
            dgvData.DataSource = listData;
        }
    }
}
