
public class Compromisso
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime Data { get; set; }

    public Compromisso(string nome, string telefone, DateTime data)
    {
        Nome = nome;
        Telefone = telefone;
        Data = data;
    }

    public void Mostrar()
    {
        Console.WriteLine($"Sr(a) {Nome}, cadastrado com o Telefone: {Telefone}");
        Console.WriteLine($"Na data escolhida: {Data}");
        Console.Write($"Muito obrigado!");
        Console.WriteLine();
    }
}



