using System;
using System.Text;
namespace HamzasAlphabetReader
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderAlphabetQuicker();

            //These methods run with slightly more performance stress than only using 'A' & 'Z' in the for loop.
            RenderAlphabetWithoutStringBuilder();

            RenderAlphabet();

            RenderAlphabetSkipped();

            RenderAlphabetBackwards();
        }
        private static void RenderAlphabetQuicker()
        {
            StringBuilder sb = new StringBuilder();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                sb.Append(letter);
            }

            Console.WriteLine(sb.ToString());
        }
        private static void RenderAlphabetWithoutStringBuilder()
        {
            string alphabetString = "";
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetString += i.ToString();
                }

            }
            Console.WriteLine(alphabetString);
        }



        private static void RenderAlphabet()
        {
            StringBuilder alphabetString = new StringBuilder();
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetString.Append(i);
                }

            }
            Console.WriteLine(alphabetString.ToString());
        }



        private static void RenderAlphabetSkipped()
        {
            StringBuilder alphabetString = new StringBuilder();
            char letter = 'A';
            while (letter <= 'Z')
            {
                alphabetString.Append(letter);
                letter++;
                letter++;
            }
            Console.WriteLine(alphabetString.ToString());
        }



        private static void RenderAlphabetBackwards()
        {
            StringBuilder alphabetstring = new StringBuilder();
            for (char i = char.MaxValue; i > char.MinValue; i--)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetstring.Append(i);
                }

            }
            Console.WriteLine(alphabetstring.ToString());
        }
    }
}