using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrimeNumber.BL;


namespace PrimeNumber.Tests
{
    [TestClass()]
    public class CheckForPrimeTests
    {
       
        [TestMethod()]
        public void ListofPrimeNumbersTest_ReturnList()
        {
            //Initiate class.
            PrimeNumberUtil prime = new PrimeNumberUtil();

            //Get the string. 
            string primeNumbers = prime.GetListOfPrimeNumbers(1, 20);

            //Make sure it is not null.
            Assert.IsNotNull(primeNumbers);
        }

        /// <summary>
        /// Returns a empty list
        /// </summary>
        [TestMethod()]
        public void ListofPrimeNumbersTest_IsEmpty()
        {
            //Initiate class.
            PrimeNumberUtil prime = new PrimeNumberUtil();

            //Get the string. 
            string primeNumbers = prime.GetListOfPrimeNumbers(1, 1);

            //Make sure it is not null.
            Assert.IsTrue(string.IsNullOrEmpty(primeNumbers));
        }

        [TestMethod()]
        public void ListofPrimeNumbersTest_ArgumentException()
        {
            //Initiate class.
            PrimeNumberUtil prime = new PrimeNumberUtil();

            //Throws argument exception when given bad order of limits. 
            Assert.ThrowsException<ArgumentException>(() => prime.GetListOfPrimeNumbers(20, 0));
           
        }
    }
}