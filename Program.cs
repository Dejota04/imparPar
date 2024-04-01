using System;
namespace ImparPar
{
    class ImparPar
    {
        static void Main(string[] args)
        {
            char continuar;
            int escolha, jogadaPc, jogadaPlayer, PontosPc = 0, PontosPlayer = 0;

            Console.WriteLine("---------------------------------------------------------");
            try
            {
                do
                {
                    Console.WriteLine("Escolha impar ou par\n");
                    Console.WriteLine("0 - Par\n");
                    Console.WriteLine("1 - Impar\n");
                    escolha = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (escolha == 0)
                    {
                        jogadaPc = new Random().Next(0, 10);
                        Console.WriteLine("Faça sua jogada\n");
                        jogadaPlayer = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if ((jogadaPlayer + jogadaPc) % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou {0}\n", jogadaPlayer);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O computador jogou {0}\n", jogadaPc);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Parabéns, você ganhou!!!", jogadaPlayer + jogadaPc);
                            Console.ResetColor();
                            PontosPlayer = PontosPlayer + 1;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou {0}\n", jogadaPlayer);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O computador jogou {0}\n", jogadaPc);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Que pena, não foi dessa vez!", jogadaPlayer + jogadaPc);
                            Console.ResetColor();
                            PontosPc = PontosPc + 1;
                        }
                    }

                    else if (escolha == 1)
                    {
                        jogadaPc = new Random().Next(0, 10);
                        Console.WriteLine("Faça sua jogada\n");
                        jogadaPlayer = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if ((jogadaPlayer + jogadaPc) % 2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou {0}\n", jogadaPlayer);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O computador jogou {0}\n", jogadaPc);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Parabéns, você ganhou!!!", jogadaPlayer + jogadaPc);
                            Console.ResetColor();
                            PontosPlayer = PontosPlayer + 1;
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Você jogou {0}\n", jogadaPlayer);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O computador jogou {0}\n", jogadaPc);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("O resultado foi {0}. Que pena, não foi dessa vez!", jogadaPlayer + jogadaPc);
                            Console.ResetColor();
                            PontosPc = PontosPc + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Escolha ínvalida\n");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Deseja continuar jogando? (s ou n) \n");
                    continuar = char.Parse(Console.ReadLine().ToUpper());

                } while (continuar == 'S');

                Console.WriteLine();
                Console.WriteLine("Você venceu {0} vezes\n", PontosPlayer);
                Console.WriteLine("O computador venceu {0} vezes\n", PontosPc);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro no programa - {0}", ex.Message);
                throw ex;
            }

        }
    }
}

