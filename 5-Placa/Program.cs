using System.Text.RegularExpressions;

Console.Write("Digite a placa: ");
string placa = Console.ReadLine();

static bool ValidarPlacaAntiga(string placa)
{    
    string padrao = @"^[A-Za-z]{3}-?[0-9]{4}$";
    Regex regex = new Regex(padrao);
        
    return regex.IsMatch(placa);
}

bool ehValida = ValidarPlacaAntiga(placa);
Console.WriteLine($"Placa {placa}: {(ehValida ? "Verdadeiro" : "Falso")}");