using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class CalculoVolume
    {
        public void Main()
        {
            double raio;
            double volumeEsfera;

            Console.WriteLine("EXERCÍCIO 3");

            Console.WriteLine("Informe o raio da esfera: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volumeEsfera = (4/3) * (Math.PI * (Math.Pow(raio, 3)));

            Console.WriteLine("O volume da esfera é {0}.", volumeEsfera);
        }
    }
}
