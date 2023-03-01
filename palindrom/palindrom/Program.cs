using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem;
            int sum = 0;
            int temp;
            int n = 145;
            temp = n;
             
            for(int i=0;i<n;i++)
            {
                rem = n % 10;//5
                n = n / 10;//14
                sum = (sum * 10) + rem;//5
            }
            if (temp == sum) 
                Console.WriteLine("given number is a palindrom");
            else
                Console.WriteLine("given number is not palindrom");
            Console.ReadKey();
        }
        
    }
}
