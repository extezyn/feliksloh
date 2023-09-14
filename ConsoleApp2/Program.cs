using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("я гуль");
            for( int i=1000; i>6; i = i - 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
