using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FinsuiteTask.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FinsuiteTask.Pages
{
    class TodoPage
    {
        public TodoPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='tabsContent']/paper-tab[3]/div")]
        public IWebElement LabsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='examples/angular2']")]
        public IWebElement AngularLink { get; set; }



        public void ClickLabLink()
        {
            SeleniumWrapper.ClickElement(LabsLink);
            Thread.Sleep(3000);

        }
        public void ClickAngularLink()
        {
            SeleniumWrapper.ClickElement(AngularLink);
            Thread.Sleep(3000);

        }

    }



}
