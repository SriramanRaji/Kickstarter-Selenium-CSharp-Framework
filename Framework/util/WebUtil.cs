using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace Framework.util
{
    public class WebUtil
    {
        GlobalUtil globalUtil = new GlobalUtil();
        public IWebDriver? driver;
        public WebDriverWait? wait;
        public IJavaScriptExecutor? js;

        public void launchBrowser(String browserType)
        {
            try
            {
                if(browserType.ToLower() == "chrome")
                {
                    driver = new ChromeDriver(globalUtil.currentDirectorys + @"\drivers\");
                   
                } else if(browserType.ToLower() == "firefox")
                {
                    driver = new FirefoxDriver(globalUtil.currentDirectorys + @"\drivers\");
                   
                } else if (browserType.ToLower() == "edge")
                {
                    driver = new EdgeDriver(globalUtil.currentDirectorys + @"\drivers\");
                    
                    
                } else
                {
                    Console.WriteLine("Provide Chrome / Firefox / Edge Browser.!");
                }
                driver.Manage().Window.Maximize();
                Console.WriteLine(browserType+" browser was launched successfully");
            } catch(Exception e)
            {
                Console.WriteLine("Couldn't launch the browser\n"+ e.StackTrace);
            }
        }

        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }

        public void launchURL(String browserType, String url)
        {
            try
            {
                launchBrowser(browserType);
                driver.Navigate().GoToUrl(url);
                Console.WriteLine(url+" is launched in "+browserType+" browser");
            } catch(Exception e)
            {
                Console.WriteLine("Couldn't load URL " +e.StackTrace);    
            }
            
        }

        public void clickElement(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void enterText(By locator, String value)
        {
            driver.FindElement(locator).SendKeys(value);
        }

    }
}