using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects;

namespace RyanAirAppium
{
    public abstract class AbstractSetup
    {
        protected AppiumDriver<IWebElement> appdriver;
        protected Platform platform;

        protected bool OnAndroid { get; set; }
        protected bool OniOS { get; set; }

        protected Dictionary<string, string[]> LoginDetails;

        public AbstractSetup()
        {
            
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability(MobileCapabilityType.DeviceName, "Paul neo");
            cap.SetCapability("appPackage", "com.ryanair.cheapflights");
            cap.SetCapability("appActivity", "com.ryanair.cheapflights.ui.home.HomeActivity");
            appdriver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            //app = AppInitializer.StartApp(platform);
            OnAndroid = true;
            OniOS = false;
            //OnAndroid = app.GetType() == typeof(AndroidApp);
            //OniOS = app.GetType() == typeof(iOSApp);
        }


        public void SearchForReturnFlight(string DepartureShortcode, string DepartureFull, string DestinationShortcode, string DestinationFull, string month, int departureday, int returnday, bool screenshots)
        {
            TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 15, 0));
            FindFlightsPage ffp = new FindFlightsPage();
            PageFactory.InitElements(appdriver, ffp, new AppiumPageObjectMemberDecorator(timeSpan));
            ffp.SetDeparture();
            SetAirportsPage sap = new SetAirportsPage();
            PageFactory.InitElements(appdriver, sap, new AppiumPageObjectMemberDecorator(timeSpan));
            sap.SelectAirport(DepartureShortcode, DepartureFull,appdriver);
            ffp = new FindFlightsPage();
            PageFactory.InitElements(appdriver, ffp, new AppiumPageObjectMemberDecorator(timeSpan));
            ffp.SetDestination();
            sap = new SetAirportsPage();
            PageFactory.InitElements(appdriver, sap, new AppiumPageObjectMemberDecorator(timeSpan));
            sap.SelectAirport(DestinationShortcode, DestinationFull, appdriver);

            ffp = new FindFlightsPage();
            PageFactory.InitElements(appdriver, ffp, new AppiumPageObjectMemberDecorator(timeSpan));
            ffp.setDates();

            DatesPage dp = new DatesPage();
            PageFactory.InitElements(appdriver, dp, new AppiumPageObjectMemberDecorator(timeSpan));
            dp.setDepartureDate(appdriver, departureday)
                .setDepartureDate(appdriver, returnday)
                .Continue();

            ffp = new FindFlightsPage();
            PageFactory.InitElements(appdriver, ffp, new AppiumPageObjectMemberDecorator(timeSpan));
            ffp.LetsGo();


            //new FindFlightsPage()
            //    .SelectDepartureLocation();
            //new SelectAirportPage();'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            //    .SelectAirport(DepartureShortcode, DepartureFull);
            //if (screenshots)
            //    app.Screenshot($"I set the departure to {DepartureFull}");
            //new FindFlightsPage()
            //    .SelectDestinationLocation();
            //new SelectAirportPage()
            //    .SelectAirport(DestinationShortcode, DestinationFull);
            //if (screenshots)
            //    app.Screenshot($"I set the destination to {DestinationFull}");
            //new FindFlightsPage()
            //    .SelectDates();
            //app.WaitForNoElement(x => x.Property("Text").Contains("Just a sec,"));
            //new SelectDatePage()
            //    .SelectDate(14, GetNextMonth())
            //    .SelectDate(16, GetNextMonth());
            //if (screenshots)
            //    app.Screenshot("I set the dates between the 14th and 16th");
            //new SelectDatePage().PressContinue();
            //new FindFlightsPage()
            //    .PressLetsGo();
            //if (screenshots)
            //    app.Screenshot("I submit my search");
            //new FlightSearchResultsPage()
            //    .AssertOriginAirport(DepartureFull);

        }






    }
}
