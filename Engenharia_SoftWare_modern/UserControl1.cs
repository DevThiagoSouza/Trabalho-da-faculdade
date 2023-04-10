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

namespace Engenharia_SoftWare_modern
{
    public partial class teste : UserControl
    {
        MySqlConnection con = new MySqlConnection( "datasource=localhost;port=3306;username=thiago;password=Summit123;database=testdb");
     
        public teste()
        {
            InitializeComponent();
        }

        public void limparcampos()
        {
            nome.Text = "";
            tbcnpj.Text = "";
            numero.Text = "";
            rua.Text = "";
            complemento.Text = "";
            cep.Text = "";
            cidade.Text = "";
            telefone.Text = "";
        }

        private void teste_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tb_fornecedor values( null,'" + nome.Text + "',  '" + Convert.ToInt32(tbcnpj.Text) + "' , '" + rua.Text + "','" + Convert.ToInt32(numero.Text) + "' , '" + complemento.Text + "', '" + Convert.ToInt32(telefone.Text) + "','" + nome_fantasia.Text + "', '" + cbUF.SelectedItem.ToString() + "' ,'" + Convert.ToInt32(cep.Text) + "', '" + cidade.Text + "'  )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro de fornecedor");
            con.Close();

            limparcampos();


            }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
