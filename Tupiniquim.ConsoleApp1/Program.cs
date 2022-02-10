using System;

namespace Tupiniquim.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int px, py, areax, areay;
            char orient;
            string entrada;
            string mov;
            char op;

            Console.WriteLine("Selecione a opção: \n\n> 1 - Nova Exploração\n> 2 - Sair");
            op = Console.ReadKey().KeyChar;

            while (op == '1')
            {
                Console.Write("\n\nDefinir área, limite X: ");
                areax = int.Parse(Console.ReadLine());
                Console.Write("Definir área, limite Y: ");
                areay = int.Parse(Console.ReadLine());

                Console.Write("\nEntre com a posição Inicial: ");
                entrada = Console.ReadLine().ToUpper();
                entrada.ToCharArray();
                px = (int)Char.GetNumericValue(entrada[0]);
                py = (int)Char.GetNumericValue(entrada[2]);
                orient = entrada[4];

                Console.Write("\nMovimentos: ");
                mov = Console.ReadLine().ToUpper();
                mov.ToCharArray();

                for (int i = 0; i < mov.Length; i++)
                {
                    switch (mov[i])
                    {
                        case 'E':
                            switch (orient)
                            {
                                case 'N':
                                    orient = 'O';
                                    break;
                                case 'S':
                                    orient = 'L';
                                    break;

                                case 'L':
                                    orient = 'N';
                                    break;

                                case 'O':
                                    orient = 'S';
                                    break;
                            }
                            break;
                        case 'D':
                            switch (orient)
                            {
                                case 'N':
                                    orient = 'L';
                                    break;
                                case 'S':
                                    orient = 'O';
                                    break;

                                case 'L':
                                    orient = 'S';
                                    break;

                                case 'O':
                                    orient = 'N';
                                    break;
                            }
                            break;
                        case 'M':
                            switch (orient)
                            {
                                case 'N':
                                    px += 1;
                                    if (px > areax) px = areax;
                                    if (px < 0) px = 0;
                                    break;

                                case 'S':
                                    px -= 1;
                                    if (px > areax) px = areax;
                                    if (px < 0) px = 0;
                                    break;

                                case 'L':
                                    py += 1;
                                    if (py > areay) py = areay;
                                    if (py < 0) py = 0;
                                    break;
                                case 'O':
                                    py -= 1;
                                    if (py > areay) py = areay;
                                    if (py < 0) py = 0;
                                    break;
                            }
                            break;
                    }
                }

                Console.Write("\nPosição final: " + px + "," + py + "," + orient + "\n");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Selecione a opção: \n\n> 1 - Nova Exploração\n> 2 - Sair");
                op = Console.ReadKey().KeyChar;
            }

            Environment.Exit(0);
        }
    }
}
