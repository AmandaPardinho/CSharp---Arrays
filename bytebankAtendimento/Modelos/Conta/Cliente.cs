using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.Conta
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _profissao;
       
        public string Cpf {
            get
            {
                return _cpf;
            }

            set 
            { 
                _cpf = value; 
            }
        }
        public string Profissao {
            get
            {
                return _profissao;
            }

            set 
            { 
                _profissao = value; 
            }
        }
        
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
                else
                {
                    _nome = value;
                }
            } 
        }

        public static int TotalClientesCadastrados { get; set; }

        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }

        public Cliente(string nome, string cpf, string profissao)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._profissao = profissao;
        }

        public override string ToString()
        {
            return $"Nome: {this._nome}\nCPF: {this._cpf}\nProfissão: {this._profissao}";
        }
    }
}
