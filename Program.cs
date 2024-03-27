using System.Runtime.CompilerServices;

namespace AtividadesArrays
{
    internal class Program
    {
        static string[] turma = new string[5] {" ","Lucas ","Fernanda","Ronaldo"," " };
        static void Main(string[] args)
        {

            int sair = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Selecione a opção digitando o numero");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("1 - Adicionar Alunos");
                Console.WriteLine("2 - Pesquisar Alunos");
                Console.WriteLine("3 - Editar Alunos");
                Console.WriteLine("4 - Deletar Alunos");
                Console.WriteLine("0 - Sair");
                int operador = int.Parse(Console.ReadLine());

                if (operador == 1)
                {
                    Adiciona();
                }

                else if (operador == 2)
                {
                    Pesquisa();
                }

                else if (operador == 3)
                {
                    Edita();
                }

                else if (operador == 4)
                {
                    Deleta();
                }

                else if (operador == 0)
                {
                    Sair();
                    sair = 1;
                }



            } while (sair == 0);


            


           /* int sair = 0, operador = 0, media=0;

            int[] notas = new int[3];

            do
            {
                Console.WriteLine("Selecione a opção desejada abaixo");
                Console.WriteLine("1 - Adicionar notas");
                Console.WriteLine("0 - Sair");
                operador = int.Parse(Console.ReadLine());

                if (operador == 1)
                {
                    do
                    {
                        for (int i = 0; i < notas.Length; i++)
                        {

                            Console.WriteLine("Digite a nota " + (i + 1) + ": ");
                            notas[i] = int.Parse(Console.ReadLine());
                            if (notas[i] >= 0 && notas[i] <= 10)
                            {
                                media += notas[i];
                            }
                            else
                            {
                                Console.WriteLine("Nota invalida, será atribuido 0 a nota");
                                notas[i] = 0;
                            }
                        }
                    } while (sair == 1);
                 

                  Console.WriteLine("A média das notas digitas é: " + media/notas.Length);
                }


                else if (operador == 0)
                {
                    Console.WriteLine("Finalizando operação");
                    sair = 0;
                }
                else
                {
                    Console.WriteLine("Opção invalida, digite novamente");
                }


            } while (sair == 1);
           */

        }

        private static void Sair()
        {
            
            Console.WriteLine("Finalizando sessão");
            
        }

        private static void Adiciona()
        {
            int sair=0, op=0, identificador=0;;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual opção deseja");
                Console.WriteLine("+++++++++++++++++");
                Console.WriteLine("1 - Adicionar turma");
                Console.WriteLine("2 - Adicionar unico aluno em id determinado");
                Console.WriteLine("3 - Consultar Turma");
                Console.WriteLine("0 - Retornar ao menu anterior");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    for (int i = 0; i < turma.Length; i ++)
                    {
                        Console.WriteLine("Digite o nome do aluno no id "+(i)+": ");
                        turma[i] = Console.ReadLine();
                    }
                    sair = 1;
                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for(int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID "+i+": " + turma[i]);
                    }
                    Console.WriteLine("Em qual posição, deseja adicionar um novo aluno");
                    identificador = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Digite o nome do Aluno: ");
                    turma[identificador] = Console.ReadLine();
                    sair = 1;
                }

                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    sair = 1;
                    Console.ReadKey();
                }

                else if (op == 0)
                {
                    Console.Clear();
                    sair = 0;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    sair = 1;
                }


            } while (sair == 1);
        }

        private static void Pesquisa()
        {
            int sair = 0, op = 0, identificador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual opção deseja");
                Console.WriteLine("+++++++++++++++++");
                Console.WriteLine("1 - Pesquisar Aluno pelo ID");
                Console.WriteLine("2 - Adicionar unico aluno em id determinado");
                Console.WriteLine("3 - Consultar Turma");
                Console.WriteLine("0 - Retornar ao menu anterior");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    int pesquisa = 0;
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("Digite o id do aluno:");
                    pesquisa = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nome: " + turma[pesquisa]);

                    Console.ReadKey();

                    sair = 1;
                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    Console.WriteLine("Em qual posição, deseja adicionar um novo aluno");
                    identificador = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do Aluno: ");
                    turma[identificador] = Console.ReadLine();
                    sair = 1;
                }

                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    sair = 1;
                    Console.ReadKey();
                }

                else if (op == 0)
                {
                    Console.Clear();
                    sair = 0;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    sair = 1;
                }


            } while (sair == 1);

        }

        private static void Edita()
        {
            int sair = 0, op = 0, identificador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual opção deseja");
                Console.WriteLine("+++++++++++++++++");
                Console.WriteLine("1 - Editar aluno pelo ID");
                Console.WriteLine("2 - Adicionar unico aluno em id determinado");
                Console.WriteLine("3 - Consultar Turma");
                Console.WriteLine("0 - Retornar ao menu anterior");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    int pesquisa = 0;
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("Digite o id do aluno:");
                    pesquisa = int.Parse(Console.ReadLine());

                    Console.WriteLine("Editar o aluno: " + turma[pesquisa]);

                    Console.Write("Edição:");
                    turma[pesquisa] = Console.ReadLine();



                    Console.ReadKey();

                    sair = 1;
                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    Console.WriteLine("Em qual posição, deseja adicionar um novo aluno");
                    identificador = int.Parse(Console.ReadLine());

                    Console.Write("Digite o nome do Aluno: ");
                    turma[identificador] = Console.ReadLine();
                    sair = 1;
                }

                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    sair = 1;
                    Console.ReadKey();
                }

                else if (op == 0)
                {
                    Console.Clear();
                    sair = 0;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    sair = 1;
                }


            } while (sair == 1);
        }

        private static void Deleta()
        {
            int sair = 0, op = 0, identificador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Qual opção deseja");
                Console.WriteLine("+++++++++++++++++");
                Console.WriteLine("1 - Deletar aluno pelo ID");
                Console.WriteLine("2 - Adicionar unico aluno em id determinado");
                Console.WriteLine("3 - Consultar Turma");
                Console.WriteLine("0 - Retornar ao menu anterior");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    int pesquisa = 0;
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine("Digite o id do aluno:");
                    pesquisa = int.Parse(Console.ReadLine());

                    Console.WriteLine("Deletando o aluno: " + turma[pesquisa]);
                    turma[pesquisa] = "Deletado";



                    Console.ReadKey();

                    sair = 1;
                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    Console.WriteLine("Em qual posição, deseja adicionar um novo aluno");
                    identificador = int.Parse(Console.ReadLine());

                    Console.Write("Digite o nome do Aluno: ");
                    turma[identificador] = Console.ReadLine();
                    sair = 1;
                }

                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("+++++++++++++++++Turma+++++++++++++++++++++++++");
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
                    for (int i = 0; i < turma.Length; i++)
                    {
                        Console.WriteLine("ID " + i + ": " + turma[i]);
                    }
                    sair = 1;
                    Console.ReadKey();
                }

                else if (op == 0)
                {
                    Console.Clear();
                    sair = 0;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    sair = 1;
                }


            } while (sair == 1);

        }


    }
}

