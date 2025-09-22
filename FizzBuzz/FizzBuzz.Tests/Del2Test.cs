
using NUnit.Framework;
using CiPFizzBuzz.Services;


namespace FizzBuzz.Tests
{
    [TestFixture]
    public class Del2Test
    {
        private FizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        [TestCase(1, 0, 0)]
        [TestCase(3, 1, 0)]
        [TestCase(5, 1, 1)]
        [TestCase(15, 5, 3)]
        //[TestCase(15, 3, 4)] //mTestet ska faila
        [TestCase(30, 10, 6)]
        [TestCase(10000, 3333, 2000)]
        public void TallyFizzBuzz_ShouldReturnCorrectCounts(long n, long expectedFizzCount, long expectedBuzzCount)
        {
            var (fizzCount, buzzCount) = _fizzBuzzService.TallyFizzBuzz(n);
            Assert.That(fizzCount, Is.EqualTo(expectedFizzCount));
            Assert.That(buzzCount, Is.EqualTo(expectedBuzzCount));
        }
    }
}