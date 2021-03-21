using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Por favor, digite o valor da base: ");
            String b = Console.ReadLine();

            Console.Write("Agora digite a valor da altura: ");
            String h = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Double vlBase = Convert.ToDouble(b);
            Double vlAltura = Convert.ToDouble(h);
            Double area = vlBase * vlAltura / 2;
            Console.WriteLine($"O valor da área é {area}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("toque em uma tecla para limpar a tela...");
            Console.ReadKey();
            
            Console.Clear();
        }
    }
}
