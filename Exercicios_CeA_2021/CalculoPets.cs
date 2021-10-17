using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_CeA_2021
{
    public class CalculoPets
    {
        public void Main()
        {
            string nome;
            string tipo;
            int gato = 0;
            int cachorro = 0;
            int peixe = 0;
            bool validacao = true;

            do
            {
                Console.WriteLine("Qual o tipo do seu animal?");
                Console.WriteLine("(1) Gato");
                Console.WriteLine("(2) Cachorro");
                Console.WriteLine("(3) Peixe");
                Console.WriteLine("(4) SAIR");
                Console.WriteLine("Tipo: ");
                tipo = Console.ReadLine();

                if (tipo == "1")
                {
                    Console.WriteLine("Qual o nome do seu gato?");
                    nome = Console.ReadLine();
                    gato++;
                }
                else if (tipo == "2")
                {
                    Console.WriteLine("Qual o nome do seu cahorro");
                    nome = Console.ReadLine();
                    cachorro++;
                }
                else if (tipo == "4")
                {
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Qual o nome do seu peixe?");
                    nome = Console.ReadLine();
                    peixe++;
                }
            } while (validacao);


            Console.WriteLine("Você possui {0} gatos, {1} cachorros e {2} peixes.", gato, cachorro, peixe);

        }
    }
}
