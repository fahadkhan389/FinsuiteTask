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
    class AngularTodoPage
    {
        public AngularTodoPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='What needs to be done?']")]
        public IWebElement InputTxtBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='examples/angular2']")]
        public IWebElement AngularLink { get; set; }



        public void EnterTodoinTxtBox()
        {
            SeleniumWrapper.FilltextBox(InputTxtBox,"myTodo1");
            Thread.Sleep(3000);

        }
        


    }
}
