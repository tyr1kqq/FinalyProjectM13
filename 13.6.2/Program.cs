using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _13._6._2
{
    class Program
    {
        static void Main()
        {
            string FilePath = @"C:\\Users\tyr1k_qq\Desktop\List\test.txt";
            string text = File.ReadAllText(FilePath);

            string[] sings = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in sings)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            var topWords = wordCount.OrderByDescending(pair => pair.Value).Take(10);

            
            Console.WriteLine("Наиболее часто встречающиеся слова:");
            foreach (var wordPair in topWords)
            {
                Console.WriteLine($"{wordPair.Key} - {wordPair.Value} раз");
            }
        }
    }
}