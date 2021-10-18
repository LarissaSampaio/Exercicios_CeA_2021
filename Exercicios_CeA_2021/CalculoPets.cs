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
            Pet pet = new Pet();
            int gato = 0;
            int cachorro = 0;
            int peixe = 0;

            Console.WriteLine("EXERCÍCIO 5\n");
            Console.WriteLine("Informar o nome e o tipo (Gato, Cachorro ou Peixe) do seu pet!");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("\nQual o nome do seu pet {0}?", i);
                pet.Nome = Console.ReadLine();
                Console.WriteLine("\nInforme o tipo do pet: ");
                pet.Tipo = Console.ReadLine();

                if (pet.Tipo == "Cachorro")
                {
                    cachorro++;
                }
                else if (pet.Tipo == "Gato")
                {
                    gato++;
                }
                else if ( pet.Tipo == "Peixe")
                {
                    peixe++;
                }
            }

            Console.WriteLine("\nVocê possui {0} cahorro(s), {1} gato(s) e {2} peixe(s).", cachorro, gato, peixe);
           
        }
    }
}
