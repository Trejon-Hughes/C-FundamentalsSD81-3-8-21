using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOpperators()
        {
            int age = 25;
            string userName = "Mick";

            bool equals = age == 41;

            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("User is 41:" + equals);

            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?:" {listAreEqual});

            bool greaterThan = age > 12;

            bool greaterThanOrEqual = age >= 24;

            bool lessThan = age < 65;

            bool lessThanOrEqual = age <= 65;

            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
        }
    }
}
