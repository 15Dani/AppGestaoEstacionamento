using System;

namespace AppGestaoEstacionamento
{
       class Program
        {
            static void Main(string[] args)
            {
                int opcao = 0;
                Arquivo dados = new Arquivo();

                while (opcao != 4)
                {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Seja bem vindo a Gestão de Estacionamento");
                     Console.WriteLine();
                     Console.WriteLine("Selecione uma das opções abaixo:" +
                        "\n 1 - Mostrar quem estacionou em uma determinada vaga ao longo de um período entre duas datas " +
                        "\n 2 - Exibir, para um veículo, todas as vezes que ele estacionou, o valor de cada uso e o valor total pago" +
                        "\n 3 - Mostrar, para uma data, todas as entradas e saídas de um estacionamento, em ordem cronológica" +
                        "\n 4 - Sair" +
                        "\n Digite a opção selecionada:");
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Qual a vaga que deseja pesquisar?");
                        string vaga = Console.ReadLine();

                        VagaArvore vagaArvore = dados.LeitorVagas();
                        vagaArvore = dados.LeitorEstacionada(null, vagaArvore);

                        Console.WriteLine("Digite data inicial");
                        string intervaloIni = Console.ReadLine();

                        Console.WriteLine("Digite data final");
                        string intervaloFim = Console.ReadLine();

                        vagaArvore.PrintarEstaciondas(vaga, intervaloIni, intervaloFim);

                        Console.WriteLine("Digite algo para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (opcao == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Qual placa do carro deseja pesquisar?");
                        string placa = Console.ReadLine();

                        PlacaArvore placaArvore = dados.LeitorPlacas();
                        placaArvore = dados.LeitorEstacionada(placaArvore, null);

                        placaArvore.PrintarEstaciondas(placa);

                        Console.WriteLine("Digite algo para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (opcao == 3)
                    {
                        Console.Clear();

                        Console.WriteLine("Qual a data que deseja selecionar (DD/MM/YYYY)?");
                        string data = Console.ReadLine();

                        // Arvore de vagas para buscar qual o estacionamento da vaga
                        VagaArvore vagaArvore = dados.LeitorVagas();

                        Console.WriteLine("Gerando arvores de vagas para os estacionamentos");

                        // Estacionamentos
                        DataArvore[] estacionamentos = new DataArvore[3];

                        int estacionamento = 0;

                        while (estacionamento != 4)
                        {
                            Console.WriteLine("Qual o estacionamento deseja selecionar (0, 1, 2) ou digite 4 para sair");
                            estacionamento = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite algo para começar");
                            Console.ReadKey();

                            // Caso o estacionamento selecionado não possua arvore
                            if (estacionamentos[estacionamento] == null)
                            {
                                estacionamentos[estacionamento] = dados.LeitorDatas(estacionamento, vagaArvore);
                                estacionamentos[estacionamento] = dados.LeitorEstacionadaData(estacionamentos[estacionamento]);
                                estacionamentos[estacionamento].PrintarDatas(data);
                            }
                            else
                            {
                                // Caso o estacionamento já possua sua arvore
                                estacionamentos[estacionamento].PrintarDatas(data);
                            }
                        }

                        Console.WriteLine("Digite algo para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
    }


    

