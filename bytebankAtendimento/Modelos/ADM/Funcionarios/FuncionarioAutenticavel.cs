using bytebankAtendimento.Modelos.ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf): base(salario, cpf)
        {            
        }

        public bool Autenticar(string _senha)
        {
            return Senha == _senha; 
        }
    }
}
