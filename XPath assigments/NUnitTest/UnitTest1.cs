using NUnit.Framework;
using ServiceProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver _driver;
        private string URL = "http://shop.demoqa.com/";
        private string driverLocation = @"D:\Asawari\Testing\Projects\Automation training\Selenium practice 1\NUnitTest\drivers";

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver(driverLocation);
            _driver.Navigate().GoToUrl(URL); 
            _driver.Manage().Window.Maximize();         
        }       

        [Test]
        public void XPathTypes()
        {
            //Basic Xpath:   
            string centerText = _driver.FindElement(By.XPath("//*[@id=\"slide-6-layer-4\"]")).Text;
            StringAssert.Contains("UMBRA BLUE", centerText); 

            //Contains()
            _driver.FindElement(By.XPath("//*[contains(text (),'My Wishlist')]")).Click();

            //Using OR & AND:
            _driver.FindElement(By.XPath("//*[@class='custom-logo-link' and @href='http://shop.demoqa.com/']")).Click();
            _driver.FindElement(By.XPath("//*[@class='tp-caption   tp-resizeme' or @id='slide-6-layer-9']")).Click();

            //Start-with function:
            _driver.FindElement(By.XPath("//*[starts-with(@id, 'slide-6')]")).Click();

            //Text()
            if(_driver.FindElement(By.XPath("//*[text()='SHOP NOW > ']")).Displayed)
            {
                Console.WriteLine("Text detected");
            }

            //Following:
            IList<IWebElement> follElems = _driver.FindElements(By.XPath("//*[@class='noo-cart-simple']//following::li"));
            foreach (var elem in follElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Ancestor:
            IList<IWebElement> ancesElems = _driver.FindElements(By.XPath("//*[@class='noo-cart-simple']//ancestor::a"));
            foreach (var elem in ancesElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Child:
            IList<IWebElement> chElems = _driver.FindElements(By.XPath("//*[@class='noo-cart-simple']//child::li"));
            foreach (var elem in chElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Preceding:
            IList<IWebElement> precElems = _driver.FindElements(By.XPath("//*[@class='custom-logo']//preceding::a"));
            foreach (var elem in follElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Following-Sibling:
            IList<IWebElement> sibElems = _driver.FindElements(By.XPath("//*[@class='custom-logo']//following-sibling::img"));
            foreach (var elem in sibElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Parent:
            IList<IWebElement> parElems = _driver.FindElements(By.XPath("//*[@class='custom-logo']//parent::a"));
            foreach (var elem in sibElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Self:
            IList<IWebElement> selfElems = _driver.FindElements(By.XPath("//*[@class='custom-logo']//self::img"));
            foreach (var elem in selfElems)
            {
                Console.WriteLine(elem.Text);
            }

            //Descendant:
            IList<IWebElement> descElems = _driver.FindElements(By.XPath("//*[@class='custom-logo']//descendant::a"));
            foreach (var elem in descElems)
            {
                Console.WriteLine(elem.Text);
            }


        }
        
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}