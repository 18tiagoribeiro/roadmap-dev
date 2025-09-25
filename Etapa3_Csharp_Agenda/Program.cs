

List<Compromisso> agenda = new List<Compromisso>();

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu telefone: ");
string telefone = Console.ReadLine();

Console.WriteLine("Digite a data que quer agendar (AAAA-MM-DD): ");
DateTime data = DateTime.Parse(Console.ReadLine());

if (data >= DateTime.Now)
{
    Compromisso novo = new Compromisso(nome, telefone, data);
    agenda.Add(novo);
    Console.WriteLine("Compromisso cadastrado com sucesso");
}
else
{
    Console.WriteLine("Data invalida. Não é possivel agendar em uma data passada.");
}

foreach (Compromisso item in agenda)
{
    Console.WriteLine("\n--- Compromisso ---");
    item.Mostrar();
}
