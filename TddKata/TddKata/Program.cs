using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddKata
{
    public class NewClass
    {
        [Fact]
        public void should_return_0_for_empty()
        {
            // arrange
            var stringCalculator = new StringCalculator();

            //act
            var result = stringCalculator.Add(" ");

            // assert
            Assert.AreEqual(result, " ");
        }
    }

    internal class StringCalculator
    {
        public int Add(string numbers)
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}