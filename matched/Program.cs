using System;
using System.Collections.Generic;

namespace matched
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test tow cases :");
            string str1 = "33033";
            Console.WriteLine(str1 + " -> " + matchOrNot(str1));
            string str2 = "321";
            Console.WriteLine(str2 + " -> " + matchOrNot(str2));
            
        }

        static bool matchOrNot(string input)
        {
            Stack<int> numbers = new Stack<int>();
            foreach (char ch in input)
            {
                if (numbers.Count == 0 || ch != numbers.Peek())
                {
                    numbers.Push(ch);
                }
                else
                {
                    numbers.Pop();
                }
                if (numbers.Count == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}


