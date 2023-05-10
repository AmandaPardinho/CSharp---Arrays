using bytebankAtendimento.Modelos.ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.ParceriaComercial
{
    public class ParceiroComercial: IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string _senha)
        {
            return Senha == _senha;
        }
    }
}
