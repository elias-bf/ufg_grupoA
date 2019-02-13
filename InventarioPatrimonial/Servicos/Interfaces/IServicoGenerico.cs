using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos.Interfaces
{
    public interface IServicoGenerico
    {
        void Salve(object dado);
        void Atualize(string id);
        void Obtenha(string id);
        IList<object> ObtenhaTodos();

    }
}
