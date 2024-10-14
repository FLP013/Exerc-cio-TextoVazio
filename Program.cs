string TextoVazio;

Console.Clear();

Console.WriteLine("--- TEXTO VAZIO ---");

Console.Write("Digita um texto vazio:");
TextoVazio = Console.ReadLine()!;

Console.WriteLine(String.IsNullOrEmpty(TextoVazio));