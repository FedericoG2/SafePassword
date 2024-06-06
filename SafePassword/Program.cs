using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generador de Contraseñas Seguras");

            Console.Write("Ingrese la longitud de la contraseña: ");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
                Console.Write("Ingrese la longitud de la contraseña: ");
            }

            Console.Write("¿Incluir caracteres especiales? (s/n): ");
            bool includeSpecialChars = Console.ReadLine().ToLower() == "s";

            Console.Write("¿Incluir números? (s/n): ");
            bool includeNumbers = Console.ReadLine().ToLower() == "s";

            string password = PasswordGenerator.GeneratePassword(length, includeSpecialChars, includeNumbers);

            Console.WriteLine($"Contraseña generada: {password}");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
