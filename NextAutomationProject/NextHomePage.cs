﻿using OpenQA.Selenium;
using System;

namespace NextAutomationProject
{
    internal class NextHomePage
    {
        private IWebDriver Driver { get; set; }

        public NextHomePage(IWebDriver driver)
        {
            Driver = driver;
            //sfjslkdfjlksd
        }

        public bool IsVisible { get; internal set; }

        internal void GoTo()
        {
            //asdasd
            Driver.Navigate().GoToUrl("https://www.next.co.il/he");
        } 
    }
}