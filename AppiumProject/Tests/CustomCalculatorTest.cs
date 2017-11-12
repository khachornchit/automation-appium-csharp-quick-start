using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using PlutoSolutionsAppium.AppConfiguration;
using PlutoSolutionsAppium.MobileCapabilityConfiguration;

namespace PlutoSolutionsAppium.Tests
{
    [TestClass]
    public class CustomCalculatorTest
    {
        private static MobileApplication mobileApp;
        private static AppiumDriver<IWebElement> driver;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            mobileApp = new MobileApplication(new AppProperties() { Apk = "D:\\OneDrive\\AndroidDevelopment\\Apk\\app-release.apk" });
            driver = new AndroidDriver<IWebElement>(mobileApp.Server, mobileApp.Capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1000));
        }

        [TestMethod]
        public void T01_StartupTest()
        {
            Assert.IsNotNull(driver.Context);
        }

        [TestMethod]
        public void T02_SumFunctionTest()
        {
            float numberA = 5;
            float numberB = 25;
            float expected = 30;
            float actual = 0;

            driver.FindElementById("editTextA").SendKeys(numberA.ToString());
            driver.FindElementById("editTextB").SendKeys(numberB.ToString());
            driver.FindElementById("buttonSum").Click();
            actual = float.Parse(driver.FindElementById("textViewResult").Text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void T03_ClearFunctionTest()
        {
            driver.FindElementById("buttonClear").Click();

            string actualA = driver.FindElementById("editTextA").Text;
            string actualB = driver.FindElementById("editTextB").Text;
            string actualResult = driver.FindElementById("textViewResult").Text;

            Assert.IsTrue(string.IsNullOrEmpty(actualA));
            Assert.IsTrue(string.IsNullOrEmpty(actualB));
            Assert.IsTrue(string.IsNullOrEmpty(actualResult));
        }

        [ClassCleanup]
        public static void TE_Cleanup()
        {
            driver.Quit();
            mobileApp.StopServer();
        }
    }
}
