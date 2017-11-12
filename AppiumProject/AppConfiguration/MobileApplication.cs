using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using PlutoSolutionsAppium.Server;
using PlutoSolutionsAppium.MobileCapabilityConfiguration;
using System;

namespace PlutoSolutionsAppium.AppConfiguration
{
    public class MobileApplication
    {
        private AppProperties appProperties;
        private AppiumServer appiumServer;
        private string DefaultDeviceName = DeviceNames.Device;
        private string DeviceName { get; set; }
        private string PlatformName { get { return "Android"; } }

        public void SelectEmulator()
        {
            DeviceName = DeviceNames.Emulator;
        }

        public void SelectDevice()
        {
            DeviceName = DeviceNames.Device;
        }

        public MobileApplication(AppProperties appProperties)
        {
            DeviceName = DefaultDeviceName;
            this.appProperties = appProperties;
            appiumServer = new AppiumServer();
            appiumServer.StartServer1();
        }

        public Uri Server
        {
            get
            {
                return new Uri(string.Format("http://{0}:{1}/wd/hub", appiumServer.Host, appiumServer.Port));
            }
        }

        public DesiredCapabilities Capabilities
        {
            get
            {
                DesiredCapabilities cap = new DesiredCapabilities();
                cap.SetCapability(MobileCapabilityType.DeviceName, DeviceName);
                cap.SetCapability(MobileCapabilityType.PlatformName, PlatformName);

                switch (DeviceName)
                {
                    case DeviceNames.Device:
                        cap.SetCapability("appPackage", appProperties.AppPackage);
                        cap.SetCapability("appActivity", appProperties.AppActivity);
                        break;

                    case DeviceNames.Emulator:
                        cap.SetCapability("appPackage", appProperties.AppPackage);
                        cap.SetCapability("appActivity", appProperties.AppActivity);
                        cap.SetCapability(MobileCapabilityType.App, appProperties.Apk);
                        break;
                }
                return cap;
            }
        }

        public void StopServer()
        {
            appiumServer.Stop();
        }
    }
}
