using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

         
            if (pcbMenu.Tag == "p3")
            {
                pcbMenu.Image = Properties.Resources.picole;
                pcbMenu.Tag = "p1";
            }  
                else if (pcbMenu.Tag == "p1")
            {
                pcbMenu.Image = Properties.Resources.bebidas;
                pcbMenu.Tag = "p2";
            }
            else 
            {
                pcbMenu.Image = Properties.Resources.sorvetes;
                pcbMenu.Tag = "p3";
            }
        }


        private void cOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_comprar principal = new Tela_comprar();
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_cadastro principal = new Tela_cadastro();
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }

        private void pESSOASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login principal = new Login();
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_fun principal = new Cadastro_fun();
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
        }
    }
}
