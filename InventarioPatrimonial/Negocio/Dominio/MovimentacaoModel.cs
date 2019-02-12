using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioPatrimonial.Models
{
    public class MovimentacaoModel
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRegistro { get; set; }
        public BemPatrimonial BemPatrimonial { get; set; }

    }
}
