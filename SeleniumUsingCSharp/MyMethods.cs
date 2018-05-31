using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumUsingCSharp
{
    class MyMethods
    {
        public IWebDriver driver;

        public IWebDriver Firefox()
        {   
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\ASP\SeleniumUsingCSharpSolution\SeleniumUsingCSharp\BrowserDrivers\geckodriver-v0.20.1-win64");
            return driver = new FirefoxDriver(service);
        }

        public IWebDriver Chrome()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"D:\ASP\SeleniumUsingCSharpSolution\SeleniumUsingCSharp\BrowserDrivers\chromedriver_win32");
            return driver = new ChromeDriver(service);
        }

        public void TakeScreenshot(IWebDriver driver, string fileName)
        {
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"D:\ASP\SeleniumUsingCSharpSolution\SeleniumUsingCSharp\Screenshots\" + fileName + ".png", ScreenshotImageFormat.Png);
        }
    }
}
