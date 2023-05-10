using bytebankAtendimento.Modelos.Conta;

Console.WriteLine("Boas-vindas ao ByteBank, Atendimento.");

void TestaArrayContasCorrentes()
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
}

TestaArrayContasCorrentes();

Console.ReadKey();