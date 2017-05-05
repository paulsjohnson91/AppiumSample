using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace RyanAirAppium
{
    [TestFixture]
    class Test1
    {
        private AndroidDriver<IWebElement> driver;
        private HomePage pageObject;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability(MobileCapabilityType.DeviceName, "Paul neo");
            cap.SetCapability("appPackage", "com.ryanair.cheapflights");
            cap.SetCapability("appActivity", "com.ryanair.cheapflights.ui.home.HomeActivity");
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
            pageObject = new HomePage();
            PageFactory.InitElements(driver, pageObject, new AppiumPageObjectMemberDecorator(timeSpan));
        }

       // [Test]
        public void newTest()
        {
            pageObject.SearchForFlights();
        }


    }
}
