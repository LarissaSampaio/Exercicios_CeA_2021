using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class CalculoSalario
    {
        public void Main()
        {
            double salario;
            double salarioMinimo;
            double qtSalarioMin;

            Console.WriteLine("EXERCÍCIO 2");

            Console.WriteLine("Informe o salário do funcionário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do salário mínimo: ");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            qtSalarioMin = salario / salarioMinimo;

            Console.WriteLine("O funcionário ganha {0} salários mínimos.", qtSalarioMin);
        }
    }
}
