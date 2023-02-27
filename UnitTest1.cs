using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace HelloUiTest
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Setup()
        {
            //driver.Navigate().GoToUrl("Url");
            driver.Url = Environment.GetEnvironmentVariable("Url");
        }

        [Test]
        public void Test1()
        {
            // IWebElement home = driver.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(2) > a"));
            Assert.AreEqual("Home page - HelloWeb", driver.Title);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}