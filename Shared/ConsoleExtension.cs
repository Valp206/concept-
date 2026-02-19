using System.Security.Cryptography.X509Certificates;

namespace Shared
{
    public class ConsoleExtenison
    {
        public static int GetInt(string message)
        {
            Console.Write(message);
            var numberString = Console.ReadLine();
            if (int.TryParse(numberString, out int numberint))
            {
                return numberint;
            }
            return 0;
        }



        public static string? GetValidOptions(string message, List<string> options)//public static string? la ? es para validar nulidad
        {
            Console.Write(message);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))// funcion any para validar si la respuesta del usuario es igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula
            {
                return answer;

            }

            return null;

        }
    }
}

