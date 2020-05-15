using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    

    public class CheckForPrime
    {
        /// <summary>
        /// The lower limit of the prime number list.
        /// </summary>
        private  int LowerLimit { get; set; }

        /// <summary>
        /// The upper limit of the prime number list.
        /// </summary>
        private  int UpperLimit { get; set; }
        

        /// <summary>
        /// Constructor for the Check for Prime Class. 
        /// </summary>
        /// <param name="lowerLimit">Lower Limit of the check for prime class. </param>
        /// <param name="upperLimit">Upper Limit of the check for prime class.</param>
        public CheckForPrime(int lowerLimit, int upperLimit)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;

        }


        /// <summary>
        /// Retrieves a list of the prime numbers and writes them to the console. 
        /// </summary>
        public string ListofPrimeNumbers()
        {
            StringBuilder sb = new StringBuilder();

            int ctr;
            for (int num = LowerLimit; num <= UpperLimit; num++)
            {
                ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    sb.Append(String.Format("{0}, ", num));

            }

            string primes =  sb.ToString();
            primes= primes.Trim().TrimEnd(',');
            return primes;
           
        }

    }
}
