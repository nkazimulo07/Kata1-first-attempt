using NUnit.Framework;


namespace Kata1Calculator2.Test
{
    public class StringCalculatorTest
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void Setup()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void WhenEnteringEmptyString_UsingAdd_ResultsReturnsZero()
        {
            // arrange
            const int expected = 0;
            const string input = "";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithOneNumber_UsingAdd_ResultsReturnsOne()
        {
            // arrange
            const int expected = 1;
            const string input = "1";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithTwoNumber_UsingAdd_ResultsReturnsThree()
        {
            // arrange
            const int expected = 3;
            const string input = "1,2";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithNextLine_UsingAdd_ResultsReturnsSix()
        {
            // arrange
            const int expected = 6;
            const string input = "1,2\n3";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithMoreNumbers_UsingAdd_ResultsReturns15()
        {
            // arrange
            const int expected = 15;
            const string input = "1,2\n3,4,5";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void WhenEnteringStringWithANewDelimiter_UsingAdd_ResultsReturnsThree()
        {
            // arrange
            const int expected = 3;
            const string input = "//;\n1;2";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithNumberGreaterThanOneThousand_UsingAdd_ResultsReturnsTwo()
        {
            // arrange
            const int expected = 2;
            const string input = "1000,2";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void WhenEnteringStringWithDelimiterOfAnyLength_UsingAdd_ResultsReturnsSix()
        {
            // arrange
            const int expected = 6;
            const string input = "//***\n1***2***3";

            // act 
            var results = _stringCalculator.Add(input);

            // assert
            Assert.AreEqual(expected, results);
        }
    }
}
