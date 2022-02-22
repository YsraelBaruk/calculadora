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
            double VProduto; //sem desconto
            double VFinal; //com desconto
            double desconto; //a porcentagem do desconto %

            //valor >= 100 tem 20%
            //valor < 100 tem 10%

            Console.WriteLine("Insira o valor do produto: ");
            VProduto = Convert.ToDouble(Console.ReadLine());

            if (VProduto >= 100)
            {
                desconto = 0.8;
            }
            else
            {
                desconto = 0.9;

            }
            VFinal = VProduto * desconto;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"O valor do produto com desconto foi de R${VFinal}");

            Console.ReadKey();

        }
    }
}