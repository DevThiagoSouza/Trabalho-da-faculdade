using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenharia_SoftWare_modern
{
    public partial class GD_fornecedor : UserControl
    {
        DataTable dt = new DataTable();
        private DataGridViewRow _row;

        public GD_fornecedor()
        {
            InitializeComponent();
            grid();
            boxpesquisa.Visible = false;
        
        }

      private void grid()
        {
            dt = Query.GetFornecedor();
            DtGridFornecedor.DataSource = dt;
             

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            boxpesquisa.Visible = true;
       


        }

        private void boxpesquisa_TextChanged(object sender, EventArgs e)
        {
            fornecedor fornece = new fornecedor();
            string forn = fornece.nome;
            int cnpj = fornece.cnpj;
            string pesquisa = Query.buscaFornecedor(forn , cnpj);

        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            fornecedor forn = new fornecedor();
            int ativo = forn.ativo;
            int atv = Query.ativo(ativo);

           string pedido = this._row.Cells[this.DtGridFornecedor.Columns[forn.ativo == 0 ? "ativo" : "inativo"].Index].Value.ToString();
            if (pedido.Equals("inativo"))
            {
                
            }
    
        }
    }
}
