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
    public partial class FormCookingChallange : Form
    {
        public FormCookingChallange()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCookingChallange_Load(object sender, EventArgs e)
        {

        }
    }
}
