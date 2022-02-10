using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] posInicRobo = new char[5];
            string[] historico = new string[5];
            int resultadoAleatorio;
            int contador = 0;
            string robo = " ";
            string posicao;
            int m = 0;
            string giroupara = " ";
            int calc = 0;
            int h = 0;

            Console.WriteLine("----------- PROJETO TUPINIQUIM.\n");
            Console.WriteLine("1 - NOVA EXPLORAÇÃO >\n2 - SAIR >");
            Console.WriteLine("\n(tecle 1 ou 2)");
            char op = Console.ReadKey().KeyChar;

            while (op == '1')
            {
                
                // Identificar robô
                Random aleatorio = new Random();
                Console.WriteLine("\n\nIniciando Robô...         (tecle)\n");
                Console.ReadKey();
                Console.WriteLine("Identificando Robô...     (tecle)\n");
                Console.ReadKey();
                resultadoAleatorio = aleatorio.Next(1, 6);

                switch (resultadoAleatorio)
                {
                    case 1:
                        robo = "Bot_Zeus_" + contador;
                        contador++;
                        break;
                    case 2:
                        robo = "Bot_Apolo_" + contador;
                        contador++;
                        break;
                    case 3:
                        robo = "Bot_Artemis_" + contador;
                        contador++;
                        break;
                    case 4:
                        robo = "Bot_Afrodite_" + contador;
                        contador++;
                        break;
                    case 5:
                        robo = "Bot_Atena_" + contador;
                        contador++;
                        break;
                }
                Console.Write("O Robô foi identificado como: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(robo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("    (tecle)\n\n");
                Console.ReadKey();
                Console.Clear();


                // Coordenadas do campo de exploração.
                Console.Write("Identificando o espaço de exploração para ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(robo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(":\n");
                Console.WriteLine("Atenção, a coordenada X não pode ser maior que a coordenada Y,");
                Console.Write("> Digite a coordenada X: ");
                int coordX = ushort.Parse((Console.ReadLine()));
                Console.Write("> Digite a coordenada Y: ");
                int coordY = ushort.Parse((Console.ReadLine()));

                Console.Write("\nO campo de exploração está limitado às seguintes coordenadas: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(coordX + "," + coordY + "\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("MODELO DE CAMPO:\n");

                int j = 0;
                for (int i = 0; i < coordX; i++)
                {
                    for (j = 0; j < coordY; j++)
                    {
                        Console.Write("0");
                    }
                    if (j >= coordX)
                    {
                        int temp = coordX - 1;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" -" + (temp - i));
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("▲");

                //Iniciando outra matriz caso precise
                string[,] matriz = new string[coordY, coordX];
                for (int i = 0; i < coordX; i++)
                {
                    for (j = 0; j < coordY; j++)
                    {
                        matriz[j, i] = ("0");
                    }
                }
                
                //posição do robô.
                Console.WriteLine("(Ponto 0,0 - Inferior Esquerdo)");
                Console.WriteLine("\n(Coluna,Linha,Orientação - N,S,L,O)");
                Console.Write("Entre com a coordeanda de posição inicial do robô (exemplo 1,2,N): ");
                posicao = Console.ReadLine();
                posicao.Split(',');

                for (int i = 0; i < posInicRobo.Length; i++)
                {
                    
                    posInicRobo[i] = posicao[i];
                }

                string[] vetor = { posInicRobo[0].ToString(), posInicRobo[2].ToString() };
                int a = int.Parse(vetor[0]);
                int b = int.Parse(vetor[1]);

                while (a > (coordY - 1) || b > (coordX - 1))
                {

                    if (a > coordY)
                    {
                        Console.WriteLine("\nO número excede o tamanho na coordenada Y - Tamanho máximo: " + coordY);
                    }
                    else if (b > coordX)
                    {
                        Console.WriteLine("\nO número excede o tamanho na coordenada X - Tamanho máximo: " + coordX);
                    }

                    
                    Console.Write("\nEntre com a coordeanda de posição inicial do robô (exemplo 1,2,N): ");
                    posicao = Console.ReadLine();
                    posicao.Split(',');

                    for (int i = 0; i < posInicRobo.Length; i++)
                    {
                        posInicRobo[i] = posicao[i];
                    }

                    vetor[0] = posInicRobo[0].ToString();
                    vetor[1] = posInicRobo[2].ToString();
                    a = int.Parse(vetor[0]);
                    b = int.Parse(vetor[1]);
                }

                while (posInicRobo[4] != 'N' && posInicRobo[4] != 'S' && posInicRobo[4] != 'L' && posInicRobo[4] != 'O' && posInicRobo[4] != 'n' && posInicRobo[4] != 's' && posInicRobo[4] != 'l' && posInicRobo[4] != 'o')
                {
                    if (posInicRobo[4] != 'N' && posInicRobo[4] != 'S' && posInicRobo[4] != 'L' && posInicRobo[4] != 'O' && posInicRobo[4] != 'n' && posInicRobo[4] != 's' && posInicRobo[4] != 'l' && posInicRobo[4] != 'o')
                    {
                        Console.WriteLine("\nComando de Orientação inválido!\n");
                        Console.Write("\nEntre com a coordeanda de posição inicial do robô (exemplo 1,2,N): ");
                        posicao = Console.ReadLine();
                        posicao.Split(',');

                        for (int i = 0; i < posInicRobo.Length; i++)
                        {
                            posInicRobo[i] = posicao[i];
                        }

                    }
                 
                }
      
                Console.Write("\nA posição inicial do robô será: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(posicao + "\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("('E' Girar 90º à esquerda, 'D' Girar 90º à direita, 'M' Mover 1 para frente)");
                Console.Write("\nEntre com a coordeanda de movimentação do robô ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(robo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");
                string coordMovimento = Console.ReadLine();
                Console.WriteLine();
                coordMovimento.Split(",");

                char[] vetorMovimento = new char[100];

                for (int i = 0; i < coordMovimento.Length; i++)
                {
                    vetorMovimento[i] = coordMovimento[i];
                }

                //
                string[] posfinal = new string[5];
                posfinal[0] = posInicRobo[0].ToString();
                posfinal[2] = posInicRobo[2].ToString();
                posfinal[4] = posInicRobo[4].ToString();
                posfinal[1] = ",";
                posfinal[3] = ",";

                for (int i = 0; i < vetorMovimento.Length; i++)
                {
                    if (vetorMovimento[i] == 'E' || vetorMovimento[i] == 'e')
                    {
                        giroupara = "oeste";

                    }
                    else if (vetorMovimento[i] == 'D' || vetorMovimento[i] == 'd')
                    {
                        giroupara = "leste";

                    }
                    else if (vetorMovimento[i] == 'M' || vetorMovimento[i] == 'm')
                    {
                        switch (giroupara)
                        {
                            case "leste":
                                if (posfinal[4] == "n" || posfinal[4] == "N")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[2]);
                                    calc += m+1;
                                    posfinal[2] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "L";

                                }
                                else if (posfinal[4] == "s" || posfinal[4] == "S")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[2]);
                                    calc -= m+1;
                                    posfinal[2] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "O";
                                }
                                else if (posfinal[4] == "l" || posfinal[4] == "L")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[0]);
                                    calc -= m+1;
                                    posfinal[0] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "S";
                                }
                                else if (posfinal[4] == "o" || posfinal[4] == "O")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[0]);
                                    calc += m+1;
                                    posfinal[0] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "N";
                                }
                                break;

                            case "oeste":
                                if (posfinal[4] == "n" || posfinal[4] == "N")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[2]);
                                    calc -= m+1;
                                    posfinal[2] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "O";
                                }
                                else if (posfinal[4] == "s" || posfinal[4] == "S")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[2]);
                                    calc += m+1;
                                    posfinal[2] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "L";
                                }
                                else if (posfinal[4] == "l" || posfinal[4] == "L")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[0]);
                                    calc += m+1;
                                    posfinal[0] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "N";
                                }
                                else if (posfinal[4] == "o" || posfinal[4] == "O")
                                {
                                    m++;
                                    calc = int.Parse(posfinal[0]);
                                    calc -= m+1;
                                    posfinal[0] = calc.ToString();
                                    m = 0;
                                    posfinal[4] = "S";
                                }
                                break;

                        }//fim switch
                        
                    }// fim se "M"
                   
                }// fim for vetorMovimento

                int c = int.Parse(posfinal[0]);
                int d = int.Parse(posfinal[2]);


                if (c < 0)
                {
                    Console.WriteLine("O movimento excedeu o limite de Campo de Exploração! A posição será corrigida ao limite do campo\n");
                    c = 0;
                    posfinal[0] = c.ToString();
                    Console.ReadKey();

                }
                else if (c > (coordY - 1))
                {
                    Console.WriteLine("O movimento excedeu o limite de Campo de Exploração! A posição será corrigida ao limite do campo.\n");
                    c = coordY-1;
                    posfinal[0] = c.ToString();
         

                }
                else if (d < 0)
                {
                    Console.WriteLine("O movimento excedeu o limite de Campo de Exploração! A posição será corrigida ao limite do campo.\n");
                    d = 0;
                    posfinal[2] = c.ToString();
         
                }
                else if (d > (coordX - 1))
                {
                    Console.WriteLine("O movimento excedeu o limite de Campo de Exploração! A posição será corrigida ao limite do campo.\n");
                    d = coordX-1;
                    posfinal[2] = c.ToString();
                    
                }

                string final ="";
                Console.Write("A posição final é: ");

                for (int i = 0; i < posfinal.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(posfinal[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    final += posfinal[i];
                }

                historico[h] = robo + " -> posição final: " + final;
                h++;
                h = h == 6 ? h = 0 : h++;

                Console.ReadKey();
                Console.Clear();

                #region histórico
                Console.SetCursorPosition(80, 3);
                Console.WriteLine("HISTÓRICO - das últimas 5 posições:");
                Console.SetCursorPosition(80, 5);
                Console.WriteLine(historico[0]);
                Console.SetCursorPosition(80, 6);
                Console.WriteLine(historico[1]);
                Console.SetCursorPosition(80, 7);
                Console.WriteLine(historico[2]);
                Console.SetCursorPosition(80, 8);
                Console.WriteLine(historico[3]);
                Console.SetCursorPosition(80, 9);
                Console.WriteLine(historico[4]);
                Console.SetCursorPosition(0, 0);
                #endregion


                Console.WriteLine("----------- PROJETO TUPINIQUIM.\n");
                Console.WriteLine("1 - NOVA EXPLORAÇÃO >\n2 - SAIR >");
                Console.WriteLine("\n(tecle 1 ou 2)");
                op = Console.ReadKey().KeyChar;


            }//fim while op

           
            if (op == '2')
            {
                Console.Clear();
                Console.WriteLine("\nPrograma finalizado!");
                
            }
            else if (op != '1' && op != '2')
            {
                Console.WriteLine("\n\nOpção incorreta!");

            }

            Console.ReadKey();

        }
    }
}
