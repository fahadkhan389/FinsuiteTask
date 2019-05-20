using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinsuiteTask.Common;
using FinsuiteTask.Pages;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace FinsuiteTask.Steps
{
    [Binding]
    public sealed class CommonSteps
    {

        [Given(@"i have opened a FireFox browser")]
        public void GivenIHaveOpenedFFBrowser()
        {
            PropertiesCollection.driver = new FirefoxDriver();

        }
        [Given(@"i am on Todo MVC Website")]
        public void GivenIAmOnTodoMVCWebsite()
        {
            try
            {
                PropertiesCollection.driver.Navigate().GoToUrl("https://http://todomvc.com");
                PropertiesCollection.driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                throw e;

            }
        }



        


        [Given(@"I click on Angular link")]
        public void GivenIClickOnAngularLink()
        {
            try
            {

                TodoPage MyTodogpage = new TodoPage();
                MyTodogpage.ClickAngularLink();
            }
            catch (Exception e)
            {
                throw e;


            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }


        }



        [Given(@"I click on Labs")]
        public void GivenIClickOnLabs()
        {
            try
            {

                TodoPage MyTodogpage = new TodoPage();
                MyTodogpage.ClickLabLink();
            }
            catch (Exception e)
            {
                throw e;


            }
            finally
            {
                PropertiesCollection.driver.Close();
                PropertiesCollection.driver.Quit();
            }



        }
    }
}