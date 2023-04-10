﻿using MySql.Data.MySqlClient;
using System;
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
        string cs = "datasource=localhost;port=3306;username=thiago;password=Summit123;database=testdb";
        MySqlConnection con;
        DataTable data;
        MySqlDataAdapter adapt;
        public clienteCtrl()
        {
            InitializeComponent();
            boxpesquisa.Visible = false;

        }

        private void clienteCtrl_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(cs);
            con.Open();
            adapt = new MySqlDataAdapter("select * from tb_fornecedor", con);
            data = new DataTable();
            adapt.Fill(data);
            DtGridFornecedor.DataSource = data;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            boxpesquisa.Visible = true;
            boxpesquisa.Text = "";
        }

        private void boxpesquisa_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(cs);
            con.Open();
            adapt = new MySqlDataAdapter("select * from tb_fornecedor where nome like '" + boxpesquisa.Text + "%'", con);
            data = new DataTable();
            adapt.Fill(data);
            DtGridFornecedor.DataSource = data;
            con.Close();
        }
    }
}
