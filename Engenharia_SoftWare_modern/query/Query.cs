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

        public static DataTable GetCliente()
        {
            DataTable dt = new DataTable();
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tb_cliente;";
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

        public static void updateFornecedor(fornecedor forn)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string sql = "";
            try
            {
                sql += $"UPDATE  tb_fornecedor SET {forn.rua} , {forn.numero}, {forn.complemento}, {forn.telefone} WHERE = {forn.id} " ;
                cmd.CommandText = sql;

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro ao fazer a Atualização " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        public static void deleteFornecedor(fornecedor forn )
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string sql = "";
            try
            {
                sql += $"DELETE FROM tb_fornecedor WHERE = {forn.nome}";
                cmd.CommandText = sql;

                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Deletar " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static int ativo(int ativo)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            int atv = 0;

            try
            {
                string sql = $"SELECT ativo FROM tb_fornecedor = '{ativo}'";
                cmd.CommandText = sql;


                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                atv = Convert.ToInt32(dataReader["ativo"]);
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao fazer ao achar o fornecedor " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return atv;

        }
    }
}
 