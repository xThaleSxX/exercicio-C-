using System;

namespace aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questão 1 
  
            Console.Write("1 2 3 4 5 6 7 8 9 10   ");
            Console.Write("11 12 13 14 15 16 17 18 19 20");
            Console.Write("21 22 23 24 25 26 27 28 29 30");
            Console.Write("31 32 33 34 35 36 37 38 39 40");

            Console.ReadKey();
            Console.Clear();

            {
                 
            }
            
            // Questão 2 

            int x;
            x = 2;
            int y;
            y = 3;

            {
                //a)  // Da o valor de X
                Console.WriteLine("x =" + x);
                //b) // Soma X + X
                Console.WriteLine(" O Valor de x + x é" + (x + x));
                //c) // Valor de x 
                Console.WriteLine("x = 2");
                //d) // Soma x + y
                Console.WriteLine((x + y) + "=" + (y + x));
                Console.ReadKey();
                Console.Clear();
            }

            //Questão 3 

            {
                Console.WriteLine("*\n**\n***\n****\n*****");
                Console.ReadKey();
                Console.Clear();

                //Resposta : Imprime uma só linha com várias quebras de texto .
            }

            //Questão 4 

            {
                Console.Write("*"); // Texto em uma linha
                Console.Write("***"); // Não deu quebra de linha e permaneceu junto com o texto anterior
                Console.WriteLine("*****"); // Deu quebra de linha
                Console.Write("****"); // Não deu quebra de linha e permaneceu junto com o texto anterior
                Console.WriteLine("**"); // quebra de linha
                Console.ReadKey();
                Console.Clear();
            }

            //Questão 5

            { 
                Console.WriteLine("Qual e o seu nome ?");
                var nome = Console.ReadLine();

                Console.WriteLine("\nQual e o seu sobrenome ?");
                var sobrenome = Console.ReadLine();

                Console.WriteLine("\nSeu numero de matricula ");
                var matricula = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{matricula}");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" - ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{nome}");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{sobrenome}");

                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();

                //Questão 6

                Console.WriteLine("fale um valor");
                var num1 = Console.ReadLine();

                Console.WriteLine("outro valor");
                var num2 = Console.ReadLine();

                int num3 = Convert.ToInt32(num1);
                int num4 = Convert.ToInt32(num2);

                Console.WriteLine(num3 + num4);
                Console.WriteLine(num3 - num4);
                Console.WriteLine(num3 * num4);
                Console.WriteLine(num3 / num4);

                Console.ReadKey();
                Console.Clear();

                //Questão 7

                Console.WriteLine("\n");
                Console.WriteLine("\nQuestão 07");

                const double PI = 3.14D;
                double area = 0;
                double raio = 0;
                double diam = 0;
                double circ = 0;

                Console.Write("Qual o valor do raio? ");
                raio = double.Parse(Console.ReadLine());

                area = PI * raio * raio;
                diam = 2 * raio;
                circ = PI * diam;

                Console.Write("\n\tA área do circulo é: " + area);
                Console.Write("\n\tO diâmetro do circulo é: " + diam);
                Console.Write("\n\tA circunferência do circulo é: " + circ);

                Console.ReadKey();
                Console.Clear();

                //Questão 8

                Console.WriteLine("\n");
                Console.WriteLine("\nQuestão 08");

                int T;
                int H;
                int resto = 0;

                Console.WriteLine("Informe um valor para a: ");
                T = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe um valor para b: ");
                H = Convert.ToInt32(Console.ReadLine());

                resto = T % H;

                if (resto == 0)
                {
                    Console.WriteLine($"{T} é divisível de {H}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"{T} não é divisível de {H}");
                    Console.ReadKey();
                    Console.Clear();
                }

                //Questão 9


                //Questão 10

                int Q, C;
                Q = 0 * 0;
                C = 0 * 0 * 0;

                Console.Write(" \nNumero\t\t Quadrado\t Cubo ");
                Console.WriteLine(" \n ");

                Console.WriteLine(" 0000 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);
                Q = 0 * 0;
                C = 0 * 0 * 0;

                Q = 1 * 1;
                C = 1 * 1 * 1;
                Console.WriteLine(" 0001 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 2 * 2;
                C = 2 * 2 * 2;
                Console.WriteLine(" 0002 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 3 * 3;
                C = 3 * 3 * 3;
                Console.WriteLine(" 0003 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 4 * 4;
                C = 4 * 4 * 4;
                Console.WriteLine(" 0004 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 5 * 5;
                C = 5 * 5 * 5;
                Console.WriteLine(" 0005 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 6 * 6;
                C = 6 * 6 * 6;
                Console.WriteLine(" 0006 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 7 * 7;
                C = 7 * 7 * 7;
                Console.WriteLine(" 0007 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 8 * 8;
                C = 8 * 8 * 8;
                Console.WriteLine(" 0008 \t\t " + Q);
                Console.WriteLine(" \t\t\t\t " + C);

                Q = 9 * 9;
                C = 9 * 9 * 9;
                Console.WriteLine(" 0009 \t\t " + Q);
                Console.WriteLine("\t\t\t\t " + C);

                Q = 10 * 10;
                C = 10 * 10 * 10;
                Console.WriteLine(" 0010 \t\t " + Q);
                Console.WriteLine("\t\t\t\t " + C);

                Console.ReadKey();
                Console.Clear(); 

            }


        }
    }
}
