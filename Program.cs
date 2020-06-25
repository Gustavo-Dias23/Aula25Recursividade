using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade sequencia = new Recursividade();
            System.Console.WriteLine($"Sequência Fibonacci:");
            sequencia.GerarSequenciaFibonacci(0, 1, 10);
            System.Console.WriteLine();
            Console.WriteLine($"Fatorial: {sequencia.GerarFatorial(8)}");
        }
    }
}
