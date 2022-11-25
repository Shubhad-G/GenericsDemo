using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1,2,3,4,5};
            double[] doubleArray = { 1.2, 2.2, 3.2, 4.2 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e' };

            GenericsMethods.print<int>(intArray);
            GenericsMethods.print<double>(doubleArray);
            GenericsMethods.print<char>(charArray);

            Console.ReadLine();
            
        }
    }
}
