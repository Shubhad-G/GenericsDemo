using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericsMethods<T>
    {
        private T[] inputArray;

        public GenericsMethods(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void print()
        {
            foreach(var i in inputArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------\n");
        }

    }
}
