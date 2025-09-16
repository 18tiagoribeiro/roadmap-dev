using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_Logica;

public class ControleDeFluxo
{
    public void VerificarMaiorNumero()
    {
        Console.WriteLine("Verificação de maior e menor");
        Console.WriteLine("Digite um numero");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero");
        int numero2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ultimo numero");
        int numero3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Verificando qual número é maior: {numero1}, {numero2} ou {numero3}");
        if (numero1 >= numero2 && numero1 >= numero3)
        {
            Console.WriteLine($"o numero {numero1} é maior que o {numero2} e o {numero3}");
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            Console.WriteLine($"o numero {numero2} é maior do que o {numero1} e o {numero3}");
        }
       
        else
        {
            Console.WriteLine($"o numero {numero3} é maior do que o numero {numero1} e o numero {numero2}");
        }
    }

    public void MediaDeNotas()
    {
        Console.WriteLine("Verificação de média");
        Console.WriteLine("Digite a primeira nota");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira e ultima nota");
        double nota3 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"A média das notas {nota1}, {nota2} e {nota3} é {media}");

        Console.WriteLine("Verificando notas...");

        if (media >= 7)
        {
            Console.WriteLine("\nAluno Aprovado");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("\nAluno de Recuperação");
        }
        else
        {
            Console.WriteLine("\nAluno Reprovado");
        }

    }

    public void Crescente()
    {
        Console.WriteLine("Verificação de números crescentes");
        Console.WriteLine("Digite um numero entre 0 a 10");
        int numeroCrescente = int.Parse(Console.ReadLine());
        
        if (numeroCrescente < 0 || numeroCrescente > 10)
        {
            Console.WriteLine("Número inválido, digite um número entre 0 e 10");
            return;
        }

        Console.WriteLine("\nOrdem Crescente:");
        while (numeroCrescente < 10)
        {
            numeroCrescente ++;
            // ou apenas numeroInicial, neste caso ele repetirá o valor de numeroInicial
            Console.WriteLine(numeroCrescente);
        }
    }

}
