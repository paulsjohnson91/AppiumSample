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
    class SetAirportsPage
    {

        [FindsBy(How = How.Id, Using = "com.ryanair.cheapflights:id/view_search_edit_text", Priority = 0)]
        private IWebElement SearchBar;


        public void SelectAirport(string shortcode, string fullname, AppiumDriver<IWebElement>  appdriver)
        {
            SearchBar.Click();
            SearchBar.SendKeys(shortcode);
            appdriver.HideKeyboard();
            appdriver.FindElement(By.XPath("//android.widget.TextView[@text='" + fullname + "']")).Click();
            
        }


    }
}
