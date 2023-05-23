using bytebankAtendimento.Modelos.ADM.Funcionarios;
using bytebankAtendimento.Modelos.Conta;
using bytebankAtendimento.Util;
using System.Collections;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

Console.WriteLine("Boas-vindas ao ByteBank, Atendimento.");

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

void TestaContasCorrentes()
{
    var cliente1 = new Cliente("Ana", "12345678900", "diretor");
    var cliente2 = new Cliente("João", "98765403211", "designer");
    var cliente3 = new Cliente("Gustavo", "36985201477", "auxiliar");

    List<Cliente> cliente = new List<Cliente>();
    cliente.Add(cliente1);
    cliente.Add(cliente2);
    cliente.Add(cliente3);

    List<ContaCorrente> cc = new List<ContaCorrente>();
    cc.Add(new ContaCorrente(874, "5679787-A", 3, cliente1));
    cc.Add(new ContaCorrente(874, "4456668-B", 50, cliente2));
    cc.Add(new ContaCorrente(874, "7781438-C", 1, cliente3));

    List<ContaCorrente> lista = ListaContasCorrentes.MaiorSaldo(cc);
    
    foreach(var conta in lista)
    {
        Console.WriteLine(conta);
    }
}

TestaContasCorrentes();

Console.ReadKey();