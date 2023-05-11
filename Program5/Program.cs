//5. Find the unique Character in the String

using System;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
            Console.WriteLine("Enter a string: ");
            a = Console.ReadLine();
            char[] array = a.ToCharArray();
            char[] array1 = new char[array.Length];
            int c =0;
            for(int i = 0; i<a.Length; i++){
                if(!Char.IsLetterOrDigit(array[i])){
                    array1[c] = a[i];
                    c++;

                }
            }
            Array.Resize(ref array1, c);
            Console.WriteLine("Unique Characters: ");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
