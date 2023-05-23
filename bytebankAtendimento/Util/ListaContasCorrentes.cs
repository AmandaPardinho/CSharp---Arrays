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
    }
}
