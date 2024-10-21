using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha ventilador = new Pilha();

            string[] pecas = new string[]
            {
            "Suporte",
            "Hélice Quebrada",
            "Lâmpada",
            "Cúpula de Vidro"
            };

            foreach (var peca in pecas)
            {
                ventilador.Empilhar(peca);
            }

            Console.WriteLine("Ventilador com peça quebrada:");
            ventilador.ImprimirPilha();

            Console.WriteLine("\nQual peça deseja trocar?");
            string velhaPeca = Console.ReadLine();

            Console.WriteLine("Qual é a nova peça que irá substituir?");
            string novaPeca = Console.ReadLine();

            ventilador.SubstituirPeca(velhaPeca, novaPeca);

            Console.WriteLine("\nVentilador após peça trocada:");
            ventilador.ImprimirPilha();

            Console.ReadLine();        }


    }
}
