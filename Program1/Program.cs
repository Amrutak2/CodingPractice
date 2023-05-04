using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
        Console.WriteLine("Enter a string: ");
        a = Convert.ToString(Console.ReadLine());
        char[] array = a.ToCharArray();

        //reversing first string
        Array.Reverse(array);
        //converting array to string
        string res = new string(array);
        
        // second string
        b = Convert.ToString(Console.ReadLine());
        
        //comparing the reverse of 1st string and 2nd string
        if(res == b)
        {
            Console.WriteLine("Reverse");
        }

        else
        {
           Console.WriteLine("Not reverse");
           Console.WriteLine("The string are: {0} {1}" ,a, b);
        }
        }
    }
}
