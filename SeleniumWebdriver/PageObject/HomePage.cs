using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.PageObject
{
    public class HomePage
    {
        #region WebElement

        [FindsBy(How = How.Id,Using = "quicksearch_main")]
        private IWebElement QuickSearchTextBox;

        [FindsBy(How = How.Id, Using = "find")]
        private IWebElement QuickSearchBtn;

        [FindsBy(How = How.LinkText, Using = "File a Bug")]
        private IWebElement FileABugLink;


        #endregion

        public HomePage()
        {
            PageFactory.InitElements(ObjectRepository.Driver,this);
        }

        #region Actions

        public void QuickSearch(string text)
        {
            QuickSearchTextBox.SendKeys(text);
            QuickSearchBtn.Click();
        }

        #endregion

        #region Navigation

        public LoginPage NavigateToLogin()
        {
            FileABugLink.Click();
            return new LoginPage();
        }

        #endregion
    }
}
