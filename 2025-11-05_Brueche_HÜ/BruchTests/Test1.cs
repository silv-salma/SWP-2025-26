using Microsoft.Vis.TestTools.UnitTesting;

namespace BruchTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            var b1 = new Bruch("1/2");
            var b2 = new Bruch("1/4");
            var result = b1.addiere(b2);
            Assert.AreEqual("3/4", result.ToString());
        }

        [TestMethod]
        public void TestFalschesFormat()
        {
            Assert.ThrowsException<System.FormatException>(() => new Bruch("abc"));
        }
    }
}