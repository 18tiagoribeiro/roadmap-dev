using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_Logica;

public class Numeral
{
    public void NumerosPrimos() 
    {
        Console.WriteLine("Verificação de números Primos");
        Console.WriteLine("Digite um numero");
        int n = int.Parse(Console.ReadLine());


        bool EhPrimo(int numero)
        {
            if (numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        for (int i = 1; i <= n; i++)
        {
            if (EhPrimo(i))
            {
                Console.WriteLine(i);
            }
        }


    }

    public void Fatorial()
    {
        Console.WriteLine("Verificação de números fatoriais");
        Console.WriteLine("Digite um numero");
        int numeroFatorial = int.Parse(Console.ReadLine());

        int Fatorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;
            int fatorial = 1;
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
                
            }
            return fatorial;
        }
        int resultado = Fatorial(numeroFatorial);
        Console.WriteLine($"O fatorial de {numeroFatorial} é {resultado}");
    }

}
