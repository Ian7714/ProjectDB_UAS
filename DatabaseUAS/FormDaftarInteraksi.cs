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
    public partial class FormDaftarInteraksi : Form
    {
        public FormDaftarInteraksi()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormDaftarInteraksi_Load(object sender, EventArgs e)
        {
            List<Interaksi> listData = Interaksi.BacaData();
            dgvData.DataSource = listData;
        }
    }
}
