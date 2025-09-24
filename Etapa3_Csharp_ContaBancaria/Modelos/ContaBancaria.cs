using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3_Csharp.Modelos;

public class ContaBancaria
{
    public int NumeroConta {  get; set; }
    public Cliente Titular { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria (int numeroConta, Cliente titular)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0.0;
    }

    public void Depositar (double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {Titular.Nome} || CPF: {Titular.CPF} || Data de Nascimento: {Titular.DataNascimento}");
        Console.WriteLine($"Telefone para contato: {Titular.Telefone}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
    }
}
