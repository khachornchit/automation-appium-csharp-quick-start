using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace PlutoSolutionsAppium
{
    [TestClass]
    public class CalculatorTest
    {
        private AppiumServer Server;
        private AppiumDriver<IWebElement> driver;

        [TestInitialize]
        public void Initial()
        {

            //DesiredCapabilities cap = new DesiredCapabilities();
            //cap.SetCapability(MobileCapabilityType.DeviceName, "E9AZCY04P809");
            //cap.SetCapability(MobileCapabilityType.PlatformName, "Android");
            //cap.SetCapability(MobileCapabilityType.App, "D:\\OneDrive\\AndroidDevelopment\\Apk\\app-release.apk");

            //driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:5000/wd/hub"), cap);
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));

        }

        [TestMethod]
        public void RunNotePad()
        {
            Server = new AppiumServer();
            Server.Start();
        }

        //[TestMethod]
        public void T01StartupTest()
        {
            Assert.IsNotNull(driver.Context);
        }

        //[TestMethod]
        public void T02SumFunctionTest()
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

        //[TestMethod]
        public void T03ClearFunctionTest()
        {
            driver.FindElementById("buttonClear").Clear();
        }

        //[TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
            //Server.Stop();
        }
    }
}
