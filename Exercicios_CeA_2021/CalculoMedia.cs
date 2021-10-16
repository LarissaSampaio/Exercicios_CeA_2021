using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class CalculoMedia
    {
        public void Main()
        {
            double p1;
            double p2;
            double p3;
            double media;
            double exame;
            double mediaFinal;

            Console.WriteLine("EXERCÍCIO 4");

            Console.WriteLine("Informe a nota de P1: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota de P2: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota de P3: ");
            p3 = Convert.ToDouble(Console.ReadLine());

            media = (p1 + p2 + p3) / 3;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado!! Média final = {0}", media);
            } 
            else if(media < 7)
            {
                Console.WriteLine("Sua média foi menor do que 7,0. Média final = {0} \n", media);
                Console.WriteLine("Informe a nota do exame: ");
                exame = Convert.ToDouble(Console.ReadLine());

                mediaFinal = (media + exame) / 2;

                if(mediaFinal >= 5)
                {
                    Console.WriteLine("Aprovado em exame! Média final = {0}", mediaFinal);
                }
                else
                {
                    Console.WriteLine("Reprovado! Média final = {0}", mediaFinal);
                }
            }
        }
    }
}
