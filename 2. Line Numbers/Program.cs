using System;
using System.IO;


namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("text.txt");

            for (int i = 0; i < line.Length; i++)
            {
                string currLine = line[i];
                int letterCount = CountOfLetters(currLine);
                int punctionalCount = PuntionalCharCount(currLine);
                line[i] = $"Line {i + 1}: {currLine} ({letterCount}) ({punctionalCount})";
            }
            File.WriteAllLines("../../../output.txt", line);
        }

        static int PuntionalCharCount(string currLine)
        {
            int count = 0;
         
            for (int i = 0; i < currLine.Length; i++)
            {
                char currChar = currLine[i];
                if (char.IsPunctuation(currChar))
                {
                    count++;
                }

            }

            return count;
        }

        static int CountOfLetters(string currLine)
        {
            int count = 0;
            for (int i = 0; i < currLine.Length; i++)
            {
                char currChar = currLine[i];
                if (char.IsLetter(currChar))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
