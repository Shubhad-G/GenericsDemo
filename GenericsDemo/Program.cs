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

            int firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("enter the numbers");
            Console.WriteLine("enter the first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            int maxNumber=GenericsMaximum.integerMaximum(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(maxNumber.ToString());

            Console.ReadLine();
            
        }
    }
}
