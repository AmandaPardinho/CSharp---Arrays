Array amostras = Array.CreateInstance(typeof(double), 5);

amostras.SetValue(20.22, 0);
amostras.SetValue(27.5, 1);
amostras.SetValue(5.5, 2);
amostras.SetValue(4.8, 3);
amostras.SetValue(9.1, 4);

double acumulador = 0;
for (int i = 0; i < amostras.Length; i++)
{
    acumulador += (double)amostras.GetValue(i);
}

double media = acumulador / amostras.Length;
Console.WriteLine($"Média = {String.Format("{0:0.000}", media)}");

Console.ReadKey();