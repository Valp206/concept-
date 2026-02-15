// See https://aka.ms/new-console-template for more information

//var es una funcion qeu sirve para definir una variable
//console read line es la funcion que permite que el usuario digite el valor
var numberString = string.Empty;
do
{
    Console.Write("Ingrese Numero o presiones  'Salir' para salir de la ejecucion:");
    numberString = Console.ReadLine();


    if (numberString!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;

    //convertimos el String en number con la funcion parse
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"el numero {numberInt} es par.");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt} es Impar.");
        }

    }
    else
    {
        Console.WriteLine($"el valor que dijistate {numberString}, no es un numero entero.");
    }




} while (numberString!.ToLower() != "salir");
Console.WriteLine("F mi loco");