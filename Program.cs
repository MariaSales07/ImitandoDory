Console.WriteLine("---Imitando Dory---\n");

Console.Write("Digite uma frase:");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
        .Replace ("a", "aaa")
        .Replace ("A", "AAA")
        .Replace ("E", "EEE")
        .Replace ("e", "eee")
        .Replace ("o", "ooo")
        .Replace ("O", "OOO")
        .Replace ("I", "III")
        .Replace ("i", "iii")
        ;

Console.WriteLine($"\nEm baleies:\n\n{fraseEmBaleies}");
