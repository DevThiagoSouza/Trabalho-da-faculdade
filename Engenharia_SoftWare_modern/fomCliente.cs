﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenharia_SoftWare_modern
{
    public partial class fomCliente : UserControl
    {
        DataTable dt = new DataTable();
        public fomCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tb_home tb_Home = new Tb_home();
            tb_Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
