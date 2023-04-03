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
    public partial class GD_fornecedor : UserControl
    {
        DataTable dt = new DataTable();
        fornecedor form = new fornecedor();

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
    }
}
