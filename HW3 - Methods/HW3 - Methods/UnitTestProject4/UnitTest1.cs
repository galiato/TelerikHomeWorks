using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestForTask4
{
    [TestClass]
    public class TestTask4
    {
        static decimal maxValue = decimal.MaxValue;
        static decimal minValue = decimal.MinValue;

        [TestMethod]
        public void TestWithMinValue()
        {
            //data to check
            decimal[] array = { maxValue, minValue, 7, minValue, 2 };

            //add test data
            NumberInArrayWithTests.numberToCheck = minValue;
            NumberInArrayWithTests.CountAppearances(array);

            //assert
            Assert.AreEqual(2, NumberInArrayWithTests.counter);
            //we  null the counter in order to reset the counter in the original class, because it's static and currently set to 2.
            NumberInArrayWithTests.counter = 0;
        }

        [TestMethod]
        public void TestWithMaxValue()
        {
            //data to check
            decimal[] array = { 17, 5212, 17, 5212, maxValue, maxValue, maxValue, 0 };

            //add test data
            NumberInArrayWithTests.numberToCheck = maxValue;
            NumberInArrayWithTests.CountAppearances(array);

            //assert
            Assert.AreEqual(3, NumberInArrayWithTests.counter);
        }

    }
}