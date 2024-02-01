namespace ComtradeIntegration {
    using System;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
#pragma warning disable CS8618
#pragma warning disable CS0649


    namespace BaseBookCart
    {
        [TestFixture]
        public class BaseTestBookCart
        {
            public static IWebDriver driver;
            public static WebDriverWait wdWait;
            public static Actions actions;

            [SetUp]
            public void SetUp()
            {
                string browser = "chrome";

                if (browser.Equals("chrome", StringComparison.OrdinalIgnoreCase))
                {
                    
                    string chromeDriverPath = @"C:\SeleniumDrivers\chromedriver.exe";
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");

                    driver = new ChromeDriver(chromeDriverPath, options);
                }
                else if (browser.Equals("firefox", StringComparison.OrdinalIgnoreCase))
                {
                    string geckoDriverPath = @"C:\SeleniumDrivers\geckodriver.exe";
                    driver = new FirefoxDriver(geckoDriverPath);
                }
                else
                {
                    throw new ArgumentException("Invalid browser specified");
                }

                wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                actions = new Actions(driver);
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://bookcart.azurewebsites.net/");
            }

            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }
        }
    }

}
