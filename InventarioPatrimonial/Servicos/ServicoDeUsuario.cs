using Infraestrutura.Conexao;
using MySql.Data.MySqlClient;
using Negocio.Dominio;
using Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Servicos
{
    public class ServicoDeUsuario : IServicoGenerico, IDisposable
    {
        public void Atualize(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
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
            var objeto = dado as UsuarioModel;

            using (MySqlConnection conexao = ConexaoMysql.Instancia.ObtenhaConexao())
            {
                IDbCommand comando = conexao.CreateCommand();

                comando.CommandText = InsertUsuario(objeto);

                comando.ExecuteNonQuery();
            }
        }

        private string InsertUsuario(UsuarioModel objeto)
        {
            StringBuilder insert = new StringBuilder();

            insert.Append("INSERT INTO usuario (id, email, senha, nome) ");
            objeto.Id = Guid.NewGuid().ToString();
            insert.AppendFormat("VALUES('{0}', ", objeto.Id);
            insert.AppendFormat("'{0}', ", objeto.Email);
            insert.AppendFormat("'{0}', ", objeto.Senha);
            insert.AppendFormat("{0} )", "null");
            return insert.ToString();
        }
    }
}
