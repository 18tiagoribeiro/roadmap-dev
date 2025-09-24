using Etapa3_Csharp.Modelos;
using System;

class Program
{
    static void Main()
    {
        Cliente cliente1 = new Cliente("Tiago Ribeiro", "58874698512", new DateTime (2002, 05, 8), "11956650244");
        ContaBancaria contaBancaria1 = new ContaBancaria(1935, cliente1);

        Cliente cliente2 = new Cliente("Carolina Marques", "65889965425", new DateTime(2000, 06, 29), "11965442889");
        ContaBancaria contaBancaria2 = new ContaBancaria(1936, cliente2);

        contaBancaria1.Depositar(1500);
        contaBancaria2.Depositar(2000);

        contaBancaria1.Sacar(1000);

        contaBancaria1.ExibirDados();
        Console.WriteLine();
        contaBancaria2.ExibirDados();

    }
}
