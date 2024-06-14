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

            int length = GetPositiveInteger("Ingrese la longitud de la contraseña: ");
            bool includeSpecialChars = GetYesOrNo("¿Incluir caracteres especiales? (s/n): ");
            bool includeNumbers = GetYesOrNo("¿Incluir números? (s/n): ");

            string password = PasswordGenerator.GeneratePassword(length, includeSpecialChars, includeNumbers);
            Console.WriteLine($"Contraseña generada: {password}");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static int GetPositiveInteger(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo.");
                Console.Write(prompt);
            }
            return value;
        }

        static bool GetYesOrNo(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            while (input != "s" && input != "n")
            {
                Console.WriteLine("Por favor, ingrese 's' para sí o 'n' para no.");
                Console.Write(prompt);
                input = Console.ReadLine().ToLower();
            }
            return input == "s";
        
    }
    }
}
