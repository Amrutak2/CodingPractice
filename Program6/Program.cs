//6. Print the repeated characters in a String

using System;
using System.Collections;
using System.Collections.Generic;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Enter a string: ");
            a = Console.ReadLine();
            var repeat = new List<char>();
            // List<char> repeat = new List<char>();
            foreach (var item in a)
            {
                int count = 0;
                foreach (var chars in a)
                {
                    if(item == chars){
                        count ++;
                    }
                }
                if(count > 1 && !repeat.Contains(item)){
                    repeat.Add(item);
                }
            }
            Console.WriteLine( string.Join(", ", repeat));
        }
    }
}
