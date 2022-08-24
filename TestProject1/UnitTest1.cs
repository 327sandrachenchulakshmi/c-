namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int divd = 100;
            int divisor = 0;
            int res, rem;
            int expectedresult = 20;

            ConsoleAppDemo.InOutDemo.Divide(divd, divisor, out res, out rem);

            Assert.AreEqual(expectedresult, res);
            Assert.ArrEqual(0, res);
        }
    }
}