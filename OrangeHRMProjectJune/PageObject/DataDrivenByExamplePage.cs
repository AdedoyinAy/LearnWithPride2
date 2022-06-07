using OpenQA.Selenium;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class DataDrivenByExamplePage
    {
        public DataDrivenByExamplePage()
        {
            driver = Hooks.driver;
        }
        IWebDriver driver;

        IWebElement EmployeeFirstName => driver.FindElement(By.XPath("//*[@id='firstName']"));
        IWebElement EmployeeLastName => driver.FindElement(By.XPath("//*[@id='lastName']"));
        IWebElement UserName => driver.FindElement(By.CssSelector("#user_name"));
        IWebElement UserPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement UserPasswordConfirmation => driver.FindElement(By.XPath("//*[@id='re_password']"));



        public void EnterEmployeeFirstName(String employeefirstname)
        {
            EmployeeFirstName.SendKeys(employeefirstname);
        }
        public void EnterEmployeeLastname(String employeelastname)
        {
            EmployeeLastName.SendKeys(employeelastname);
        }
        public void EnterEmployeeUsername(String employeeusername)
        {
            UserName.SendKeys(employeeusername);
        }
        public void EnterEmployeePassword(String employeepassword)
        {
            UserPassword.SendKeys(employeepassword);
        }
        public void EnterEmployeerPasswordConfirmation(String employeepasswordconfirmation)
        {
            UserPasswordConfirmation.SendKeys(employeepasswordconfirmation);
        }









    }
}
