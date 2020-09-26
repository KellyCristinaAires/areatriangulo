using System;

namespace areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
        double B;
        double H;
        double A;

        Console.Write("Digite o valor da base ");
        B = double.Parse(Console.ReadLine());
         
        Console.Write("Digite o valor da altura ");
        H = double.Parse(Console.ReadLine());
        Console.Write("\n");

        Console.WriteLine ($"A área do triangulo é: {A = B * H /2} ");

        Console.WriteLine ("Pressione para sair!");
        Console.ReadKey();
        }
    }
}

            
             




