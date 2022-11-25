using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericsMethods
    {
        public static void printIntArray(int[] intArray)
        {
            foreach(int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------\n");
        }

        public static void printDoubleArray(double[] doubleArray)
        {
            foreach(double i in doubleArray)
            {
                System.Console.WriteLine(i);
            }
            Console.WriteLine("-------------\n");
        }
        public static void printCharArray(char[] charArray)
        {
            foreach(char i in charArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------\n");
        }
    }
}
