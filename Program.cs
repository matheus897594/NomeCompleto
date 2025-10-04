Console.Clear();
Console.Write("Digite seu Nome: ");
string nome = Console.ReadLine()!;
Console.Write("Digite seu Sobrenome: ");
string sobrenome = Console.ReadLine()!;
Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
