using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.Conta
{
    public class Cliente
    {
        public string Cpf { get; set; }
        private string _nome;
        
        public string Nome 
        {
            get
            {
                return _nome;
            }
            set
            {
                if(value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos três caracteres");
                }
            } 
        }

        public string Profissao { get; set; }

        public static int TotalClientesCadastrados { get; set; }

        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }
    }
}
