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
        public void Test1()
        {
            int result = calculator.Add(3, 5);
            Assert.AreEqual(9, result);
        }
    }
}