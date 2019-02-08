using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Assert.AreEqual("parameter1-value", testContext.Properties["Parameter1"]);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
