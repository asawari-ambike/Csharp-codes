using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;

namespace Selenium_Basics_Assignments
{
    public class SeleniumAssignments
    {
        private IWebDriver _driver;
        private string URL1 = "http://shop.demoqa.com/";
        private string URL2 = "https://www.toolsqa.com/automation-practice-form/";
        private string defaultURL = "https://demoqa.com/";
        private string driverLocation = @"D:\Asawari\Testing\Projects\Automation training\Selenium Practice Assignments\drivers";

        public void LaunchBroswer(string assignment)
        {
           //_driver = new FirefoxDriver(driverLocation);
           _driver = new ChromeDriver(driverLocation);
           switch(assignment)
           {
               case "first": _driver.Navigate().GoToUrl(URL1);
               break;
               case "second": _driver.Navigate().GoToUrl(URL2);
               break;
               default: _driver.Navigate().GoToUrl(defaultURL);
               break;
           }             
            _driver.Manage().Window.Maximize();
        }

        public void Assignment1()
        {
            string titleName = _driver.Title;
            int titleLength = titleName.Length;
            Console.WriteLine("Page Title: {0}; Title Length:{1}", titleName, titleLength);

            string urlName = _driver.Url;
            int urlLength = urlName.Length;
            Console.WriteLine("Page URL: {0}; URL Length:{1}", urlName, urlLength);

            string pageSourceText = _driver.PageSource;
            int pageSourceLength = pageSourceText.Length;
            Console.WriteLine("Page Source Length: {0}",pageSourceLength);
        }

        public void Assignment2()
        {
            _driver.FindElement(By.PartialLinkText("Wishlist")).Click();
            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().GoToUrl(URL1);
            _driver.Navigate().Refresh();
        }

        public void Assignment3()
        {
            string name, value;            
            IList <IWebElement> checkList = _driver.FindElements(By.XPath("//input[@type='checkbox']"));
            _driver.FindElement(By.Id("tool-0")).Click();
            foreach (var checkpoint in checkList)
            {
                if(checkpoint.Displayed)
                {
                    if(checkpoint.Enabled)
                    {
                        if(checkpoint.Selected)
                        {
                            name = checkpoint.GetAttribute("name");
                            value = checkpoint.GetAttribute("value");
                            Console.WriteLine("The selected checkbox\nName: {0}; Value: {1}", name, value);                            
                        }                                                
                    }
                }                
            }
            foreach (var checkpoint in checkList)
            {
                if(checkpoint.Displayed)
                {
                    if(checkpoint.Enabled)
                    {
                        if(!checkpoint.Selected)
                        {
                            name = checkpoint.GetAttribute("name");
                            value = checkpoint.GetAttribute("value");
                            checkpoint.Click();
                            Console.WriteLine("The unselected checkbox, now checked\nName: {0}; Value: {1}", name, value);
                            break;
                        }
                    }
                }
                
            }
            
        }

        public void Assignment4()
        {
            string name, value;
            IList <IWebElement> radioList = _driver.FindElements(By.XPath("//input[@type='radio']"));
            _driver.FindElement(By.Id("exp-0")).Click();
            foreach (var radiopoint in radioList)
            {
                if(radiopoint.Displayed)
                {
                    if(radiopoint.Enabled)
                    {
                        if(radiopoint.Selected)
                        {
                            name = radiopoint.GetAttribute("name");
                            value = radiopoint.GetAttribute("value");
                            Console.WriteLine("The selected radio button\nName: {0}; Value: {1}", name, value);
                        }                                              
                    }
                }                
            }
            foreach (var radiopoint in radioList)
            {
                if(radiopoint.Displayed)
                {
                    if(radiopoint.Enabled)
                    {
                        if(!radiopoint.Selected)
                        {
                            name = radiopoint.GetAttribute("name");
                            value = radiopoint.GetAttribute("value");
                            radiopoint.Click();
                            Console.WriteLine("The unselected radio button, now selected\nName: {0}; Value: {1}", name, value);
                            break;
                        }
                    }
                }
                
            }
            
        }

        public void CloseBroswer()
        {
            _driver.Close();
        }

        public static void Main(string []args)
        {
            SeleniumAssignments selA = new SeleniumAssignments();
            selA.LaunchBroswer("first");
            selA.Assignment1();
            selA.Assignment2();            
            selA.CloseBroswer();

            selA.LaunchBroswer("second");
            selA.Assignment3();
            selA.Assignment4();
            selA.CloseBroswer();
        }
    }
}
