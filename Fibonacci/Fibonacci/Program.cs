using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Fibonacci_Sequence(5);
            
        }

        public static void Fibonacci_Sequence(int last_Number)
        {

            int firstNumber = 1;
            int secondNumber = 1;

            int count = 0;
            Console.Write(firstNumber + ", " + secondNumber);
            while(count < last_Number-2)
            {
                var nm = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nm;
                Console.Write(", "+nm);

                count++;
            }

            Console.ReadLine();
        }
    }
}
