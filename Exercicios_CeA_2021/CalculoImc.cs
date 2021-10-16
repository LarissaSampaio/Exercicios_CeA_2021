using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class CalculoImc
    {
        public void Main()
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("EXERCÍCIO 1");

            Console.WriteLine("Informe o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal.");
            }
            else if (imc >= 25)
            {
                Console.WriteLine("Acima do peso.");
            }
            else
            {
                Console.WriteLine("Dados inválidos.");
            }
        }
    }
}
