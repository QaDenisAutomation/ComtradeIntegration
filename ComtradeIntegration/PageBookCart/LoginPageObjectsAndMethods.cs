using ComtradeIntegration.BaseBookCart;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Xml.XPath;
#pragma warning disable CS0649

namespace PageBookCart
{
    public class LoginPageObjectsAndMethods : BaseTestBookCart
    { 

        public LoginPageObjectsAndMethods LoginToBookCart()
        {
            IWebElement homePageLoginButton = driver.FindElement(By.XPath("//span[contains(text(),'Login')]"));

            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(homePageLoginButton));
            homePageLoginButton.Click();
            return this;
        }

        public LoginPageObjectsAndMethods EnterUserName(string username)
        {
            IWebElement userName = driver.FindElement(By.XPath("//input[@data-placeholder = 'Username']"));
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(userName));
            userName.Clear();
            userName.SendKeys(username);
            return this;
        }

        public LoginPageObjectsAndMethods EnterUserPassword(string userpassword)
        {
            IWebElement userPassword = driver.FindElement(By.XPath("//input[@data-placeholder = 'Password']"));
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(userPassword));
            userPassword.Clear();
            userPassword.SendKeys(userpassword);
            return this;
        }

        public LoginPageObjectsAndMethods ClickLoginButton()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("(//span[contains(text(),'Login')])[2]"));
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(loginButton));
            loginButton.Click();
            return this;
        }
    }
}
