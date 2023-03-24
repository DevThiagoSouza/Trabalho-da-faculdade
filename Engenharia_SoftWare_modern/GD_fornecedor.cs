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
       

        public GD_fornecedor()
        {
            InitializeComponent();
            grid();
        
        }

      private void grid()
        {
            Query query = new Query();
            dataGridView1.DataSource = query;
        }

      
    }
}
