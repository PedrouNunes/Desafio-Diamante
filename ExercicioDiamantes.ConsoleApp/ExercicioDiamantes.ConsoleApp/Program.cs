using System;

namespace ExercicioDiamantes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, metade, qntEspacos, qntX = 1;
            do {
                Console.Write("Digite o número ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }while (numero % 2 == 0);

            qntEspacos = (numero - 1) / 2;
            metade = numero / 2;
            for (int i = 0; i <= metade; i++)
            {
                for (int j = 0; j < qntEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < qntX; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                qntX = qntX + 2;
                qntEspacos = qntEspacos - 1;   
            }
            qntX = numero;
            qntEspacos = 0;
            for(int i = 0;i < metade; i++)
            {
                qntX = qntX - 2;
                qntEspacos = qntEspacos + 1;
                for (int j = 0; j < qntEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < qntX; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                
            }
        
        }
    }
}
