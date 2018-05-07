using System;

namespace Aula_07_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            Console.WriteLine("Hello World!");
            Console.WriteLine("a : " + a);

            if (Console.CapsLock)
                Console.WriteLine("CapsLock: Ativado.");
            else
                Console.WriteLine("CapsLock: Desatvado.");

            Console.ReadKey();

        }
    }
}
