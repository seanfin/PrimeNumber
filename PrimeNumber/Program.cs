using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Say hello to the user
                Console.WriteLine("Welcome to Prime Number!");
                Console.WriteLine("The purpose of this program is to provide a list of prime numbers based on a lower and upper limit.");


                //Get the lower limit.
                Console.WriteLine("Please specify your lower limit.");
                string lowerLimitSTR = Console.ReadLine();
                int lowerLimit = 0;
                if (!Int32.TryParse(lowerLimitSTR.Trim(), out lowerLimit))
                {

                    Console.WriteLine("Lower limit must be numeric defaulting to 1.");
                    lowerLimit = 1;
                }

                //Get the upper limit.
                Console.WriteLine("Please specify your upper limit.");
                string upperLimitSTR = Console.ReadLine();
                int upperLimit = 0;
                if (!Int32.TryParse(upperLimitSTR.Trim(), out upperLimit))
                {
                    Console.WriteLine("Upper limit must be numeric defaulting to 20.");
                    upperLimit = 20;
                }

                //Instiate the class. 
                CheckForPrime prime = new CheckForPrime(lowerLimit, upperLimit);

                //Get List of Prime numbers 
                string primes = prime.ListofPrimeNumbers();

                //Wriite out to console
                Console.WriteLine("The prime numbers are:");
                Console.WriteLine(primes);

                //Read to line.
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(String.Format("There was an exception while attemption to find the prime numbers.", ex));
            }
        }
    }
}
