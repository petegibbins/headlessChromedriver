using System;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HeadlessTesting
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            var options = new ChromeOptions();
            // headless requires version 60+
            options.AddArgument("headless");
            options.AddArgument("disable-gpu");
            // set size, just in case responsive website
            options.AddArgument("window-size=1200x600");

            // If you want to use Canary build of Chrome, specify the path
            //options.BinaryLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\..\Local\Google\Chrome SxS\Application\chrome.exe";
            
            // If the path to the ChromeDriver doesn't work, just download it and stick it in your path
            Instance = new ChromeDriver("WebDrivers", options);

        }
    }
}
