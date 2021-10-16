using System;

namespace Exercicios_CeA_2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcao;
            bool validacao = true;

            Console.WriteLine("***EXERCÍCIOS C&A-GAMA 2021***");

            do
            {
                Console.WriteLine("Informe o número do exercício que deseja visualizar: ");
                Console.WriteLine("(1) - EXERCÍCIO 1");
                Console.WriteLine("(2) - EXERCÍCIO 2");
                Console.WriteLine("(3) - EXERCÍCIO 3");
                Console.WriteLine("(4) - EXERCÍCIO 4");
                Console.WriteLine("(5) - EXERCÍCIO 5");
                Console.WriteLine("(6) - SAIR");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CalculoImc imc = new CalculoImc();
                        imc.Main();
                        break;

                    case 2:
                        CalculoSalario calculoSalario = new CalculoSalario();
                        calculoSalario.Main();
                        break;

                    case 3:
                        CalculoVolume volume = new CalculoVolume();
                        volume.Main();
                        break;

                    case 4:
                        CalculoMedia media = new CalculoMedia();
                        media.Main();
                        break;

                    case 5:
                        CalculoPet pet = new CalculoPet();
                        pet.Main();
                        break;

                    case 6:
                        validacao = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!!");
                        Console.Clear();
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar.");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);
        }
    }
}
