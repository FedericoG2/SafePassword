using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePassword
{
    internal class PasswordGenerator
    {
        private static readonly string DefaultChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly string SpecialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";

        public static string GeneratePassword(int length, bool includeSpecialChars = true, bool includeNumbers = true)
        {
            StringBuilder charSet = new StringBuilder(DefaultChars);

            if (includeSpecialChars)
            {
                charSet.Append(SpecialChars);
            }

            if (!includeNumbers)
            {
                charSet = charSet.Replace("0123456789", "");
            }

            return GeneratePasswordFromCharSet(charSet.ToString(), length);
        }

        private static string GeneratePasswordFromCharSet(string charSet, int length)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charSet.Length);
                password.Append(charSet[index]);
            }

            return password.ToString();
        }
    }
}
