//4. Find the negative Power without using math.pow function.Reverse the String with and without recursion

using System;

namespace Program4
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int a, i;
            double p;
            double res = 1;
            double neg;
            string str;
            Console.WriteLine("String reverse with recurssion: \n Enter a string: ");
            str = Console.ReadLine();
            str = ReverseStr(str);
            Console.WriteLine("Reversed String with recurssion: {0}" , str);

            Console.WriteLine("String reverse without recurssion: \nEnter a string: ");
            str = Console.ReadLine();
            char[] array = str.ToCharArray();

            //reversing first string
            Array.Reverse(array);
             
            //converting array to string
            string r = new string(array);
            Console.WriteLine("Reversed string without recurssion: {0}", r);

            Console.WriteLine("Enter the base number: ");
            a = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Enter the negative power: ");
            p = Convert.ToDouble(Console.ReadLine());
           
            for(i=1; i<=p; i++)
            {
                res = res * a;
            }
            neg = (1 / res);

            Console.WriteLine("{0} Power of {1}: {2}", p, a, neg);
        }
        public static string ReverseStr(string str){
        if(str.Length>0){
            return str[str.Length -1] + ReverseStr(str.Substring(0, str.Length -1));
        }
        else{
            return str;
        }
        }
    }
}
