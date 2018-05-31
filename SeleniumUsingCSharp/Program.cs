using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumUsingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpenUsingChrome();
            OpenUsingFirefox();
        }

        private static void OpenUsingFirefox()
        {
            MyMethods myMethods = new MyMethods();
            IWebDriver driver = myMethods.Firefox();
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            //driver.FindElement(By.Id("lst-ib")).SendKeys("Hello World");
            myMethods.TakeScreenshot(driver, driver.Title);
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }

        private static void OpenUsingChrome()
        {
            MyMethods myMethods = new MyMethods();
            IWebDriver driver = myMethods.Chrome();
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            driver.FindElement(By.Id("lst-ib")).SendKeys("Hello World");
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }
    }
}
