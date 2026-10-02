using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    internal class StringsTasks
    {
        public static void LineStatistic(string line)
        {
            int letters = 0;
            int digits = 0;
            int spaces = 0;
            int others = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char current = line[i];
                if (char.IsLetter(current))
                {
                    letters++;
                }
                else if (char.IsDigit(current))
                {
                    digits++;
                }
                else if (current == ' ')
                {
                    spaces++;
                }
                else
                {
                    others++;
                }
            }

        }
        public static void FindRichestWord(string text)
        {
            string[] words = text.Split(' ');
            string richword = "";
            int maxprice = 0;
            for ( int i = 0; i< words.Length; i++)
            {
                int price = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    price += (int)words[i][j];
                }
                if (price > maxprice)
                {
                    maxprice = price;
                    richword = words[i];
                }
            }
            Console.WriteLine($"{richword} ({maxprice})");

        }
        public static void RemoveShortWords(string text)
        {
            string[] words = text.Split(' ');
            bool firstword = true;
            for ( int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3)
                {
                    if (!firstword)
                    {
                        Console.Write(",");
                    }

                    Console.Write(words[i]);

                    firstword = false;
                }
            }
            Console.WriteLine();
            
        }
        public static void RemoveExtraSpaces(string text)
        {
            string result = "";
            bool previousWasSpace = false;

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (current == ' ')
                {
                    if (!previousWasSpace && result.Length > 0)
                    {
                        result += current;
                        previousWasSpace = true;
                    }
                }
                else
                {
                    result += current;
                    previousWasSpace = false;
                }
            }

            Console.WriteLine(result);
        }
    }
}
