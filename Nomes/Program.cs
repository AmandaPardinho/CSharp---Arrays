using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomes
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>()
            {
                "Bruce Wayne",
                "Carlos Vilagran",
                "Richard Grayson",
                "Bob Kane",
                "Will Farrel",
                "Lois Lane",
                "General Welling",
                "Perla Letícia",
                "Uxas",
                "Diana Prince",
                "Elisabeth Romanova",
                "Anakin Wayne"
            };

            string nomeBusca = "Anakin Wayne";
            bool encontrado = nomes.Contains(nomeBusca);

            if (encontrado)
            {                 
                Console.WriteLine($"A pessoa {nomeBusca} foi encontrada");                
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada");
            }
        }

        //public bool BucaNome(List<string> lista, string busca)
        //{
        //    return lista.Contains(busca);
        //}
    }
}
