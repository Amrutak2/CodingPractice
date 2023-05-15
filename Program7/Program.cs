//7. How many times a particular character is repeated in a string

using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
           string a;
           Console.WriteLine("Enter a string: ");
           a = Console.ReadLine();
           while(a.Length > 0){
            Console.Write(a[0] + ":");
            int count = 0;
            for(int j=0; j<a.Length; j++){
                if(a[0] == a[j]){
                    count ++;
                }
            }
            Console.WriteLine(count);
            a = a.Replace(a[0].ToString(), string.Empty);
           }
           Console.ReadLine();
        }
    }
}
