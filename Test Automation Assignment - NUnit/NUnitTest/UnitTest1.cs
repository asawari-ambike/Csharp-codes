using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Services;

namespace Tests
{
    [TestFixture]
    public class Tests
    {        
        [Test]
        public void TestIdempiere()
        {
            IDempiere obj = new IDempiere();
            //Test Launching of site            
            obj.LaunchSite();

            //Test Clicking of link
            string actUrl;
            string expUrl = obj.NaviagteToLink(out actUrl);
            //Test successful navigation to tab in which link is opened
            Assert.AreEqual(expUrl, actUrl);

            //Test Login functionality
            obj.Login();

            //Test Closing BP window
            bool checkClose = obj.CloseBusinessPartner();
            Assert.AreEqual(checkClose, true);

            //Test resetting form
            bool checkReset = obj.ResetBPForm();
            Assert.AreEqual(checkReset, true);

            //Test opening BP form
            bool checkOpen = obj.OpenBPForm();
            Assert.AreEqual(checkOpen, true);

            //Test new BP creation
            bool saveSuccess = obj.CreateNewBP();
            Assert.AreEqual(saveSuccess, true);

            //Close browser
            obj.CloseBrowser();

        }
    }
}