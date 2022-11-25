using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericsMethods
    {
        public static void print<T>(T[] inputArray)
        {
            foreach(var i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------\n");
        }

    }
}
