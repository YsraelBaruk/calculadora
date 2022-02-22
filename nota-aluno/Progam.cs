using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             I < 5
             R >= 5
             B >= 8
             MB >= 9
             */

            double media;
            double n1;
            double n2;
            double n3;
            double n4;
            string nota;

            Console.WriteLine("Insira o valor do N1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do N2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do N3: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor do N4: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 9)
            {
                Console.Write($"O aluno tirou MB - {media}");
            }
            else if (media >= 8)
            {
                Console.Write($"O aluno tirou B - {media}");
            }
            else if(media >= 5)
            {
                Console.Write($"O aluno tirou R - {media}");
            }
            else
            {
                Console.Write($"O aluno tirou I - {media}");
            }

            Console.ReadKey();

        }
    }
}