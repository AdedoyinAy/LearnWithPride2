using OpenQA.Selenium;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks.driver;
        }
        IWebDriver driver;

        IWebElement AdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement AdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement EmployeeFirstname => driver.FindElement(By.XPath("//*[@id='firstName']"));
        IWebElement EmployeeLastname => driver.FindElement(By.XPath("//*[@id='lastName']"));
        IWebElement EmployeeUsername => driver.FindElement(By.CssSelector("#user_name"));
        IWebElement EmployeePassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement EmployeePasswordConfirmation => driver.FindElement(By.XPath("//*[@id='re_password']"));
        IWebElement Username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement EmergencyContactName => driver.FindElement(By.XPath("//*[@id='emgcontacts_name']"));
        IWebElement EmergencyContactRelationship => driver.FindElement(By.XPath("//*[@id='emgcontacts_relationship']"));
        IWebElement EmergencyContactMobile => driver.FindElement(By.XPath("//*[@id='emgcontacts_mobilePhone']"));
        IWebElement ReAdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement ReAdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement InsertEmployeename => driver.FindElement(By.XPath("//*[@id='empsearch_employee_name_empName']"));
        IWebElement ID => driver.FindElement(By.XPath("//*[@id='ohrmList_chkSelectAll']"));





        public void NavigateTowebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void EnterAdminUsername(String adminusername)
        {
            AdminUsername.SendKeys(adminusername);
        }
        public void EnterAdminpassword(String adminpassword)
        {
            AdminPassword.SendKeys(adminpassword);
        }
        public void EnterEmployeeFirstName(String employeefirstname)
        {
            EmployeeFirstname.SendKeys(employeefirstname);
        }
        public void EnterEmployeeLastname(String employeelastname)
        {
            EmployeeLastname.SendKeys(employeelastname);
        }
        public void EnterEmployeeUsername(String employeeusername)
        {
            EmployeeUsername.SendKeys(employeeusername);
        }
        public void EnterEmployeePassword(String employeepassword)
        {
            EmployeePassword.SendKeys(employeepassword);
        }
        public void EnterEmployeerPasswordConfirmation(String employeepasswordconfirmation)
        {
            EmployeePasswordConfirmation.SendKeys(employeepasswordconfirmation);
        }
        public void EnterUsername(String username)
        {
            Username.SendKeys(username);
        }
        public void EnterPassword(String password)
        {
            Password.SendKeys(password);
        }
        public void EnterEmergencyContactName(String emergencycontactname)
        {
            EmergencyContactName.SendKeys(emergencycontactname);
        }
        public void EnterEmergencyContactRelationship(String emergencycontactrelationship)
        {
            EmergencyContactRelationship.SendKeys(emergencycontactrelationship);
        }
        public void EnterEmergencyContactMobile(String emergencycontactmobile)
        {
            EmergencyContactMobile.SendKeys(emergencycontactmobile);
        }
        public void ReEnterAdminUsername(string reenteradminusername)
        {
            ReAdminUsername.SendKeys(reenteradminusername);
        }
        public void ReEnterAdminpassword(string reenteradminpassword)
        {
            ReAdminPassword.SendKeys(reenteradminpassword);
        }
       public void Enterinsertemployeename(string insertemployeename)
        {
            InsertEmployeename.SendKeys(insertemployeename);
        }
        
            



    }
}
