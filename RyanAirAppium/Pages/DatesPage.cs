using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium;

namespace RyanAirAppium
{
    class DatesPage
    {

        [FindsBy(How = How.Id, Using = "com.ryanair.cheapflights:id/view_button_bar_next_btn", Priority = 0)]
        private IWebElement ContinueButton;

        public DatesPage setDepartureDate(AppiumDriver<IWebElement> appdriver, int dep) {
            appdriver.FindElement(By.XPath("//android.widget.TextView[@text='" + dep + "']")).Click();
            return this;
        }

        public DatesPage setReturnDate(AppiumDriver<IWebElement> appdriver, int ret)
        {
            appdriver.FindElement(By.XPath("//android.widget.TextView[@text='" + ret + "']")).Click();
            return this;
        }

        public DatesPage Continue()
        {
            ContinueButton.Click();
            return this;
        }




    }
}
