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
    public class EnterBug
    {
        #region WenElement

        [FindsBy(How = How.LinkText, Using = "Testng")]
        private IWebElement Testng;

     

        #endregion

        public EnterBug()
        {
            PageFactory.InitElements(ObjectRepository.Driver,this);
        }

        #region Navigation

        public BugDetail NavigateToDetail()
        {
           Testng.Click();
            return new BugDetail();
        }


        #endregion
    }
}
