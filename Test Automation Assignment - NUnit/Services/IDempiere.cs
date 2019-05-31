using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Services
{
    public class IDempiere
    {
        string driverPath = @"D:\Asawari\Testing\Projects\Automation training\Test Automation Assignment - NUnit\NUnitTest\drivers";
        string mainURL = "https://www.idempiere.org/test-sites";
        string mainLink = "https://test.idempiere.org/webui/";
        private static IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;

        public void LaunchSite()
        {
            //Navigate to the site
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(mainURL);
        }

        public string NaviagteToLink(out string actUrl)
        {
            //Click on Link
            driver.FindElement(By.PartialLinkText("test.idempiere")).Click();
            
            //Switch tabs to go to opened link
            string oldTab = driver.CurrentWindowHandle;
            IList<string> newTabs = driver.WindowHandles;
            string newTab;
            foreach (var tab in newTabs)
            {
                if(tab != oldTab)
                {
                    newTab = tab;
                    driver.SwitchTo().Window(newTab);
                }                
            }

            //To verify if the link is successfully opened            
            actUrl = driver.Url;
            return mainLink;
        }

        public void Login()
        {
            //Enter Username
            driver.FindElement(By.XPath("//tr[@id='rowUser']//following::input[1]")).SendKeys("admin @ gardenworld.com");
            //Enter password
            driver.FindElement(By.XPath("//tr[@id='rowPassword']//following::input[1]")).SendKeys("GardenAdmin");
            //Click on OK button
            driver.FindElement(By.XPath("//button[contains(text (),'OK')]")).Click();            
        }

        public bool CloseBusinessPartner()
        {
            //Fluent wait
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //Click on BP from favorites
            IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));            
            searchResult.Click();

            //Verfiy if the Cancel button is present
            bool locateCancelBtn = false;
            IWebElement cancelBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//button[@title='Cancel']")));
            
            if(cancelBtn.Displayed)
            {
                locateCancelBtn = true;
            }

            //Close the form
            if(locateCancelBtn)
            {
                cancelBtn.Click();
            }
            
            return locateCancelBtn;
        }

        public bool ResetBPForm()
        {
            //Click on BP from favorites
            IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));            
            searchResult.Click();

            //Verfiy if the reset button is present
            bool locateResetBtn = false;
            IWebElement resetBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//button[@title='Reset']")));

            if(resetBtn.Displayed)
            {
                locateResetBtn = true;
            }

            //Locate the fields
            IWebElement keyField, nameField, name2Field, descriptionField;
            keyField = driver.FindElement(By.XPath("//input[@instancename='Value']"));
            nameField = driver.FindElement(By.XPath("//input[@instancename='Name']"));
            name2Field = driver.FindElement(By.XPath("//input[@instancename='Name2']"));
            descriptionField = driver.FindElement(By.XPath("//input[@instancename='Description']"));

            //Enter values
            keyField.SendKeys("12345");
            nameField.SendKeys("Asawari");
            name2Field.SendKeys("Ambike");
            descriptionField.SendKeys("Testing");

            //Click on reset button
            if(locateResetBtn)
            resetBtn.Click();

            //Verify if the fields are cleared
            bool resetWorks = false;
            string key, name, name2, description;
            key = keyField.Text;
            name = nameField.Text;
            name2 = name2Field.Text;
            description = descriptionField.Text;

            if(key.Equals("") && name.Equals("") && name2.Equals("") && description.Equals(""))
            {
                resetWorks = true;
            }

            return resetWorks;

        }

        public bool OpenBPForm()
        {
            //Verfiy if the OK button is present
            bool locateOKBtn = false;
            IWebElement OKBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//button[@title='OK']")));

            if(OKBtn.Displayed)
            {
                locateOKBtn = true;
            }

            //Locate the fields
            IWebElement keyField, nameField, name2Field, descriptionField;
            keyField = driver.FindElement(By.XPath("//input[@instancename='Value']"));
            nameField = driver.FindElement(By.XPath("//input[@instancename='Name']"));
            name2Field = driver.FindElement(By.XPath("//input[@instancename='Name2']"));
            descriptionField = driver.FindElement(By.XPath("//input[@instancename='Description']"));

            //Enter values
            keyField.SendKeys("12345");
            nameField.SendKeys("Asawari");
            name2Field.SendKeys("Ambike");
            descriptionField.SendKeys("Testing");

            //Click on OK button
            if(locateOKBtn)
            OKBtn.Click();

            //Verify if BP form is opened
            IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//*[@title='Client/Tenant for this installation.']")));            
            bool successLoad = false;
            if(searchResult.Displayed)
            {
                successLoad = true;
            }

            return successLoad;

        }

        public bool CreateNewBP()
        {
            //Verfiy if the New button is present
            bool locateNewBtn = false;
            IWebElement newBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//a[@title='New    Alt+N']")));

            if(newBtn.Displayed)
            {
                locateNewBtn = true;
            }

            //Click on New button
            if(locateNewBtn)
            {
                newBtn.Click();
            }

            //Enter mandatory field - Name and Save
            IWebElement formField = fluentWait.Until(y=>y.FindElement(By.XPath("//input[@title='Alphanumeric identifier of the entity']")));
            formField.SendKeys("AsawariA");

            driver.FindElement(By.XPath("//a[@title='Save changes    Alt+S']")).Click();

            //Validate if BP is saved successfully 
            bool saveSuccess = false;
            try
            {
                IWebElement successMsg = driver.FindElement(By.XPath("//*[text ()='Record saved']"));
                saveSuccess = true;
            }
            catch(NoSuchElementException exp)
            {                
                Console.WriteLine("BP not saved successfully");
                throw(exp);
            }
            
            return saveSuccess;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
