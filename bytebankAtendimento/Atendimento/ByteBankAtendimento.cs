using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebankAtendimento.Exceptions;
using bytebankAtendimento.Modelos.Conta;

namespace bytebankAtendimento.Atendimento
{
    public class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente("Henrique", "12365478900", "Designer")},
            new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente("Pedro", "98712345677", "Auxiliar")},
            new ContaCorrente(94, "987321-W"){Saldo = 60, Titular = new Cliente("Marisa", "95135748622", "Diretor")}
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("===  Boas-vindas ao ByteBank  ===");
                    Console.WriteLine("=================================");
                    Console.WriteLine("===        ATENDIMENTO        ===");
                    Console.WriteLine("=================================");
                    Console.WriteLine("===    1 - Cadastrar Conta    ===");
                    Console.WriteLine("===    2 - Listar Contas      ===");
                    Console.WriteLine("===    3 - Remover Conta      ===");
                    Console.WriteLine("===    4 - Ordenar Contas     ===");
                    Console.WriteLine("===    5 - Pesquisar Conta    ===");
                    Console.WriteLine("===    6 - Sair do Sistema    ===");
                    Console.WriteLine("=================================");
                    Console.WriteLine("\n");

                    Console.Write("Digite a opção desejada: ");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {
                        throw new ByteBankException(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarConta();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opção não implementada");
                            break;
                    }
                }
            }
            catch (ByteBankException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Encerrando a aplicação");
            Console.ReadKey();
        }

        private void PesquisarConta()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===      PESQUISAR CONTAS     ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");

            Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA ou (2) CPF do TITULAR ou (3) NÚMERO DA AGÊNCIA? ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Informe o CPF do titular: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCpfTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe o número da agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        List<ContaCorrente> contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                        ExibirListaContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("opção não implementada");
                    break;
            };
        }

        private void ExibirListaContas(List<ContaCorrente> contasPorAgencia)
        {
            if (!contasPorAgencia.Any())
            {
                Console.WriteLine("A consulta não retornou dados");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            //minha solução
            //return _listaDeContas.Where(conta => conta.NumeroAgencia == numeroAgencia).ToList();

            //solução do professor
            var consulta = (
                from conta in _listaDeContas
                where conta.NumeroAgencia == numeroAgencia
                select conta).ToList();
            return consulta;
        }

        private ContaCorrente ConsultaPorCpfTitular(string? cpf)
        {
            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenada");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===       REMOVER CONTAS      ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");

            Console.WriteLine("Informe o número da conta: ");
            string numeroConta = Console.ReadLine();

            ContaCorrente conta = null;
            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }

            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("Conta removida da lista!");
            }
            else
            {
                Console.WriteLine("Conta para remoção não encontrada");
            }
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===      LISTA DE CONTAS      ===");
            Console.WriteLine("=================================");
            Console.WriteLine("");

            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas");
                Console.ReadKey();
                return;
            }
            foreach (ContaCorrente item in _listaDeContas)
            {
                Console.WriteLine(item.ToString());
                Console.ReadKey();
            }

        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===     CADASTRO DE CONTAS    ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe os Dados da Conta ===");

            Console.Write("Número da agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da conta [NOVA]: {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Informe a profissão do titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);
            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadKey();
        }

    }
}
