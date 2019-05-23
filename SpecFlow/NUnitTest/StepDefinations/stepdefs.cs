using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Features
{
    [Binding]
    public class StepDefinitions
    {
        IWebDriver driver;

        [Given(@"I launch the Application")]
        public void ILaunchTheBrowser()
        {
            driver = new ChromeDriver(@"D:\Asawari\Testing\Projects\Automation training\Selenium practice 1\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://www.google.com/");
            
        }

        [When(@"I enter search criteria")]
        public void IEnterSearchCriteria()
        {
            driver.FindElement(By.Name("q")).SendKeys("Specflow"+Keys.Enter);
        }

        [Then(@"I am able to see search results")]
        public void ISeeSearchResults()
        {
            try{
            IWebElement specElement = driver.FindElement(By.PartialLinkText("Specflow")); 
            }
            catch(NoSuchElementException elemNotFound)
            {
                throw elemNotFound;
            }
                       
        }
    }
}