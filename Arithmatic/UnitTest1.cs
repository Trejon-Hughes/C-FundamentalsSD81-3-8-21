using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmatic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            int sum = a + b;
            sum += 3;
            Console.WriteLine(sum);

            int difference = a - b;
            difference -= 3;

            int product = a * b;
            product *= 3;

            int quotient = a / b;

            int remainder = a % b;

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);

            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
        }
    }
}
