using ComtradeIntegration.BaseBookCart;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Text;
#pragma warning disable CS8618
#pragma warning disable CS0649

namespace PageBookCart
{
    public class AddItemToCartAndCheckOut : BaseTestBookCart
    {

        public AddItemToCartAndCheckOut OpenFirstBookForCart()
        {
            IWebElement clickOnFirstBook = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("(//a[contains(@href,'/books/details/2')])[1]")));
            clickOnFirstBook.Click();
            return this;
        }
        public AddItemToCartAndCheckOut AddBookToCart()
        {
            IWebElement clickOnAddToCart = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("(//span[contains(text(),'Add to Cart')])[1]")));
            clickOnAddToCart.Click();
            return this;
        }

        public AddItemToCartAndCheckOut ValidateToastMsgForAddedItem()
        {
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//span[contains(text(),'One Item added to cart')]")));
            return this;
        }

        public AddItemToCartAndCheckOut OpenCart()
        {
            IWebElement clickOnCart = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("(//mat-icon[contains(text(), 'shopping_cart')])[1]")));
            clickOnCart.Click();
            return this;
        }

        public AddItemToCartAndCheckOut ValidateBookIsPresentInCart()
        {
            IWebElement bookPresentInCart = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'HP2')]")));
            return this;
        }

        public AddItemToCartAndCheckOut ProceedToCheckout()
        {
            IWebElement clickOnCheckout = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'CheckOut')]")));
            clickOnCheckout.Click();
            return this;
        }

        public AddItemToCartAndCheckOut SubmitName(string name)
        {
            IWebElement nameField = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-placeholder = 'Name']")));
            nameField.Clear();
            nameField.SendKeys(name);
            return this;
        }

        public AddItemToCartAndCheckOut SubmitFirstAddress(string address1)
        {
            IWebElement address1Field = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-placeholder = 'Address Line 1']")));
            address1Field.Clear();
            address1Field.SendKeys(address1);
            return this;
        }

        public AddItemToCartAndCheckOut SubmitSecondAddress(string address2)
        {
            IWebElement address2Field = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-placeholder = 'Address Line 2']")));
            address2Field.Clear();
            address2Field.SendKeys(address2);
            return this;
        }

        public AddItemToCartAndCheckOut SubmitPincode(string pincode)
        {
            IWebElement pincodeField = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-placeholder = 'Pincode']")));
            pincodeField.Clear();
            pincodeField.SendKeys(pincode);
            return this;
        }

        public AddItemToCartAndCheckOut SubmitState(string state)
        {
            IWebElement stateField = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//input[@data-placeholder = 'State']")));
            stateField.Clear();
            stateField.SendKeys(state);
            return this;
        }

        public AddItemToCartAndCheckOut ClickOnPlaceOrder()
        {
            IWebElement placeOrderButton = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Place Order')]")));
            placeOrderButton.Click();
            return this;
        }

        public bool ValidateToastMsgForPlacedOrder()
        {
            IWebElement validateToastMessageForPlacedOrder = wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Order placed successfully!!!')]")));
            return validateToastMessageForPlacedOrder.Displayed;
        }

    }

}

