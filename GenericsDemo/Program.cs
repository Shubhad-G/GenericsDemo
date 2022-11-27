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
            new GenericsMethods<int>(intArray).print();
            new GenericsMethods<double>(doubleArray).print();
            new GenericsMethods<char>(charArray).print();//generics class implementation


            //GenericsMethods.print<int>(intArray);
            //GenericsMethods.print<double>(doubleArray);
            //GenericsMethods.print<char>(charArray);//generic method implementation

            int firstintNumber, secondintNumber, thirdintNumber;
            Console.WriteLine("enter the integer numbers");
            Console.WriteLine("enter the first integer numbers");
            firstintNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second integer number");
            secondintNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third integer number");
            thirdintNumber = Convert.ToInt32(Console.ReadLine());

            int maxNumber=GenericsMaximum.integerMaximum(firstintNumber, secondintNumber, thirdintNumber);
            Console.WriteLine("maximum of entered numbers is :"+maxNumber.ToString());

            double firstfloatNumber, secondintfloatNumber, thirdintfloatNumber;
            Console.WriteLine("enter the floating point numbers");
            Console.WriteLine("enter the first  number");
            firstfloatNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second  number");
            secondintfloatNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the third  number");
            thirdintfloatNumber = Convert.ToDouble(Console.ReadLine());

            double maxfloatNumber = GenericsMaximum.doubleMaximum(firstfloatNumber, secondintfloatNumber, thirdintfloatNumber);
            Console.WriteLine("maximum of entered numbers is :"+maxfloatNumber.ToString());

            Console.ReadLine();
            
        }
    }
}
