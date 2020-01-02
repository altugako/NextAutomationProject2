using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextAutomationProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nextHomePage = new NextHomePage(driver);
            nextHomePage.GoTo();
            Assert.IsTrue(nextHomePage.IsVisible);
        }
    }
}
