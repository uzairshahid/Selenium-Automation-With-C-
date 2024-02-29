using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharpAndNUnit.Utils
{
    public class Utilities
    {
        static string GenerateRandomPassword()
        {
            // Define the characters for each category
            string upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";

            // Choose one character from each category
            char upperChar = GetRandomChar(upperAlphabet);
            char lowerChar = GetRandomChar(lowerAlphabet);
            char numberChar = GetRandomChar(numbers);

            // Combine characters and generate the remaining random characters
            string remainingChars = GetRandomString(3, upperAlphabet + lowerAlphabet + numbers);

            // Combine all characters to form the password
            string password = $"{upperChar}{lowerChar}{numberChar}{remainingChars}";

            // Shuffle the characters to make it more random
            char[] passwordArray = password.ToCharArray();
            Random rng = new Random();
            int n = passwordArray.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char temp = passwordArray[k];
                passwordArray[k] = passwordArray[n];
                passwordArray[n] = temp;
            }

            return new string(passwordArray);
        }

        static char GetRandomChar(string source)
        {
            Random rng = new Random();
            return source[rng.Next(source.Length)];
        }

        static string GetRandomString(int length, string source)
        {
            Random rng = new Random();
            return new string(Enumerable.Repeat(source, length)
              .Select(s => s[rng.Next(s.Length)]).ToArray());
        }
    }
}
