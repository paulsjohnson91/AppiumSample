using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace RyanAirAppium
{
    [TestFixture]
    public class Tests : AbstractSetup
    {
        private HomePage pageObject;
        public Tests()
            :base()
        {
        }

        [Test]
        public void FirstTest()
        {
            appdriver.FindElementById("com.ryanair.cheapflights:id/home_button_search").Click();
        }

        [Test]
        public void PageTest()
        {
            TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 15, 0));
            pageObject = new HomePage();
            PageFactory.InitElements(appdriver, pageObject, new AppiumPageObjectMemberDecorator(timeSpan));
            pageObject.SearchForFlights();
            SearchForReturnFlight("BHX", "Birmingham", "ALC", "Alicante", "October", 14, 16, false);
        }







    }
}

