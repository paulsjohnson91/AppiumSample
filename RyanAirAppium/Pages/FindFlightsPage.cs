using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace RyanAirAppium
{
    class FindFlightsPage
    {

        [FindsBy(How = How.Id, Using = "com.ryanair.cheapflights:id/fr_label_title", Priority = 0)]
        private IList<IWebElement> FromAndToButtons;
        [FindsBy(How = How.Id, Using = "com.ryanair.cheapflights:id/plan_trip_btn_trip_date_depart", Priority = 0)]
        private IWebElement dateField;
        [FindsBy(How = How.Id, Using = "com.ryanair.cheapflights:id/view_button_bar_next_btn", Priority = 0)]
        private IWebElement LetsGoButton;


        public void SetDeparture()
        {
            FromAndToButtons[0].Click();
        }
        public void SetDestination()
        {
            FromAndToButtons[1].Click();
        }

        public void setDates()
        {
            dateField.Click();
        }

        public void LetsGo()
        {
            LetsGoButton.Click();
        }


    }
}
