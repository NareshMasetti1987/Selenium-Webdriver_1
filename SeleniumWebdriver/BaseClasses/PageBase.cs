﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebdriver.ComponentHelper;

namespace SeleniumWebdriver.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver,this);
            this.driver = _driver;
        }

        #region Actions

        protected void Logout()
        {
            if(GenericHelper.IsElemetPresent(By.XPath("//div[@id='header']/ul[1]/li[11]/a")))
                ButtonHelper.ClickButton(By.XPath("//div[@id='header']/ul[1]/li[11]/a"));
        }

        #endregion
    }
}
