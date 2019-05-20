using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinsuiteTask.Common
{
    class SeleniumWrapper
    {

        public static void FilltextBox(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        public static Boolean IsElementDisplayed(IWebElement element)

        {
            return (element.Displayed && element.Enabled);

        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();

        }
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");

        }





    }
}
