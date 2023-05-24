using bytebankAtendimento.Exceptions;
using bytebankAtendimento.Modelos.ADM.Funcionarios;
using bytebankAtendimento.Modelos.Conta;
using bytebankAtendimento.Util;
using System.Collections;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

Console.WriteLine("Boas-vindas ao ByteBank, Atendimento.");

#region Testes de métodos
//void TestaArrayContasCorrentes()
//{
//    ContaCorrente[] listaContas = new ContaCorrente[]
//    {
//        new ContaCorrente(874, "5679787-A"),
//        new ContaCorrente(874, "4456668-B"),
//        new ContaCorrente(874, "7781438-C")
//    };

//    for (int i = 0; i < listaContas.Length; i++)
//    {
//        ContaCorrente contaAtual = listaContas[i];
//        Console.WriteLine($"Índice: {i} - Conta: {contaAtual.Conta}");
//    }
//}

//void TestaArrayContasCorrentes()
//{
//    ListaContasCorrentes listaContas = new ListaContasCorrentes();
//    listaContas.Adicionar(new ContaCorrente(874, "5679787-A"));
//    listaContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));

//    ArrayList lista = new ArrayList();
//    lista.Add(listaContas);
//    Console.WriteLine(lista[0]);
//}

//void TestaContasCorrentes()
//{
//    var cliente1 = new Cliente("Ana", "12345678900", "diretor");
//    var cliente2 = new Cliente("João", "98765403211", "designer");
//    var cliente3 = new Cliente("Gustavo", "36985201477", "auxiliar");

//    List<Cliente> cliente = new List<Cliente>();
//    cliente.Add(cliente1);
//    cliente.Add(cliente2);
//    cliente.Add(cliente3);

//    List<ContaCorrente> cc = new List<ContaCorrente>();
//    cc.Add(new ContaCorrente(874, "5679787-A", 5000, cliente1));
//    cc.Add(new ContaCorrente(874, "4456668-B", 3000, cliente2));
//    cc.Add(new ContaCorrente(874, "7781438-C", 2000, cliente3));

//    List<ContaCorrente> lista = ListaContasCorrentes.MaiorSaldo(cc);

//    foreach(var conta in lista)
//    {
//        Console.WriteLine(conta);
//    }
//}

//TestaContasCorrentes();

void TestaArrayContasCorrentes()
{
    ListaContasCorrentes listaContas = new ListaContasCorrentes();
    listaContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));

    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaContas.Adicionar(contaDoAndre);

    //listaContas.ExibirLista();
    //Console.WriteLine("**************************\n");

    //listaContas.Remover(contaDoAndre);

    //listaContas.ExibirLista();
    //Console.WriteLine("**************************\n");

    for (int i = 0; i < listaContas.Tamanho; i++)
    {
        ContaCorrente conta = listaContas[i];
        Console.WriteLine($"Índice [{i}] = Número da conta: {conta.Conta}/Número agência: {conta.NumeroAgencia}");
    }
}

//TestaArrayContasCorrentes();
#endregion  

#region Exemplos de uso do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();
//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}
//Console.WriteLine();

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{range[i].Conta}]");
//}
//Console.WriteLine();

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}
#endregion

#region Menu
//1 - Cadastrar Contas
//2 - Listar Contas
//3 - Remover Contas
//4 - Ordenar Contas
//5 - Pesquisar Contas
//6 - Sair do Sistema
#endregion

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X"){Saldo = 100},
    new ContaCorrente(95, "951258-X"){Saldo = 200},
    new ContaCorrente(94, "987321-W"){Saldo = 60}
};

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("===        ATENDIMENTO        ===");
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
                case '3': //RemoverConta();
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
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

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("===      LISTA DE CONTAS      ===");
    Console.WriteLine("=================================");
    Console.WriteLine("\n");
    
    if(_listaDeContas.Count <= 0)
    {
        Console.WriteLine("Não há contas cadastradas");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===       Dados da Conta      ===");
        Console.WriteLine($"Número da conta: {item.Conta}");
        Console.WriteLine($"Número da agência: {item.NumeroAgencia}");
        Console.WriteLine($"Nome do titular: {item.Titular.Nome}");
        Console.WriteLine($"CPF do titular: {item.Titular.Cpf}");
        Console.WriteLine($"Profissão do titular: {item.Titular.Profissao}");
        Console.WriteLine($"Saldo da conta: {item.Saldo}");
        Console.WriteLine("=================================");

        Console.ReadKey();
    }
    
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("===     CADASTRO DE CONTAS    ===");
    Console.WriteLine("=================================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe os Dados da Conta ===");
    
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

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

AtendimentoCliente();

Console.ReadKey();
