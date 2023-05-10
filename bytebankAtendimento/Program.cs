using bytebankAtendimento.Modelos.Conta;
using bytebankAtendimento.Util;

Console.WriteLine("Boas-vindas ao ByteBank, Atendimento.");

/*void TestaArrayContasCorrentes()
{
    ContaCorrente[] listaContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    };

    for (int i = 0; i < listaContas.Length; i++)
    {
        ContaCorrente contaAtual = listaContas[i];
        Console.WriteLine($"Índice: {i} - Conta: {contaAtual.Conta}");
    }
}*/

void TestaArrayContasCorrentes()
{
    ListaContasCorrentes listaContas = new ListaContasCorrentes();
    listaContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaContas.Adicionar(new ContaCorrente(874, "4456668-B")); 
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaContas.Adicionar(new ContaCorrente(874, "7781438-C"));
}
TestaArrayContasCorrentes();

Console.ReadKey();