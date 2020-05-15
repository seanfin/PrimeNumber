using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.BL
{
    

    public class PrimeNumberUtil
    {

        /// <summary>
        /// Retrieves a list of the prime numbers and writes them to the console. 
        /// </summary>
        public string GetListOfPrimeNumbers(int lowerLimit, int upperLimit)
        {
            if (lowerLimit > upperLimit)
                throw new ArgumentException(string.Format("Lower limit of {0} cannot be larger than the upper limit of {1} ", lowerLimit, upperLimit));

            StringBuilder sb = new StringBuilder();

            int ctr;
            for (int num = lowerLimit; num <= upperLimit; num++)
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
