using bytebankAtendimento.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAtendimento.Util
{
    public class ListaContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public ListaContasCorrentes(int tamanhoInicial = 5) // 5 é um valor default e será passado à variável tamanhoInicial caso não seja determinado outro valor para ela
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public static List<ContaCorrente> MaiorSaldo(List<ContaCorrente>contas)
        {
            return contas.OrderByDescending(conta => conta.Saldo).ToList();             
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;
            for(int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if(contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < (_proximaPosicao - 1); i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void ExibirLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Índice[{i}] = Conta: {conta.Conta} - Número Agência: {conta.NumeroAgencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if((indice < 0) || (indice >= _proximaPosicao))
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public int Tamanho 
        {
            get
            {
                return _proximaPosicao;
            } 
        }

        //transforma a classe ContaCorrente em uma classe indexável
        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
    }
}
