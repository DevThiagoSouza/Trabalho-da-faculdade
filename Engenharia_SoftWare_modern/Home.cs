using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Engenharia_SoftWare_modern
{
    public partial class TL_Home : Form
    {

        public TL_Home() 
        {
            InitializeComponent();
            panel4.Height = btnHome.Height;
            panel4.Top = btnHome.Top;
            pnlLogin.Visible = false;
            panel6.Visible = false;
            mesagem();
        }

        private void TL_Home_Load(object sender, EventArgs e)
        {
            tb_home2.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToShortTimeString();
            Data.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();

        }

        private void mesagem()
        {
            toolTip1.AutoPopDelay = 4000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;
            toolTip1.SetToolTip(pictureBox2, "Fazer Login ou Cadastro");
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            panel4.Height = btnFornecedor.Height;
            panel4.Top = btnFornecedor.Top;
            gD_fornecedor1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel4.Height = btnHome.Height;
            panel4.Top = btnHome.Top;
            tb_home2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            contato2.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Top = button2.Bottom;
            login1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Top = button3.Bottom;
            panel6.Visible = true;
            panel6.BringToFront();
        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            panel7.Top = btnForn.Bottom;
            pnlLogin.Visible = false;
            panel6.Visible = false;
            teste1.BringToFront();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            panel7.Top = btnCliente.Bottom;
            pnlLogin.Visible = false;
            panel6.Visible = false;
            fomCliente2.BringToFront();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            sobre2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel7.Top = button4.Bottom;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            clienteCtrl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/i/flow/login");
        }
    }
}
