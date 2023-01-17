using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA
{
    public class AutomationWeb
    {
        public IWebDriver driver;
        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }
        public void TestaWeb()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Bsoft Blog");
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div[1]/a/h3")).Click();
        }
    }
}
