using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace RyanAirAppium
{
    public class HomePage
    {

        [FindsBy(How = How.Id, Using = "home_button_search")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"com.ryanair.cheapflights:id/home_button_search\")")]
        private IWebElement SearchForFlightsButton;

        [FindsBy(How = How.Id, Using = "name_input")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeID\")")]
        private IWebElement name;

        [FindsBy(How = How.Name, Using = "car")]
        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeID\")")]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        private IWebElement carSelect;

        [FindsByAndroidUIAutomator(AndroidUIAutomator = "new UiSelector().resourceId(\"android:id/fakeID\")")]
        [FindsByIOSUIAutomation(IosUIAutomation = ".elements()[0]")]
        [FindsBy(How = How.XPath, Using = ".//*[@type=\"submit\"]")]
        private IWebElement sendMeYourName;

        public void SetName(string name)
        {
            this.name.Clear();
            this.name.SendKeys(name);
        }

        public void SelectCar(String car)
        {
            SelectElement select = new SelectElement(carSelect);
            select.SelectByValue(car);
        }

        public void SendMeYourName()
        {
            sendMeYourName.Submit();
        }

        public void SearchForFlights()
        {
            SearchForFlightsButton.Click();
        }






    }
}
