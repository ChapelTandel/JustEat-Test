using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace JustEat_UI_AcceptanceTest.Page
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public WebDriverWait WaitFor(int time)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(time));
        }

        protected IWebDriver Driver { get; private set; }
    }
}