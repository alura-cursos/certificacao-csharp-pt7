using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            });
            Console.WriteLine("A tarefa está executando...");
            Console.ReadKey();
        }
    }
}