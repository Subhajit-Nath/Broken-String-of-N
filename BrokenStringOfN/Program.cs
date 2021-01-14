using System;
using System.Text;

/*
 * Breaks the string with n ignoring the spaces.
 * Hello World! - with n of 3 becomes:
 * Hel
 * loW
 * orl
 * d!
 */
namespace BrokenStringOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakByN(3, "Hello World!"));
        }

        public static string BreakByN(int n, string str)
        {
            if(str.Length < n)
            {
                return str;
            }

            var withoutSpaces = str.Replace(" ", string.Empty);
            var brokenString = new StringBuilder();

            for (int i = 0; i < withoutSpaces.Length; i++)
            {
                brokenString.Append(withoutSpaces[i]);
                if (i != 0 && (i + 1) % n == 0 && i < withoutSpaces.Length - 1)
                {
                    brokenString.Append("\n");
                }
            }
            return brokenString.ToString();
        }
    }
}
