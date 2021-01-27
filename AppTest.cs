using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Collections.Generic;

namespace Hawkeye
{

    [TestClass]
    public class AppTest
    {
        //AppiumDriver<IWebElement> driver;
        AndroidDriver<IWebElement> driver;
        //IOSDriver<IWebElement> driver;
     


        [TestMethod]
        public void TestMethod1()
        {
            //Initial setup of desired capabilites
            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("DeviceName", "Android");
            cap.AddAdditionalCapability("PlatformName", "Android");
            cap.AddAdditionalCapability("PlatformVersion", "19.0");
            cap.AddAdditionalCapability("uuid", "11160b8c2fea0303");
            cap.AddAdditionalCapability("AppPackage", "com.costar.marketingcenter.app");
            cap.AddAdditionalCapability("AppActivity", "com.costar.marketingcenter.app.feature.login.activities.LoginActivity");

            //setup the url for appium server
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);

            //driver = new AndroidDriver<IWebElement>(new Uri("http://0.0.0.0:4723/wd/hub"), cap);

            //gather information for my test
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
            driver.FindElementById("com.costar.marketingcenter.app:id/editTextUsername").Clear();
            driver.FindElementById("com.costar.marketingcenter.app:id/editTextUsername").SendKeys("sjones2@costar.com");
            driver.FindElementById("com.costar.marketingcenter.app:id/editTextPassword").SendKeys("Semal@1972");
            driver.FindElementById("com.costar.marketingcenter.app:id/buttonLogin").Click();

        }
    }
}
