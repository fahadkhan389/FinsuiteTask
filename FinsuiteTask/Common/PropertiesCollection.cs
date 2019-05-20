using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinsuiteTask.Common
{
    public enum IdentityType
    {
        Id,
        Xpath,
        Name
    }

    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }
}
