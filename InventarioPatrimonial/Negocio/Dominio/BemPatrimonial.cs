using System;
using System.Collections.Generic;

namespace InventarioPatrimonial.Models
{
    public class BemPatrimonial
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        private BemPatrimonial(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public IList<BemPatrimonial> ListaDeBens = new List<BemPatrimonial>(){ Carro, Notebook, Apartamento };

        public static BemPatrimonial Carro = new BemPatrimonial(new Guid().ToString(), "Carro");
        public static BemPatrimonial Notebook = new BemPatrimonial(new Guid().ToString(), "Dell Notebook");
        public static BemPatrimonial Apartamento = new BemPatrimonial(new Guid().ToString(), "Apartamento Imovel");
    }
}