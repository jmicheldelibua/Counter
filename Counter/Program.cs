using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        public static string GetCurrentCaracter(string text, int startIndex, int length)

        {
            string toReturn = text.Substring(startIndex, length);

            return toReturn;

        }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.

            string text;
            string lastResult = "";
            int i = 0;

            // we save the vowels in array

            int[] vowels = { 0, 0, 0, 0, 0 };

            Console.Write("Please, Enter a text : ");

            text = Console.ReadLine();

            // we find each caracter in de text

            for (i = 1; i < text.Length; i++)
            {
                switch (GetCurrentCaracter(text.ToUpper(), i, 1))
                {
                    case "A":
                        vowels[0] += 1;
                        break;
                    case "E":
                        vowels[1] += 1;
                        break;
                    case "I":
                        vowels[2] += 1;
                        break;
                    case "O":
                        vowels[3] += 1;
                        break;

                    case "U":
                        vowels[4] += 1;
                        break;
                }

            }

     
            if (vowels[0] > 0)
            {
                lastResult += "a -> "+ vowels[0]; 
                
            }

            if (vowels[1] > 0)
            {
                lastResult += ", e -> " + vowels[1];
            }

            if (vowels[2] > 0)
            {
                lastResult += ", i -> " + vowels[2];
            }

            if (vowels[3] > 0)
            {
                lastResult += ", o -> " + vowels[3];
            }

            if (vowels[4] > 0)
            {
                lastResult += ", u -> " + vowels[4];
            }
            Console.WriteLine(lastResult);
            Console.ReadLine();
        }
    }
}
