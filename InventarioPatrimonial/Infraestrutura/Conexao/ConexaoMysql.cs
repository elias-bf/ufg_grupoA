using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Infraestrutura.Conexao
{
    public class ConexaoMysql
    {
        private static ConexaoMysql _Intancia;
        private ConexaoMysql() { }
        private MySqlConnection _Conexao;


        public static ConexaoMysql Instancia 
        {
            get
            {
                if (_Intancia == null)
                {
                    _Intancia = new ConexaoMysql();
                } 
                return _Intancia;
            }
        }

        private MySqlConnection ObtenhaConexao(bool aberta = true,
            bool converterDataZerada = false, bool permitirValorZeroData = false)
        {
            //string cs = "Server=localhost;Database=tests;Uid=test;Pwd=pass;";

            StringBuilder conexaoString = new StringBuilder();
            conexaoString.AppendFormat("Server={0}", "inventariopatrimonialaplicacao-mysqldbserver.mysql.database.azure.com;");
            conexaoString.AppendFormat("Database={0}", "inventariopatrimonialaplicacao-mysqldbserver;");
            conexaoString.AppendFormat("Uid={0}", "mysqldbuser@inventariopatrimonialaplicacao-mysqldbserver;");
            conexaoString.AppendFormat("Pwd={0}", "123@Fernando;");

            var csb = new MySqlConnectionStringBuilder(conexaoString.ToString())
            {
                AllowZeroDateTime = permitirValorZeroData,
                ConvertZeroDateTime = converterDataZerada
            };
            _Conexao = new MySqlConnection(csb.ConnectionString);
            if (aberta) _Conexao.Open();
            return _Conexao;
        }
    }
}
