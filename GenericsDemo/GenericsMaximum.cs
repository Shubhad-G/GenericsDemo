using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericsMaximum <T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;

        public GenericsMaximum(T firstValue,T secondValue,T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static T maxValue(T firstValue, T secondValue, T thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0) && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) >= 0 && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;                                                                        /*here in first return compare to method returns 1 if first number is greater than both
                                                                                                            second and third which is compared with 0 and since 1 is greater than 0 first number will be-
                                                                                                             maximum or else if the first number is not greater then compare to will return -1 and
                                                                                                             since -1 is less than 0 condition will become false and it will be same for other*/
            }

            else if ((secondValue.CompareTo(firstValue) > 0) && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) >= 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            else if ((thirdValue.CompareTo(firstValue) > 0) && (thirdValue.CompareTo(secondValue) > 0) ||
                 thirdValue.CompareTo(firstValue) >= 0 && (thirdValue.CompareTo(secondValue) > 0) ||
                 thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            else
                return firstValue;
        }
        public T maxMethod()
        {
            T max = GenericsMaximum<T>.maxValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
       
    }
}
