using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;

namespace SimpleCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            Console.WriteLine(PrintVertically(s));
        }

        static IList<string> PrintVertically(string s)
        {
            List<string> word = new List<string>(s.Split(' '));
            List<string> newWord = new List<string>();

            int maxLen = word.Max(x => maxLen = x.Length);

            for (int i = 0; i < word.Count; i++)
            {
                word[i] = word[i].PadRight(maxLen);
            }

            string newWordStr = "";
            for (int j = 0; j < maxLen; j++)
            {
                for (int i = 0; i < word.Count; i++)
                {                  
                    newWordStr += word[i][j];
                }
                newWordStr = newWordStr.TrimEnd(' ');
                newWord.Add(newWordStr);
                newWordStr = "";                                
            }
             

            return newWord;
        }

    
    }
}
