//Usando a classe Array

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0); //SetValue => recebe o valor e a posição (índice)
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//mediana => valor do meio da amostra (divide a amostra em duas partes)
void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("O Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : ((numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2);
    Console.WriteLine($"Com base na amostra, a mediana = {mediana}");
}

TestaMediana(amostra);

Console.ReadKey();
