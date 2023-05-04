using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cons = {1,2,3,4};
            int i;
            int [] sum = new int[4];
            for(i=0; i<(cons.Length-1); i++)
            {
             sum[i] = cons[i]+cons[i+1];   
             Console.WriteLine(sum[i]);
           
            }
            for(i=0; i<(sum.Length-1); i++)
            
            {
                 if(sum[i] < sum[i+1] && sum[i] < sum[i+2])
                 {
                   Console.WriteLine("smallest sum: {0}", sum[i]);
                 }
            }
      
        }
    }
}
