using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenharia_SoftWare_modern
{
    class Query
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=thiago;password=Summit123;database=testdb";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados" + e.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return con;
        }

        public static void createFornecedor(fornecedor dB)
        {
            try
            {
                string sql = "INSERT INTO tb_fornecedor values(NULL, name , cnpj, endereco, rua, numero, complemento, telefone)";
                MySqlConnection con = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", MySqlDbType.VarChar).Value = dB.nome;
                cmd.Parameters.Add("name", MySqlDbType.VarChar).Value = dB.nome_Fantasia;
                cmd.Parameters.Add("cnpj", MySqlDbType.VarChar).Value = dB.cnpj;
                cmd.Parameters.Add("endereco", MySqlDbType.Int32).Value = dB.endereco;
                cmd.Parameters.Add("rua", MySqlDbType.VarChar).Value = dB.rua;
                cmd.Parameters.Add("numero", MySqlDbType.Int32).Value = dB.numero;
                cmd.Parameters.Add("complemento", MySqlDbType.VarChar).Value = dB.complemento;
                cmd.Parameters.Add("telefone", MySqlDbType.VarChar).Value = dB.telefone;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao fazer o cadastro do fornecedor" + e.Message, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error ) ;
            }
         
        }

        public static DataTable GetFornecedor()
        {
          DataTable  dt = new DataTable();
          MySqlConnection con = GetConnection();
          MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tb_fornecedor;";
            cmd.CommandTimeout = 3000;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.Prepare();
            try
            {
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);

            }
            
            catch (Exception e)
            {
                MessageBox.Show("Erro ao fazer a busca do fornecedor " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return dt;
           
        }
    }
}
 