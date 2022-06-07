using OpenQA.Selenium;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class DataDrivenWithExampleAddJobCategoryPage
    {
        public DataDrivenWithExampleAddJobCategoryPage()
        {
            driver = Hooks.driver;
        }
        IWebDriver driver;



        IWebElement ADminusername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement ADminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement NewJOBcategory => driver.FindElement(By.XPath("//*[@id='jobCategory_name']"));



        public void NavigateToWEBSITE(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        public void EnterADMINusername(String AdminUserName)
        {
            ADminusername.SendKeys(AdminUserName);
        }
        public void EnterADMINpassword(String AdminpassWord)
        {
            ADminPassword.SendKeys(AdminpassWord);
        }
        public void EnterJobCATegories(String NewJobCategories)
        {
            NewJOBcategory.SendKeys(NewJobCategories);
        }




    }
}
