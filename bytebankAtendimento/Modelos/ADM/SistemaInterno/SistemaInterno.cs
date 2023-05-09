using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string _senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(_senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else 
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
