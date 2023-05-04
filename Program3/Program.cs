//3. Find the Power without using math.pow function.

using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, p, i;
            int res =1;

            Console.WriteLine("Enter the base number: ");
            a = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Enter the power: ");
            p = Convert.ToInt32(Console.ReadLine());
            
            for(i=1; i<=p; i++)
            {
                res *= a;
            }
           
            Console.WriteLine("{0} Power of {1}: {2}", p, a, res);
            
        }
    }
}
