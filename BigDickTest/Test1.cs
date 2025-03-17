using TestBitch;

namespace BigDickTest
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        public void PolosaException()
        {
            double initialSpeed = 5;
            double finalSpeed = 20;
            double acceleration = 50;

            Assert.AreEqual(187.5, Test.Bolid(100,50,20), "Ошибка");
        }

        [TestMethod]
        public void PolosaException2()
        {
            double initialSpeed = 5;
            double finalSpeed = 20;
            double acceleration = 50;

            Assert.AreEqual(3.7, Test.Bolid(finalSpeed, initialSpeed, acceleration), "Ошибка");
        }

        [TestMethod]
        public void PolosaException3()
        {
            Assert.AreEqual(187.5, Test.Bolid(100, 50, 20), "Ошибка");
        }

        [TestMethod]
        public void PolosaException4()
        {
            double result = Test.Bolid(200, 100, 100);
            Assert.AreEqual(150, result, "Ошибка");
        }
    }
}
