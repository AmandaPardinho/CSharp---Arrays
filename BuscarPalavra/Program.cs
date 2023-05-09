void BuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}a. palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

BuscarPalavra();
