using System;
using System.IO;
using System.Text;
using System.Linq;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charToReplace = { '-', ',', '.', '!', '?' };

            using StreamReader reader = new StreamReader("text.txt");
            using StreamWriter writer = new StreamWriter("../../../output.txt");

            int count = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    line = ReplaceAll(charToReplace, '@', line);
                    line = Reverse(line);
                    writer.WriteLine(line);
                    Console.WriteLine(line);
                }
                count++;
            }

        }

        static string Reverse(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] word = line.Split(' ').ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                stringBuilder.Append(word[word.Length - i - 1]);
                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString().TrimEnd();
        }

        static string ReplaceAll(char[] charToReplace, char v, string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];
                if (charToReplace.Contains(currSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currSymbol);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
