using System;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word for SOMEONE ELSE to guess: ");
            string word = Console.ReadLine();
            if (word.Contains(" "))
            {
                Console.WriteLine("A WORD, not WORDS!");
                System.Environment.Exit(-1);
            }
            word = word.ToUpper();
            char[] good = word.ToCharArray();
            char[] show = new char[good.Length];
            for (int i = 0; i < good.Length; i++)
            {
                show[i] = '_';
            }

            while (true)
            {
                Console.WriteLine(show);
                Console.WriteLine("Enter a letter: ");
                string temp = Console.ReadLine();
                temp = temp.ToUpper();
                char g = Convert.ToChar(temp[0]);

                if (temp.Equals(word))
                {
                    Console.WriteLine(temp + "\n Correct!");
                    System.Environment.Exit(0);
                }
                for (int i = 0; i < good.Length; i++)
                {
                    if (g.Equals(good[i]))
                    {
                        show[i] = g;
                    }
                    if (checkWin(show) == true)
                    {
                        Console.WriteLine("Correct!");
                        System.Environment.Exit(0);
                    }
                }
            }

            bool checkWin(char[] w)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (w[i].Equals('_'))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
