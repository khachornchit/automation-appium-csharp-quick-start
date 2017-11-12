using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using PlutoSolutionsAppium.AppConfiguration;
using PlutoSolutionsAppium.AppElements;
using PlutoSolutionsAppium.MobileCapabilityConfiguration;

namespace PlutoSolutionsAppium.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        private static MobileApplication mobileApp;
        private static AppiumDriver<IWebElement> driver;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            mobileApp = new MobileApplication(new AppProperties() { AppPackage = "com.android2.calculator3", AppActivity = "com.xlythe.calculator.material.Calculator", Apk = "D:\\OneDrive\\AndroidDevelopment\\Apk\\com.android2.calculator3-1.apk" });
            mobileApp.SelectDevice();
            //mobileApp.SelectEmulator();

            driver = new AndroidDriver<IWebElement>(mobileApp.Server, mobileApp.Capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1000));
        }

        //[TestMethod]
        //public void StartupTest()
        //{
        //    String actual = driver.Context;
        //    Assert.IsNotNull(actual);
        //    Console.WriteLine("actual not null = {0}", actual);
        //}

        [TestMethod]
        public void A01_NumericButtonTest()
        {
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit2).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit3).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit4).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit5).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit6).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit7).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit8).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit9).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit0).Click();

            string expected = "1,234,567.890";
            string actual = driver.FindElementById(ElementCalculator.IdFormula).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B01_AddFunctionTest23()
        {
            string expected = "2.3";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit2).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B02_AddFunctionTest24()
        {
            string expected = "2.4";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit3).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B03_AddFunctionTest25()
        {
            string expected = "2.5";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit4).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B04_AddFunctionTest26()
        {
            string expected = "2.6";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit5).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B05_AddFunctionTest27()
        {
            string expected = "2.7";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit6).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B06_AddFunctionTest28()
        {
            string expected = "2.8";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit7).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B07_AddFunctionTest29()
        {
            string expected = "2.9";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit8).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [TestMethod]
        public void B08_AddFunctionTest3()
        {
            string expected = "3";
            string actual = string.Empty;

            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathAdd).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit1).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDot).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDigit9).Click();

            actual = driver.FindElementById(ElementCalculator.IdResult).Text;

            Assert.AreEqual(expected, actual);
            Console.WriteLine("expected / actual = {0} / {1}", expected, actual);

            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
            driver.FindElementByXPath(ElementCalculator.XPathDelete).Click();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            driver.Quit();
            mobileApp.StopServer();
        }
    }
}
