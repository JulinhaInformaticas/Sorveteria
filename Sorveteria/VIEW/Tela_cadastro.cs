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
        private void UpdateListView()
        {
            ltv_prod.Items.Clear();

            Cad_produtosDAO cad_produtosDAO = new Cad_produtosDAO();
            List<Cad_produtos> ListaDeProdutos = new ListaDeProdutos.prod.ListaDeProdutos();

           
            foreach (Cad_produtos Cad_produtos in )
            {
                ListViewItem item = new ListViewItem(Cad_produtos.CodProduto.ToString());

                item.SubItems.Add(Cad_produtos.CodProduto.ToString());
                item.SubItems.Add(Cad_produtos.NomeProduto);
                item.SubItems.Add(Cad_produtos.Preco.ToString());
                item.SubItems.Add(Cad_produtos.Descricao);
                item.SubItems.Add(Cad_produtos.UniMedida);
                
                
                ltv_prod.Items.Add(item);
            }
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

        private void Tela_cadastro_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
