Console.WriteLine("Digite um texto:");
string text = Console.ReadLine().ToLower();

int total = 0;

foreach (char c in text)
{
if (c >= 'a' && c <= 'z')
{
total++;
}
}

Console.WriteLine($"Total de letras: {total}");