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
            
            try
            {
                Console.Write("Please enter nth number in numeric: ");
                var nthNumber =Convert.ToInt32(Console.ReadLine());
                Fibonacci_Sequence(nthNumber);
            }
            catch (Exception )
            {
               Console.WriteLine("Please enter a valid numeric number"); 
                
            }
          }

        public static void Fibonacci_Sequence(int nth_Number)
        {

            int firstNumber = 1;
            int secondNumber = 1;

            int count = 0;
            Console.Write(firstNumber + ", " + secondNumber);
            while(count < nth_Number-2)
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
