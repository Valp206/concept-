
using Shared;

var answer = string.Empty;

var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtenison.GetInt("Ingrese numero entero diferente de cero: ");
    if (number == 0)
    {
        continue;

    }
    if (number % 2 == 0)

    {
        Console.WriteLine($"El numero {number}, es par");

    }
    else
    {
        Console.WriteLine($"El numero {number}, es impar.");
    }
    do
    {
        answer = ConsoleExtenison.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
}  while(answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over.");