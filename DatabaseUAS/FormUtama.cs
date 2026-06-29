using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_CookShares;

namespace DatabaseUAS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                MessageBox.Show("Koneksi Berhasil", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan: " + ex.Message, "Informasi");
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategori frm = new FormKategori();
            frm.MdiParent = this;
            frm.Show();
        }
<<<<<<< HEAD
=======

        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBahan frm = new FormBahan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cookingChallangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCookingChallange frm = new FormCookingChallange();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gambarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarGambar frm = new FormDaftarGambar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void interaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarInteraksi frm = new FormDaftarInteraksi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pencarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPencarian frm = new FormDaftarPencarian();
            frm.MdiParent = this;
            frm.Show();
        }

        private void browsePostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPost frm = new FormDaftarPost();
            frm.MdiParent = this;
            frm.Show();
        }
>>>>>>> origin/main
    }
}
