using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.Funcionarios
{
    public class GerenteContas: FuncionarioAutenticavel
    {
        public GerenteContas(string cpf): base(4000, cpf)
        {            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
