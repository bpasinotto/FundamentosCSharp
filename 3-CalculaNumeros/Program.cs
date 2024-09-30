Console.Write("Insira o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Insira o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("A soma entre esses dois números é: " + (num1 + num2));
Console.WriteLine("A subtração entre os dois números é: " + (num1 - num2));
Console.WriteLine("A multiplicação entre os dois números é: " + (num1 * num2));
if (num2 == 0)
{
    Console.WriteLine("Não é possivel divisão por 0");
}
else
{
    Console.WriteLine("A divisão entre os dois números é: " + (num1 / num2));
}
Console.WriteLine("A média entre os dois números é: " + ((num1 + num2) / 2));
