using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.CONTROLLER
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022048SORVETERIA";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string StringConnection = @"Data Source = " + Server
            + "; Initial Catalog = " + DataBase
            + "; User Id = " + Username
            + "; Encrypt = false";

            con = new SqlConnection(StringConnection);
            con.Open(); //abre conexão com o banco
        }
        //tenta fechar a conexão com o banco

        public void CloseConnection () 
        {
            if (con.State == System.Data.ConnectionState.Open) 
            con.Close();
        }
        //retorna conexão que foi aberta

        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
