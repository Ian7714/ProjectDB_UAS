<<<<<<< HEAD
﻿using System;
=======
﻿using Class_CookShares;
using System;
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
<<<<<<< HEAD
    public partial class FormDaftarResep : Form
    {
        public FormDaftarResep()
=======
    public partial class FormDaftarInteraksi : Form
    {
        public FormDaftarInteraksi()
>>>>>>> origin/main
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD
=======

        private void FormDaftarInteraksi_Load(object sender, EventArgs e)
        {
            List<Interaksi> listData = Interaksi.BacaData();
            dgvData.DataSource = listData;
        }
>>>>>>> origin/main
    }
}
