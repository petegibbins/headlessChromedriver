using System;
using HeadlessTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Driver.Initialize();

            Driver.Instance.Navigate().GoToUrl("http://seleniumhq.org");

            // a guarantee that the test was really executed
            Assert.IsTrue(Driver.Instance.FindElement(By.Id("q")).Displayed);

            Driver.Instance.Quit();
        }
    }
}
