using Framework.util;
using OpenQA.Selenium;

namespace Framework.test
{
    public class TC_001
    {
        WebUtil webUtil;
        GlobalUtil globalUtil;

        public By myAccountElement = By.XPath("//span[text()='My Account']");
        public By loginElement = By.XPath("//a[text()='Login']");

        public By emailInput = By.XPath("//input[@id='input-email']");
        public By passwordInput = By.XPath("//input[@id='input-password']");
        public By loginBtn = By.XPath("//button[text()='Login']");

        [OneTimeSetUp]
        public void setUp()
        {
            webUtil = new WebUtil();
            globalUtil = new GlobalUtil();
        }
        

        [Test]
        public void Test_001()
        {

            webUtil.launchURL(globalUtil.browserType, globalUtil.applicationURL);
            webUtil.clickElement(myAccountElement);
            webUtil.clickElement(loginElement);

            webUtil.enterText(emailInput, "Dummy@dummy.com");
            webUtil.enterText(passwordInput, "dummyPassword");
            webUtil.clickElement(loginBtn);


        }

        [OneTimeTearDown]
        public void tearDown()
        {
            Thread.Sleep(3000);
            webUtil.closeBrowser();
        }
    }
}
