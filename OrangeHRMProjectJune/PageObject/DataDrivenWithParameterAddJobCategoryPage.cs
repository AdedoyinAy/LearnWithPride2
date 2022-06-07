using OpenQA.Selenium;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class DataDrivenWithParameterAddJobCategoryPage
    {
        public DataDrivenWithParameterAddJobCategoryPage()
        {
            driver = Hooks.driver;
        }
        IWebDriver driver;

        IWebElement JobCategory => driver.FindElement(By.XPath("//*[@id='jobCategory_name']"));
        IWebElement AdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement AdminPassWord => driver.FindElement(By.XPath("//*[@id='txtPassword']"));



        public void NavigateToWebsite(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
        public void EnterAdminUserName(string Username)
        {
            AdminUsername.SendKeys(Username);
        }
        public void EnterAdminpassword(String Password)
        {
            AdminPassWord.SendKeys(Password);
        }
        public void EnterNewJobcategory(String NewJobCategory)
        {
            JobCategory.SendKeys(NewJobCategory);
        }
        public void EnterAminUsername(String Adminusername)
        {
            AdminUsername.SendKeys(Adminusername);
        }
        public void EnterAdminPassword(String Adminpassword)
        {
            AdminPassWord.SendKeys(Adminpassword);
        }

    }
}
