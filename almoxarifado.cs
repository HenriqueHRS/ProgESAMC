using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double ide, a = 0015, b = 0012, c = 1050, fer;
            int quantidadeAlicate = 10;
            int quantidadeChaveDeFenda = 10;
            int quantidadeMartelo = 10;

            while (true)

            {

                Console.WriteLine("Digite o seu codigo de ID: ");

                ide = Convert.ToDouble(Console.ReadLine());



                while (ide == a || ide == b || ide == c)

                {

                    Console.WriteLine("1 - Alicate\n2 - Chave de fenda\n3 - Martelo\n4 - Sim\n5 - Não");



                    Console.WriteLine("Digite a opção que deseja!");

                    fer = Convert.ToDouble(Console.ReadLine());


                    if (fer == 1 || fer == 2 || fer == 3)
                    {
                        Console.WriteLine("Você escolheu a ferramenta {0}. Confirmar? (4 - SIM, 5 - NÃO)", fer);
                        double confirmacao = Convert.ToDouble(Console.ReadLine());

                        if (confirmacao == 4)
                        {
                            Console.WriteLine("Quantas unidades deseja retirar? (Máximo 2): ");
                            int quantidade = Convert.ToInt32(Console.ReadLine());

                            if (quantidade > 0 && quantidade <= 2)
                            {
                                if (fer == 1)
                                {                                 
                                    if (quantidadeAlicate >= quantidade)
                                    {
                                        quantidadeAlicate -= quantidade;
                                        Console.WriteLine("Retire {0} unidade(s) de Alicate.", quantidade);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantidade indisponível no estoque.");
                                    }
                                }
                                else if (fer == 2)
                                {
                                    if (quantidadeChaveDeFenda >= quantidade)
                                    {
                                        quantidadeChaveDeFenda -= quantidade;
                                        Console.WriteLine("Retire {0} unidade(s) de Chave de Fenda.", quantidade);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantidade indisponível no estoque.");
                                    }
                                }
                                else if (fer == 3)
                                {
                                    if (quantidadeMartelo >= quantidade)
                                    {
                                        quantidadeMartelo -= quantidade;
                                        Console.WriteLine("Retire {0} unidade(s) de Porca.", quantidade);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantidade indisponível no estoque.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Quantidade inválida.");
                            }
                        }
                        else if (confirmacao == 5)
                        {
                            Console.WriteLine("Escolha outra ferramenta.");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ferramenta inválida.");
                    }
                }
            }


        }
    }
}