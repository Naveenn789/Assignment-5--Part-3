using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBasicPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x=0, y=1;
            Console.WriteLine("First ten fibonacci numbers");
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i <=7; i++)
            {
                int z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
            Console.ReadKey();
        }
    }
}
