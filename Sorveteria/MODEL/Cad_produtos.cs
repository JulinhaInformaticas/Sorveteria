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
        public string UniMedida { get; set; }


        public Cad_produtos( int codProduto, string nomeProduto,
            string descricao, float preco, string uniMedida) : this (nomeProduto, descricao, preco, uniMedida)
        {
            CodProduto = codProduto;
        }

        public Cad_produtos( string nomeProduto,
            string descricao, float preco, string uniMedida)
        {
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Preco = preco;
            UniMedida = uniMedida;
        }

    }
}
