using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (int i = 0; i < 10; i++)
            {
                n = 21 * (i*10+9);
                if (((n%5==4)&&(n%6==3)&&(n%8==1)&&(n%9==0)))
                {
                    Console.WriteLine("no. of eggs:{0}",n);
                }
            }
            Console.ReadKey();
          
        }

    }
}
