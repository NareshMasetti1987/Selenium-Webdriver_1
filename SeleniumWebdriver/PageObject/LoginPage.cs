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
    public class LoginPage
    {
        #region WebElement
        [FindsBy(How = How.Id,Using = "Bugzilla_login")]
        private IWebElement LoginTextBox;

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox;

        [FindsBy(How = How.Id, Using = "log_in")]
        
        private IWebElement LoginButton;

        [FindsBy(How = How.LinkText, Using = "Home")]
        
        private IWebElement HomeLink;

      
        #endregion

        public LoginPage()
        {
            PageFactory.InitElements(ObjectRepository.Driver,this);
        }

        #region Actions

        public EnterBug Login(string usename, string password)
        {
            LoginTextBox.SendKeys(usename);
            PassTextBox.SendKeys(password);
            LoginButton.Click();
            return new EnterBug();
        }

        #endregion

        #region Navigation

        public void NavigateToHome()
        {
           HomeLink.Click();
        }

        #endregion
    }
}
