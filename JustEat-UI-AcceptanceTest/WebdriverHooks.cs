using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace JustEat_UI_AcceptanceTest
{
    [Binding]
    public class WebdriverHooks
    {
        [BeforeScenario]
        public static void CreateDriver()
        {
            Context.Driver = new ChromeDriver();
            Context.Driver.Manage().Window.Maximize();
            Context.Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
            Context.Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(60));
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            Context.Driver.Quit();
            Context.Driver.Dispose();
        }
    }
}