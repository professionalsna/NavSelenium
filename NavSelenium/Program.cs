using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NavSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string url = "https://emaktab.org/demo/login.aspx";
            //driver.Url = url;
            driver.Navigate().GoToUrl(url);


            IWebElement element = driver.FindElement(By.Id("btnUserLogin"));
            element.Click();

            //Or can be written as
            //driver.FindElement(By.LinkText("ToolsQA")).Click();

        }
    }
}
