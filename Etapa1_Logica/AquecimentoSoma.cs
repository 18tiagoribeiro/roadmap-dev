using System;

namespace Etapa1_Logica;

public class AquecimentoSoma
{
    public void Soma()
    {
        Console.WriteLine("Aquecimento - Soma de dois números");
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());
        int soma = numero1 + numero2;
        Console.WriteLine($"A soma de {numero1} + {numero2} é {soma}");
    }

    public void ParOuImpar()
    {
        Console.WriteLine("Aquecimento - Verificar se um número é par ou ímpar");
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
        }
    }

    public void Tabuada()
    {
        Console.WriteLine("Aquecimento - Tabuada de um número");
        Console.Write("Digite um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}


