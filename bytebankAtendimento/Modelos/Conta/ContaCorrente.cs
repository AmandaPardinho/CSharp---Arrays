using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Modelos.Conta
{
    public class ContaCorrente
    {
        private int _numeroAgencia;
        private string _conta;
        private double _saldo;

        public Cliente Titular { get; set; }

        public string NomeAgencia { get; set; }

        public int NumeroAgencia {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if(value > 0)
                {
                    _numeroAgencia = value;
                }
            } 
        }

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value != null)
                {
                    _conta = value;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(!(value < 0.0))
                {
                    _saldo = value;
                }
            }
        }

        public static int TotalContasCriadas { get; set; }

        public bool Sacar(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            if(valor < 0.0)
            {
                return false;
            }
            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if(!(valor < 0.0))
            {
                _saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(_saldo < valor)
            {
                return false;
            }
            if(valor < 0.0)
            {
                return false;
            }
            _saldo -= valor;
            destino.Saldo += valor;
            return true;
        }

        public ContaCorrente(int _numeroAgencia)
        {
            NumeroAgencia = _numeroAgencia;
            Conta = Guid.NewGuid().ToString().Substring(0, 8);
            Titular = new Cliente();
            TotalContasCriadas++;
        }

        public ContaCorrente(int _numeroAgencia, string _conta)
        {
            NumeroAgencia = _numeroAgencia;
            Conta = _conta;
        }

        public override string ToString()
        {
            return $"=== DADOS DA CONTA ===\nNúmero da Conta: {this.Conta}\nTitular da Conta: {this.Titular.Nome}\nCPF: {this.Titular.Cpf}\nProfissão: {this.Titular.Profissao}";
        }
    }
}
