using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class AdivinharNumero
    {
        public void Adivinhacao()
        {
            Random r = new Random();
            int numero = r.Next(1, 101);
            Console.WriteLine("\nVocê possui 10 chances para acertar um número entre 1 e 100.");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Tentativa {i}: Digite seu palpite: ");
                int palpite;
                try
                {
                palpite = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um número!");
                    return;
                }

                if (palpite == numero)
                {
                    Console.WriteLine("Acertou! Que sortudo.");
                    break;
                }
                else if (palpite < numero)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else
                {
                    Console.WriteLine("Tente um número menor.");
                }
            }
        }
    }

}
