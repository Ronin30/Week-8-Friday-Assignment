using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 28;
            int middleInt = 31;
            int lastInt = 34;

            WriteLine("Before the swap firstInt is {0}", firstInt);
            WriteLine("Before the swap middleInt is {0}", middleInt);
            WriteLine("Before the swap lastInt is {0}", lastInt);

            Swap(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("\n-------After The Swap--------");
            WriteLine("After the swap, the firstInt is {0}", firstInt);
            WriteLine("After the swap, the middleInt is {0}", middleInt);
            WriteLine("After the sawp, the lastInt is {0}", lastInt);

            ReadKey();
        }

        private static void Swap(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int temp;
            temp = firstInt;
            firstInt = lastInt;
            lastInt = temp;
            
        }

        

    }
}
