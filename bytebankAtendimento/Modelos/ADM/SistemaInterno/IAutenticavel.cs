using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        bool Autenticar(string _senha);
    }
}
