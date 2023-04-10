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
    public partial class fomCliente : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=thiago;password=Summit123;database=testdb");

        public fomCliente()
        {
            InitializeComponent();
        }


        public void limparcampos()
        {
            nome.Text = "";
            cpf.Text = "";
            numero.Text = "";
            rua.Text = "";
            complemento.Text = "";
            cep.Text = "";
            cidade.Text = "";
            telefone.Text = "";
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            limparcampos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tb_cliente values( null,'" + nome.Text + "' ,'" + sobrenome.Text + "' ,  '" + Convert.ToInt32(cpf.Text) + "' , '" + rua.Text + "','" + Convert.ToInt32(numero.Text) + "' , '" + complemento.Text + "', '" + Convert.ToInt32(telefone.Text) + "'  ,'" + Convert.ToInt32(cep.Text) + "' , '" + cidade.Text + "' , '" + uf.SelectedItem.ToString() + "'  )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro de cliente feito com sucesso");
            con.Close();
        }
    }
}
