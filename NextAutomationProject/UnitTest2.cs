using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NextAutomationProject
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver Driver { get; set; }
        //test
        [TestMethod]
        [TestCategory("LogInTest")]
        public void TestMethod1()
        {
            Driver = GetChromeDriver();
            var nextHomePage = new NextHomePage(Driver);
            nextHomePage.GoTo();
            Assert.IsTrue(nextHomePage.IsVisible);
            //ddsdafsdfsdf

        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
