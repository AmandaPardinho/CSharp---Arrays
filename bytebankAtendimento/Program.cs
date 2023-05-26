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
    new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente("Henrique", "12365478900", "Designer")},
    new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente("Pedro", "98712345677", "Auxiliar")},
    new ContaCorrente(94, "987321-W"){Saldo = 60, Titular = new Cliente("Marisa", "95135748622", "Diretor")}
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
                case '3': RemoverConta();
                    break;
                case '4': OrdenarContas();
                    break;
                case '5': PesquisarConta();
                    break;
                case '6': Sair();
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

void Sair()
{
    throw new NotImplementedException();
}

void PesquisarConta()
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

void ExibirListaContas(List<ContaCorrente> contasPorAgencia) 
{
    if (!contasPorAgencia.Any())
    {
        Console.WriteLine("A consulta não retornou dados");
    }
    else
    {
        foreach(var item in contasPorAgencia)
        {
            Console.WriteLine(item.ToString());
        }
    }     
}

List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
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

ContaCorrente ConsultaPorCpfTitular(string? cpf)
{
    #region
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    #endregion
    return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();

}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    #region
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Conta.Equals(numeroConta))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    #endregion

    return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();


}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("Lista de contas ordenada");
    Console.ReadKey();
}

void RemoverConta()
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
        if(item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
        
    }
    if(conta != null)
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

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("===      LISTA DE CONTAS      ===");
    Console.WriteLine("=================================");
    Console.WriteLine("");
    
    if(_listaDeContas.Count <= 0)
    {
        Console.WriteLine("Não há contas cadastradas");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        //Console.WriteLine("=================================");
        //Console.WriteLine("===       Dados da Conta      ===");
        //Console.WriteLine("=================================");
        //Console.WriteLine($"Número da conta: {item.Conta}");
        //Console.WriteLine($"Número da agência: {item.NumeroAgencia}");
        //Console.WriteLine($"Nome do titular: {item.Titular.Nome}");
        //Console.WriteLine($"CPF do titular: {item.Titular.Cpf}");
        //Console.WriteLine($"Profissão do titular: {item.Titular.Profissao}");
        //Console.WriteLine($"Saldo da conta: {item.Saldo}");
        //Console.WriteLine("=================================");
        Console.WriteLine(item.ToString());


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
