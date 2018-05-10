using System;

namespace Aula_10_05_18_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Aula_10_05_18_POO.Cliente();
            cli.Nome = "Mario"; //set
            string nomeCliente = cli.Nome; //get

            cli.Cpf = "12345678909";
            string cpfCliente = cli.Cpf;

            Console.WriteLine(cli.Cpf);
            Console.WriteLine(cli.Nome);
            
            Cliente cli1 = new Aula_10_05_18_POO.Cliente("abc");
            Console.WriteLine("clie1.Nome:" + cli1.Nome);


        }
    }
}
