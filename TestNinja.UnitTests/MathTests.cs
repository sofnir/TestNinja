using NUnit.Framework;
using System.Collections.Generic;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Becouse I wanted to!")]
        public void Add_WhenCalled_ReturnsSumOfValues()
        {            
            var result = _math.Add(1, 2);

            Assert.AreEqual(result, 3);
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnsGreaterValue(int firstValue, int secondValue, int expectedResult)
        {            
            var result = _math.Max(firstValue, secondValue);

            Assert.AreEqual(result, expectedResult);
        }        
        
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void GetOddNumbers_LimitIsEqualsOrLessThenZero_ReturnsEmptyEnumerable(int limit)
        {            
            var result = _math.GetOddNumbers(limit);

            CollectionAssert.IsEmpty(result);        
        }
        [Test]
        public void GetOddNumbers_LimitIsOddNumber_ReturnsOddNumbers()
        {            
            var result = _math.GetOddNumbers(7);

            var expectedResult = new List<int>() { 1, 3, 5, 7 };
            CollectionAssert.AreEqual(result, expectedResult);            
        }
        [Test]
        public void GetOddNumbers_LimitIsEvenNumber_ReturnsOddNumbers()
        {            
            var result = _math.GetOddNumbers(8);

            var expectedResult = new List<int>() { 1, 3, 5, 7 };
            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}