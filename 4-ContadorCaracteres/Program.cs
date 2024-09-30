Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();

if (palavra.Length > 1)
{    
    Console.WriteLine($"A(s) palavra(s) '{palavra}' tem {palavra.Replace(" ", "").Length} caracteres");
}
else
{
    Console.WriteLine("Não foi digitada uma palavra.");
}
