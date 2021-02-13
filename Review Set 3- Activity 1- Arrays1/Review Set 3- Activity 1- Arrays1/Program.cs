using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace Review_Set_3__Activity_1__Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //an array will hold a group of similar variables
            const int NUMGRADES = 10;
            Random rnd = new Random();
            int[] examMark = new int[NUMGRADES];


            //fill array with 10 random exam marks.

            for (int i = 0; i < NUMGRADES; i++)
            {
                examMark[i] = rnd.Next(0, 101);
            }

            Console.Write("The third Mark: ");
            //display the value stored in third element.
            Console.WriteLine(examMark[2].ToString());

            Console.WriteLine("The average mark: ");
            // will display average mark
            Console.WriteLine(CalcAverage(examMark));

            // display marks from lowest to highest
            Console.WriteLine("Marks from lowest to highest: ");
            for (int i = 0; i < NUMGRADES; i++)
            {
                //this will sort the numbers from lowest to highest
                Console.WriteLine(sortLowtoHigh(examMark)[i].ToString());

            }

            Console.WriteLine("Marks from highest to Lowest");
            for (int i = 0; i < NUMGRADES; i++)
            {
                //this will sort the numbers from highest to lowest
                Console.WriteLine(sortHightoLow(examMark)[i].ToString());
            }

            //display only odd marks
            Console.WriteLine("Only The Odd marks: ");
            outputOnlyOdd(examMark);

            //display only even marks
            Console.WriteLine("Only The Even marks: ");
            outputOnlyEven(examMark);

            //display only prime number marks
            Console.WriteLine("Only The Prime Number Marks: ");
            outputOnlyPrime(examMark);


            Console.ReadKey();
        }

        // Method for calculating average
        static double CalcAverage  (int[] args)
        {
            double avg = 0;
            for (int i = 0; i < args.Length; i++)
            {
                avg += args[i];
            }
            // average will be calculated by dividing average by the arguments length
            avg = avg / args.Length;

            return avg;
        }

        //method for sorting low to high
        static int[] sortLowtoHigh(int[] args)
        {
            int temp = 0;
            bool isSorted = true;
            do
            {
                isSorted = true;
                for (int i = 0; i < args.Length - 1; i++)
                {
                    if (args[i] > args[i + 1])
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (isSorted == false);
            return args;
        }

        // method for sorting high to low
        static int[] sortHightoLow(int[] args)
        {
            int temp = 0;
            bool isSorted = true;
            do
            {
                isSorted = true;
                for (int i = 0; i < args.Length - 1; i++)
                {
                    // if the arguments number is less than the arguments number plus 1 than
                    if (args[i] < args[i + 1])
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                        isSorted = false;
                    }
                }
            } while (isSorted == false);
            return args;
        }

        // methods for outputing only odd
        static void outputOnlyOdd(int[] args)
        {
            for (int i = 0; i < args.Length - 1; i++)
            {
                // if the modulus division of number is 1 then it is odd
                if (args[i]%2 == 1)
                {
                    Console.WriteLine(args[i].ToString());
                }
            }
        }

        //method for outputting only even
        static void outputOnlyEven(int[] args)
        {
            for (int i = 0; i < args.Length - 1; i++)
            {
                // if the modulus division of number is 0 then it is even
                if (args[i] % 2 == 0)
                {
                    Console.WriteLine(args[i].ToString());
                }
            }
        }

        // methdod for only prime numbers 
        static void outputOnlyPrime(int[] args)
        {
            bool isPrime = true;
            for (int i =0; i < args.Length-1; i++)
            {
                isPrime = true;
                for (int j = 1; j < args[i]; j++)
                {
                    // if number does not divide by 1 and doesnt divide by itself and does not equal zero then
                    if (args[i] % j == 0 && args[i] / j != 1 && args[i] / j != args[i])
                    {
                        // the number isnt prime
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(args[i].ToString());
                }

            }
        }

    }
}
