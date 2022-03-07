using System;

namespace ContagemDeDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int ano1 = 1950, ano2 = 1996;

            int ano1, ano2,aux;
            int quantidadeAnos, quantidadeDias = 0;

            Console.WriteLine("Digite um ano: ");
            ano1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro ano: ");
            ano2 = Convert.ToInt32(Console.ReadLine());

            if (ano2 < ano1)
            {
                aux = ano1;
                ano1 = ano2;
                ano2 = aux;
            }

            quantidadeAnos = ano2 - ano1;

            for(int i = 0; i <quantidadeAnos; i++)
            {
                quantidadeDias = quantidadeDias + 365;

               if (ano1%4==0 & ano1%100!=0 || ano1%400==0)
                {
                    quantidadeDias++;
                }                
                ano1++;  
            }

            Console.WriteLine(quantidadeDias);
            Console.ReadKey();
        }
    }
}
