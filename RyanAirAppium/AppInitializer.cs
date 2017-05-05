using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;

namespace RyanAirAppium
{
    static class AppInitializer
    {
        const string ApkPath = "../../../Binaries/<APK>.apk";
        const string AppPath = "../../../Binaries/<APK>.app";
        static AppiumDriver<IWebElement> appdriver;
        //const string IpaBundleId = "com.xamarin.samples.taskytouch";

        //static IApp app;
        public static AppiumDriver<IWebElement> Appdriver
        {
            get
            {
                if (appdriver == null)
                    throw new NullReferenceException("'AppInitializer.App' not set. Call 'AppInitializer.StartApp(platform)' before trying to access it.");
                return appdriver;
            }
        }

        public static AppiumDriver<IWebElement> StartApp(Platform platform)
        {

            return appdriver;
        }
    }
}
