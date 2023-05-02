using System;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
    
        string a, b;
        Console.WriteLine("Enter two string: ");
        a = Convert.ToString(Console.ReadLine());
        char[] array = a.ToCharArray();
       char[] arr;
       Array.Reverse(array);
       arr = array;
        b = Convert.ToString(Console.ReadLine());
         char[] array2 = b.ToCharArray();
       Array.Reverse(array2);
       
        if(arr == array)
        {
            Console.WriteLine("Reverse");
        }
       else{
           
       
        Console.WriteLine("The string are: {0} {1}" ,a, b);
       }
    
   
    
        }
    }
}
