using System;
using System.Linq;

namespace _15.LinqTheFirst
{
    class Program
    {   
        // Linq is integrated in c# and give us more capacity to work with methods , with more methods on the objects !
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5 };

            Console.WriteLine(array.First());   // prints out of the array the first element !
            Console.WriteLine(array.First(x => x % 2 == 0));  //give  me the first item, that by division of  2 gives a remider = 0;
            // give me the first even number in the array ;

        }
    }
}
