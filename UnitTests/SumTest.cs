using UnitTestDemoGithubActions;

namespace UnitTests
{
    public class SumTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 5);
            Assert.Equal(8, result);
           
        }

        [Fact]
        public void TestAddDecimal()
        {
            Calculator calculator = new Calculator();
            decimal decResult = calculator.Adddecimal((decimal)3.71, (decimal)5.9);
            Assert.Equal((decimal)0.61, decResult);
        }
    }
}