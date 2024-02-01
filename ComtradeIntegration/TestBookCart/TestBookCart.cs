using ComtradeIntegration.BaseBookCart;
using NUnit.Framework;
using PageBookCart;
#pragma warning disable CS8618
#pragma warning disable CS0649

namespace TestBookCart
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class TestRunBookCart : BaseTestBookCart
    {
        private LoginPageObjectsAndMethods loginPageBookCart;
        private AddItemToCartAndCheckOut addItemToCartAndCheckOut;

        [SetUp]
        public void SetUpTestRun()
        {
            loginPageBookCart = new LoginPageObjectsAndMethods();
            addItemToCartAndCheckOut = new AddItemToCartAndCheckOut();
        }

        [Test]
        public void BookOrderingAndBuyingSmokeTest()
        {
            loginPageBookCart
                .LoginToBookCart()
                .EnterUserName("DenisT")
                .EnterUserPassword("Kobe8Bryant24")
                .ClickLoginButton();

            addItemToCartAndCheckOut
                .OpenFirstBookForCart()
                .AddBookToCart()
                .ValidateToastMsgForAddedItem()
                .OpenCart()
                .ValidateBookIsPresentInCart()
                .ProceedToCheckout()
                .SubmitName("Denis")
                .SubmitFirstAddress("Sarajevo")
                .SubmitSecondAddress("Gradacacka 27")
                .SubmitPincode("112233")
                .SubmitState("New")
                .ClickOnPlaceOrder();

            if (!addItemToCartAndCheckOut.ValidateToastMsgForPlacedOrder()) 
            {              
                throw new Exception("Validation failed: Toast message for placed order not displayed.");
            }

        }
    }
}
