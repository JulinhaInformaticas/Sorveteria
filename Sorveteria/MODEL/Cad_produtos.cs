using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.MODEL
{
    internal class Cad_produtos
    {
        public int CodProduto { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }

        public Cad_produtos( string nomeProduto,
            string descricao, float preco) 
        {
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Preco = preco;
        }
    }
}
