using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericsMaximum
    {
        public static int integerMaximum(int firstNumber,int secondNumber,int thirdNumber)
        {
            if ((firstNumber.CompareTo(secondNumber) > 0) && (firstNumber.CompareTo(thirdNumber) > 0) ||
                firstNumber.CompareTo(secondNumber) >= 0 && (firstNumber.CompareTo(thirdNumber) > 0) ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) >= 0)
            {
                return firstNumber;                                                                        /*here in first return compare to method returns 1 if first number is greater than both
                                                                                                            second and third which is compared with 0 and since 1 is greater than 0 first number will be-
                                                                                                             maximum or else if the first number is not greater then compare to will return -1 and
                                                                                                             since -1 is less than 0 condition will become false and it will be same for other*/
            }
             
            else if ((secondNumber.CompareTo(firstNumber) > 0) && (secondNumber.CompareTo(thirdNumber) > 0) ||
                secondNumber.CompareTo(firstNumber) >= 0 && (secondNumber.CompareTo(thirdNumber) > 0) ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
            {
                return secondNumber;
            }

           else if ((thirdNumber.CompareTo(firstNumber) > 0) && (thirdNumber.CompareTo(secondNumber) > 0) ||
                thirdNumber.CompareTo(firstNumber) >= 0 && (thirdNumber.CompareTo(secondNumber) > 0) ||
                thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)
            {
                return thirdNumber;
            }
            else
            return firstNumber;
        }
        public static double doubleMaximum(double firstNumber, double secondNumber, double thirdNumber)
        {
            if ((firstNumber.CompareTo(secondNumber) > 0) && (firstNumber.CompareTo(thirdNumber) > 0) ||
                firstNumber.CompareTo(secondNumber) >= 0 && (firstNumber.CompareTo(thirdNumber) > 0) ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) >= 0)
            {
                return firstNumber;                                                                        /*here in first return compare to method returns 1 if first number is greater than both
                                                                                                            second and third which is compared with 0 and since 1 is greater than 0 first number will be-
                                                                                                             maximum or else if the first number is not greater then compare to will return -1 and
                                                                                                             since -1 is less than 0 condition will become false and it will be same for other*/
            }

            else if ((secondNumber.CompareTo(firstNumber) > 0) && (secondNumber.CompareTo(thirdNumber) > 0) ||
                secondNumber.CompareTo(firstNumber) >= 0 && (secondNumber.CompareTo(thirdNumber) > 0) ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
            {
                return secondNumber;
            }

            else if ((thirdNumber.CompareTo(firstNumber) > 0) && (thirdNumber.CompareTo(secondNumber) > 0) ||
                 thirdNumber.CompareTo(firstNumber) >= 0 && (thirdNumber.CompareTo(secondNumber) > 0) ||
                 thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)
            {
                return thirdNumber;
            }
            else
                return firstNumber;
        }
        public static string stringMaximum(string firstString, string secondString, string thirdString)
        {
            if ((firstString.CompareTo(secondString) > 0) && (firstString.CompareTo(thirdString) > 0) ||
                firstString.CompareTo(secondString) >= 0 && (firstString.CompareTo(thirdString) > 0) ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;                                                                        /*here in first return compare to method returns 1 if first number is greater than both
                                                                                                            second and third which is compared with 0 and since 1 is greater than 0 first number will be-
                                                                                                             maximum or else if the first number is not greater then compare to will return -1 and
                                                                                                             since -1 is less than 0 condition will become false and it will be same for other*/
            }

            else if ((secondString.CompareTo(firstString) > 0) && (secondString.CompareTo(thirdString) > 0) ||
                secondString.CompareTo(firstString) >= 0 && (secondString.CompareTo(thirdString) > 0) ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }

            else if ((thirdString.CompareTo(firstString) > 0) && (thirdString.CompareTo(secondString) > 0) ||
                 thirdString.CompareTo(firstString) >= 0 && (thirdString.CompareTo(secondString) > 0) ||
                 thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            else
                return firstString;
        }
    }
}
