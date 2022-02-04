using NUnit.Framework;

namespace Kata1Calculator2.Test
{
    public class Kata1Test
    {

        private Kata1 kata1;

        [SetUp]
        public void Setup()
        {
            kata1 = new Kata1();
        }

        [Test]
        public void WhenEnteringEmptyString_UsingEmptyString_ResultsReturned0()
        {
            var expected = 0;
            var results = kata1.EmptyString("");
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithTwoNumbers_AddToList_ResultsReturned3()
        {
            var expected = 3;
            var results = kata1.AddNumbersToList("1,2");
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void WhenChangingDelimiter_AddNumbersToList_ResultsReturned6()
        {
            var expected = 3;
            var results = kata1.AddNumbersToList("//;\n1;2");
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void WhenEnteringStringWithNumberGreaterThan1000_AddNumbersToList_ResultsReturned2()
        {
            var expected = 2;
            var results = kata1.AddNumbersToList("1000,2");
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void WhenEnteringStringWithANumberThatHaveMoreThanOneDigit_AddNumbersToList_ResultsReturned13()
        {
            var expected = 13;
            var results = kata1.EmptyString("11,2");
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void WhenEnteringStringWithNumbersAndNewLine_AddNumbersToList_ResultsReturned6()
        {
            var expected = 6;
            var results = kata1.AddNumbersToList("1\n2,3");
            Assert.AreEqual(expected, results);
        }

        //public void WhenEnteringListWithNegativeNumbers_NegativeNumbers_ResultsReturned6()
        //{
        //   string[] cities = new string[3] { "1", "-2", "-3" };
        //    var expected = 6;
        //    var results = kata1.negativeNumbers(cities);
        //    Assert.AreEqual(expected, results);
        //}
    }
}