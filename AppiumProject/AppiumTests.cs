using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; /* We use .NET UnitTest Fwk, but any unit test fwk can be used */
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;

namespace PlutoSolutionsAppium
{
    [TestClass]
    public class AppiumTests
    {
        //private AppiumDriver driver;
        private static Uri testServerAddress = new Uri(TestServers.Server1);
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180); /* Change this to a more reasonable value */
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10); /* Change this to a more reasonable value */

        [TestInitialize]
        public void Initialize()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            TestCapabilities testCapabilities = new TestCapabilities();

            testCapabilities.App = "";
            testCapabilities.AutoWebView = true;
            testCapabilities.AutomationName = "";
            testCapabilities.BrowserName = String.Empty; // Leave empty otherwise you test on browsers
            testCapabilities.DeviceName = "Needed if testing on IOS on a specific device. This will be the UDID";
            testCapabilities.FwkVersion = "1.0"; // Not really needed
            testCapabilities.Platform = TestCapabilities.DevicePlatform.Android; // Or IOS
            testCapabilities.PlatformVersion = String.Empty; // Not really needed

            testCapabilities.AssignAppiumCapabilities(ref capabilities);
            //driver = new AppiumDriver(testServerAddress, capabilities, INIT_TIMEOUT_SEC);
            //driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }

        [TestCleanup]
        public void AfterAll()
        {
            //driver.Quit(); // Always quit, if you don't, next test session will fail
        }
        
        [TestMethod]
        public void CheckTestEnvironment()
        {
            //var context = driver.GetContext();
            //Assert.IsNotNull(context);
        }
    }
}