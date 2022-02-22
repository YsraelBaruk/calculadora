using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double resultado;

            int operacao;
            
            Console.WriteLine("Calculadora");

            Console.WriteLine("");
            Console.WriteLine("Insira um número");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Insira mais um número");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            operacao = Convert.ToInt16(Console.ReadLine());


            if(operacao == 4)
            {
                resultado = n1 / n2;
                Console.WriteLine($"resultado = {n1} / {n2}");
            }
            else if (operacao == 3)
            {
                resultado = n1 * n2;
                Console.WriteLine($"resultado = {n1} * {n2}");
            }
            else if (operacao == 2)
            {
                resultado = n1 - n2;
                Console.WriteLine($"resultado = {n1} - {n2}");
            }
            else
            {
                resultado = n1 + n2;
                Console.WriteLine($"resultado = {n1} + {n2}");
            }

            Console.WriteLine($"O resultado {resultado}");
            Console.ReadKey();
        }
    }
}
