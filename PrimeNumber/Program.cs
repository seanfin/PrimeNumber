using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumber.BL;

namespace PrimeNumberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // retrieve the limits.
                int lowerLimit = 1;
                int upperLimit = 20;

                RetrieveUpperAndLowerLimit(out lowerLimit, out upperLimit);

                //Instiate the class. 
                PrimeNumberUtil prime = new PrimeNumberUtil();

                //Get List of Prime numbers 
                string primes = prime.GetListOfPrimeNumbers(lowerLimit, upperLimit);

                //Wriite out to console
                Console.WriteLine("The prime numbers are:");
                Console.WriteLine(primes);

                //Read to line.
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("There was an exception while attemption to find the prime numbers.", ex));
            }
        }

        public static void RetrieveUpperAndLowerLimit(out int lowerLimit, out int upperLimit)
        {
            bool limitsSet = false;

            lowerLimit = 1;
            upperLimit = 20;
                
            //Have to loop through to make sure limits are set.
            while (!limitsSet)
            {

                //Say hello to the user
                Console.WriteLine("Welcome to Prime Number!");
                Console.WriteLine("The purpose of this program is to provide a list of prime numbers based on a lower and upper limit.");


                //Get the lower limit.
                Console.WriteLine("Please specify your lower limit.");
                string lowerLimitSTR = Console.ReadLine();
                
                if (!Int32.TryParse(lowerLimitSTR.Trim(), out lowerLimit))
                {

                    Console.WriteLine("Lower limit must be numeric defaulting to 1.");
                    lowerLimit = 1;
                }
                else if (lowerLimit <= 0)
                {
                    Console.WriteLine("Lower Limit must be greater than 0. Defaulting to 1.");
                    lowerLimit = 1;
                }

                //Get the upper limit.
                Console.WriteLine("Please specify your upper limit.");
                string upperLimitSTR = Console.ReadLine();
                
                if (!Int32.TryParse(upperLimitSTR.Trim(), out upperLimit))
                {
                    Console.WriteLine("Upper limit must be numeric defaulting to 20.");
                    upperLimit = 20;
                }
                else if (upperLimit <= 0)
                {
                    Console.WriteLine("Upper Limit must be greater than 0. Defaulting to 20.");
                    upperLimit = 20;
                }
               

                if (lowerLimit >= upperLimit)
                {
                    Console.WriteLine("Lower limit must be less than Upper limit. Please reopen application and try again. ");
                    limitsSet = false;
                }
                else
                {
                    limitsSet = true;
                }

            }
        }
    }
}
