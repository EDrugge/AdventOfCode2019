using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfValidPasswords = 0;

            var passwordValidator = new PasswordValidator();

            foreach (var i in Sequence(264793, 803935))
            {
                if (passwordValidator.IsValid(i.ToString()))
                {
                    numberOfValidPasswords++;
                }
            }

            Console.WriteLine($"Number of valid passwords: {numberOfValidPasswords}");
        }

        private static IEnumerable<int> Sequence(int n1, int n2)
        {
            while (n1 <= n2)
            {
                yield return n1++;
            }
        }
    }
}
