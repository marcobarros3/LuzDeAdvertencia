using System;

class Program {
  public static void Main (string[] args) {
      
            Console.Clear();

            Console.WriteLine("---- Luz De Advertência ----\n");

            string
            t, // Temperatura
            p, // Pressão
            r; // Rotação

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
            Console.ResetColor();

            Console.WriteLine("Digite[A] para Ativado, Digite[D] para Desativado");

            Console.Write("Sensor de temperatura...:");
            t = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (t != "A" && t != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }

            Console.Write("Sensor de Pressão.......:");
            p = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (p != "A" && p != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }            

            Console.Write("Sensor de Rotação...:");
            r = Console.ReadLine().ToUpper().Trim().Substring(0,1)!;
            if (r != "A" && r != "D")
            {
                Console.WriteLine("Situação inválida , digite A para Ativado ou D para desativado");
                return;
            }
            Console.WriteLine();
            

            if (t == "A" && (p == "A" || r == "D"))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Luz de advertência ATIVADA");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine("Luz de advertência DESATIVADA");
            }
        }
    }
