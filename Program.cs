using testeSuites.Entities;

namespace testeSuites
{
    class Program
    {
        static void Main()
        {
            HotelSystem system = new(new InMemorySuiteRepository());
            SetupSuites();
            PromptMenu();

            void SetupSuites()
            {
                for (int i = 100; i <= 199; i++)
                {
                    system.CreateSuite("simples", i);
                }

                for (int i = 200; i <= 280; i++)
                {
                    system.CreateSuite("luxo", i);
                }

                for (int i = 300; i <= 330; i++)
                {
                    system.CreateSuite("presidencial", i);
                }
            }
            void PromptMenu()
            {
                while (true)
                {
                    int opt = MainMenuOpt();

                    switch (opt)
                    {
                        case 1:
                            Option1();
                            break;
                        case 2:
                            Option2();
                            break;
                        case 3:
                            Option3();
                            break;
                        case 4:
                            Option4();
                            break;
                        case 5:
                            Option5();
                            break;
                        default:
                            Console.WriteLine("\nOpção incorreta. Tente novamente.\n");
                            break;
                    }
                }
            }
            int MainMenuOpt()
            {
                Console.WriteLine("\n---- SISTEMA DE RESERVAS ----\n");
                Console.WriteLine("\n            MENU   \n");
                Console.WriteLine("  1.  Reservar suíte");
                Console.WriteLine("  2.  Cancelar reserva");
                Console.WriteLine("\n  3.  Ocupar suíte");
                Console.WriteLine("  4.  Liberar suíte");
                Console.WriteLine("\n  5.  Mostrar suítes");
                Console.Write("\nDigite uma opção: ");

                if (int.TryParse(Console.ReadLine(), out int opt))
                {
                    return opt;
                }
                else
                {
                    return 0;
                }
            }

            void Option1()
            {
                Console.Clear();
                Console.Write("\nInsira o número da suíte que deseja RESERVAR: ");

                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("");
                    system.ReserveSuite(n);
                    Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.\n");
                }
            }
            void Option2()
            {
                Console.Clear();
                Console.Write("\nInsira o número da suíte que deseja CANCELAR reserva: ");

                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("");
                    system.CancelReservation(n);
                    Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.\n");
                }
            }
            void Option3()
            {
                Console.Clear();
                Console.Write("\nInsira o número da suíte que deseja OCUPAR: ");

                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("");
                    system.OccupySuite(n);
                    Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.\n");
                }
            }
            void Option4()
            {
                Console.Clear();
                Console.Write("\nInsira o número da suíte que deseja LIBERAR: ");

                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("");
                    system.ReleaseSuite(n);
                    Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Tente novamente.\n");
                }
            }
            void Option5()
            {
                Console.Clear();
                Console.WriteLine("\n            SUÍTES   \n");
                system.ShowStatus();
                Console.WriteLine("\n\nAperte qualquer tecla para voltar ao menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
