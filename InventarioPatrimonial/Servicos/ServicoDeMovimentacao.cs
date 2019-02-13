using Negocio.Dominio;
using Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Infraestrutura.Conexao;
using MySql.Data.MySqlClient;
using System.Data;

namespace Servicos
{
    public class ServicoDeMovimentacao : IServicoGenerico, IDisposable
    {
        public void Atualize(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //TODO: Realizar destruição do objeto aqui
        }

        public void Obtenha(string id)
        {
            throw new NotImplementedException();
        }

        public IList<object> ObtenhaTodos()
        {
            throw new NotImplementedException();
        }

        public void Salve(object dado)
        {
            var objeto = dado as MovimentacaoModel;

            using (MySqlConnection conexao = ConexaoMysql.Instancia.ObtenhaConexao())
            {
                IDbCommand comando = conexao.CreateCommand();

                comando.CommandText = InsertMovimentacao(objeto);

                comando.ExecuteNonQuery();
            }
        }

        private string InsertMovimentacao(MovimentacaoModel objeto)
        {
            StringBuilder insert = new StringBuilder();

            insert.Append("INSERT INTO movimentacao (id, descricao, bem, dataRegistro) ");

            insert.AppendFormat("VALUES('{0}', ", objeto.Codigo.ToString());
            insert.AppendFormat("'{0}', ", objeto.Descricao);
            insert.AppendFormat("{0}, ", "null");
            insert.AppendFormat("'{0}' )", objeto.DataRegistro.ToString("yyyyMMddHHmmss"));
            return insert.ToString();
        }
    }
}
