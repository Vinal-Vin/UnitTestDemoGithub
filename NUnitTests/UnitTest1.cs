using UnitTestDemoGithubActions;

namespace NUnitTests
{
    public class Tests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            int result = calculator.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtractionWithNegativeValue()
        {
            int result = calculator.Add(3, 5);
            Assert.AreEqual(-2, result);
        }
    }
}