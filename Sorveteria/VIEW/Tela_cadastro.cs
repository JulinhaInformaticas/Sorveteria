using Sorveteria.MODEL;
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
    public partial class Tela_cadastro : Form
    {
        public Tela_cadastro()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //adicionar código de imagem 
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }

        private void btn_cadastrarprod_Click(object sender, EventArgs e)
        {
            string nomeProduto = txb_nome.Text;
            string descricao = txb_desc.Text;
            float preco = float.Parse (txb_preco.Text);
            string uniMedida = cmb_med.Text;

            Cad_produtos cad_Produtos = new Cad_produtos(nomeProduto, descricao, preco, uniMedida);
            Cad_produtosDAO cad_ProdutosDAO = new Cad_produtosDAO();
            cad_ProdutosDAO.Insert (cad_Produtos);
        }
    }
}
