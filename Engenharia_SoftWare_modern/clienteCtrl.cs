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
    public partial class clienteCtrl : UserControl
    {
        DataTable dt = new DataTable();
        public clienteCtrl()
        {
            InitializeComponent();
            grid();
        }

        private void grid()
        {
            dt = Query.GetCliente();
            DtGridFornecedor.DataSource = dt;
        }
    }
}
