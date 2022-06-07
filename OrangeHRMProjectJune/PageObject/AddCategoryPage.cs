using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class AddCategoryPage
      
    {
        public AddCategoryPage()
        {
            driver = Hooks.driver;
        }

        IWebDriver driver;



        IWebElement adminusername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement AdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement ADMIN => driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']/b"));
        IWebElement Job => driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));
        IWebElement Jobcategories => driver.FindElement(By.XPath("//*[@id='menu_admin_jobCategory']"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='btnAdd']"));
        IWebElement Newcategory => driver.FindElement(By.XPath("//*[@id='jobCategory_name']"));
        IWebElement Save => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Directory => driver.FindElement(By.XPath("//*[@id='menu_directory_viewDirectory']/b"));
        IWebElement PROFILE => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement LOGOUT => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));
        IWebElement ADMINusername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement ADMINpassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement ADMINlogin => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement Admin => driver.FindElement(By.XPath("//*[@id='menu_admin_viewAdminModule']/b"));
        IWebElement JOB => driver.FindElement(By.XPath("//*[@id='menu_admin_Job']"));
        IWebElement JOBCATEGORIES => driver.FindElement(By.XPath("//*[@id='menu_admin_jobCategory']"));
        IWebElement AddedJobCategories => driver.FindElement(By.XPath("//*[@id='resultTable']/tbody/tr[1]/td[1]"));
        IWebElement DELETE => driver.FindElement(By.XPath("//*[@id='btnDelete']"));
        IWebElement OK => driver.FindElement(By.XPath("//*[@id='dialogDeleteBtn']"));
        IWebElement profile => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement logout => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));
        IWebElement ADD => driver.FindElement(By.XPath("//*[@id='btnAdd']"));


        IWebElement Leave => driver.FindElement(By.XPath("//*[@id='menu_leave_viewLeaveModule']/b"));
        IWebElement AssignLeave => driver.FindElement(By.XPath("//*[@id='menu_leave_assignLeave']"));
        IWebElement LeaveType => driver.FindElement(By.XPath("//*[@id='assignleave_txtLeaveType']"));
        IWebElement PROfile => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement LOGout => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));



        public void AdminNavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials");
        }
        public void EnterAdminUsername()
        {
            adminusername.SendKeys("Admin");
        }
        public void EnterAdminpassword()
        {
            AdminPassword.SendKeys("admin123");
        }
        public void ClickLogin()
        {
            Login.Click();
        }
        public void clickADMIN()
        {
            ADMIN.Click();
        }
        public void ClickJob()
        {
            Job.Click();
        }
        public void Clickjobcategories()
        {
            Jobcategories.Click();
        }
        public void ClickAdd()
        {
            Add.Click();
        }
       public void EnterNewcategory()
        {
            Newcategory.SendKeys("Automation Tester");
        }
        public void ClickSave()
        {
            Save.Click();
        }
        public bool IsDirectoryDisplayed()
        {
            return IsDirectoryDisplayed();
        }
        public void ClickPROFILE()
        {
            PROFILE.Click();
        }
        public void Clicklogout()
        {
            LOGOUT.Click();
        }


        public void ADMINNavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials");
        }
        public void EnterADMINusername()
        {
           ADMINusername.SendKeys("Admin");
        }
        public void EnterADMINpassword()
        {
            ADMINpassword.SendKeys("admin123");
        }
        public void ClickADMINLogin()
        {
            ADMINlogin.Click();
        }
        public void clickAdmin()
        {
            Admin.Click();
        }
        public void ClickJOB()
        {
            JOB.Click();
        }
        public void ClickJOBCATEGORIES()
        {
            JOBCATEGORIES.Click();
        }
        public void ClickAddedJobCategory()
        {
            AddedJobCategories.Click();
        }
        public void ClickDelete()
        {
            DELETE.Click();
        }
        public void ClickOk()
        {
            OK.Click();
        }

        public bool IsAddDisplayed()
        {
            return IsAddDisplayed();
        }
        public void Clickprofile()
        {
            profile.Click();
        }
        public void ClickLogout()
        {
            logout.Click();
        }


        public void ClickLeave()
        {
            Leave.Click();
        }
        public void ClickAssignLeave()
        {
            AssignLeave.Click();
        }
        public void SelectLeaveTypeFromDropdown()
        {
            SelectElement Select = new SelectElement(LeaveType);
            Select.SelectByIndex(4);
        }
        public void ClickPROfile()
        {
            PROfile.Click();
        }
        public void ClickLOGout()
        {
            LOGout.Click();
        }



    }




}

