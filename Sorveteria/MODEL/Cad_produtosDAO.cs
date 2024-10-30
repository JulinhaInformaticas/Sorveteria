using Sorveteria.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.MODEL
{
    internal class Cad_produtosDAO
    {
        private Connection Connect {  get; set; }
        private SqlCommand Command { get; set; }

        public Cad_produtosDAO() //metodo construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert (Cad_produtos prod)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO CADPRODUTO VALUES (@nomeProduto, @preco, @descricao, @uniMedida)";

            Command.Parameters.AddWithValue("@nomeProduto", prod.NomeProduto);
            Command.Parameters.AddWithValue("@preco", prod.Preco);
            Command.Parameters.AddWithValue("@descricao", prod.Descricao);
            Command.Parameters.AddWithValue("@uniMedida", prod.UniMedida);
            

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir produto no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Update (Cad_produtos prod)

        {   Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Cad_produtos SET 
            NOMEPRODUTO = @nomeProduto, 
            PRECO= @preco,
            DESCRICAO = @descricao,
            UNIMEDIDA = @uniMedida
            where CODPRODUTO = @code"; 

            Command.Parameters.AddWithValue("@code", prod.CodProduto);
            Command.Parameters.AddWithValue("@nomeProduto", prod.NomeProduto);
            Command.Parameters.AddWithValue("@preco", prod.Preco);
            Command.Parameters.AddWithValue("@descricao", prod.Descricao);
            Command.Parameters.AddWithValue("@uniMedida", prod.UniMedida);
            
            try
            {
                Command.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de produtos no banco.\n" + err.Message);
            }

            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int CodProduto)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Cad_produtos WHERE CodProduto = @code";
            Command.Parameters.AddWithValue("@code",CodProduto);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir produto no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Cad_produtos> ListarTodosProdutos()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Cad_produtos";

            List<Cad_produtos> listaDeProdutos = new List<Cad_produtos>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cad_produtos prod = new Cad_produtos(

                        (int)rd["CODPRODUTO"], 
                        (string)rd["NOMEPRODUTO"],
                        (string)rd["DESCRICAO"],
                        (float)rd["PRECO"],
                        (string)rd["UNIMEDIDA"]);

                    listaDeProdutos.Add(prod);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de produtos no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeProdutos;
        }
    }
}
