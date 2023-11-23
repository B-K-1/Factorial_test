
namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodFactorial()
        {
            int a = 3;
            int excepted = 6;
            var f = new FactorialClass();
            int actual = f.factorial(a);
            Assert.AreEqual(excepted, actual);
        }
    }
}