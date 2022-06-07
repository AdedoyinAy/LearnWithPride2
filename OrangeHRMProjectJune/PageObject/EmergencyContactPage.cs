using OpenQA.Selenium;
using OrangeHRMProjectJune.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRMProjectJune.PageObject
{
    class EmergencyContactPage
    {
        public EmergencyContactPage()
        {
            driver = Hooks.driver;
        }
        IWebDriver driver;


        IWebElement AdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement AdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement Login => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement PIM => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));
        IWebElement AddEmployee => driver.FindElement(By.XPath("//*[@id='menu_pim_addEmployee']"));
        IWebElement EmployeeFirstname => driver.FindElement(By.XPath("//*[@id='firstName']"));
        IWebElement EmployeeLastname => driver.FindElement(By.XPath("//*[@id='lastName']"));
        IWebElement EmployeePhotograph => driver.FindElement(By.XPath("//*[@id='photofile']"));
        IWebElement EmployeeLogindetails => driver.FindElement(By.XPath("//*[@id='chkLogin']"));
        IWebElement EmployeeUsername => driver.FindElement(By.CssSelector("#user_name"));
        IWebElement EmployeePassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement EmployeePasswordConfirmation => driver.FindElement(By.XPath("//*[@id='re_password']"));
        IWebElement SaveEmployeeDetails => driver.FindElement(By.XPath("//*[@id='btnSave']"));
        IWebElement Job => driver.FindElement(By.XPath("//*[@id='sidenav']/li[6]/a"));
        IWebElement Profile => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement AdminLogout => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement Logingin => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement Myinfo => driver.FindElement(By.CssSelector("#menu_pim_viewMyDetails > b"));
        IWebElement EmergencyContact => driver.FindElement(By.CssSelector("#sidenav > li:nth-child(3) > a"));
        IWebElement Add => driver.FindElement(By.XPath("//*[@id='btnAddContact']"));
        IWebElement EmergencyContactName => driver.FindElement(By.XPath("//*[@id='emgcontacts_name']"));
        IWebElement EmergencyContactRelationship => driver.FindElement(By.XPath("//*[@id='emgcontacts_relationship']"));
        IWebElement EmergencyContactMobile => driver.FindElement(By.XPath("//*[@id='emgcontacts_mobilePhone']"));
        IWebElement SAVE => driver.FindElement(By.XPath("//*[@id='btnSaveEContact']"));
        IWebElement WorkTelephone => driver.FindElement(By.XPath("//*[@id='emgcontact_list']/thead/tr/th[6]"));
        IWebElement LoggingOutprofile => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement LOGOUT => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));
        IWebElement ReAdminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));
        IWebElement ReAdminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));
        IWebElement ReLogin => driver.FindElement(By.XPath("//*[@id='btnLogin']"));
        IWebElement RePIM => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));
        IWebElement EmployeeList => driver.FindElement(By.XPath("//*[@id='menu_pim_viewEmployeeList']"));
        IWebElement InsertEmployeename => driver.FindElement(By.XPath("//*[@id='empsearch_employee_name_empName']"));
        IWebElement ID => driver.FindElement(By.XPath("//*[@id='ohrmList_chkSelectAll']"));
        IWebElement Delete => driver.FindElement(By.XPath("//*[@id='btnDelete']"));
        IWebElement Ok => driver.FindElement(By.XPath("//*[@id='dialogDeleteBtn']"));
        IWebElement Maintenance => driver.FindElement(By.XPath("//*[@id='menu_maintenance_purgeEmployee']/b"));
        IWebElement ProfileToLogout => driver.FindElement(By.XPath("//*[@id='welcome']"));
        IWebElement LOGINGOUT => driver.FindElement(By.XPath("//*[@id='welcome-menu']/ul/li[3]/a"));




        public void NavigateTowebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials");
        }
        public void EnterAdminUsername()
        {
            AdminUsername.SendKeys("Admin");
        }
        public void EnterAdminpassword()
        {
            AdminPassword.SendKeys("admin123");
        }
        public void ClickLogin()
        {
            Login.Click();
        }
        public void ClickPIM()
        {
            PIM.Click();
        }
        public void ClickAddEmloyee()
        {
            AddEmployee.Click();
        }
        public void EnterEmployeeFirstName()
        {
            EmployeeFirstname.SendKeys("Lapite");
        }
        public void EnterEmployeeLastname()
        {
            EmployeeLastname.SendKeys("Ajenifuja");
        }
        public void UploadEmployeephotograph()
        {
            EmployeePhotograph.SendKeys("C:/Users/DELL/Source/Repos/OrangeHRMProjectLive/OrangeHRMProjectJune/TestDataImages/SportCar.jpg");
        }
        public void ClickEmployeelogindetails()
        {
            EmployeeLogindetails.Click();
        }
        public void EnterEmployeeUsername()
        {
            EmployeeUsername.SendKeys("Lapiteajenifuja");
        }
        public void EnterEmployeePassword()
        {
            EmployeePassword.SendKeys("ikumapayi123");
        }
        public void EnterEmployeerPasswordConfirmation()
        {
            EmployeePasswordConfirmation.SendKeys("ikumapayi123");
        }
        public void ClicksaveEmployeeDetails()
        {
            SaveEmployeeDetails.Click();
        }
        public bool IsJobDisplayed()
        {
            return Job.Displayed;
        }
        public void ClickProfile()
        {
            Profile.Click();
        }
        public void ClickLogout()
        {
            AdminLogout.Click();
        }
        public void NavigateToThewebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials");
        }
        public void EnterUsername()
        {
            Username.SendKeys("Lapiteajenifuja");
        }
        public void EnterPassword()
        {
            Password.SendKeys("ikumapayi123");
        }
        public void ClickLogingin()
        {
            Logingin.Click();
        }
        public void ClickMyinfo()
        {
            Myinfo.Click();
        }
        public void ClickEmergencyContact()
        {
            EmergencyContact.Click();
        }
        public void ClickAdd()
        {
            Add.Click();
        }
        public void EnterEmergencyContactName()
        {
            EmergencyContactName.SendKeys("Orimogunje Apaokagi");
        }
        public void EnterEmergencyContactRelationship()
        {
            EmergencyContactRelationship.SendKeys("Onigbajamo");
        }
        public void EnterEmergencyContactMobile()
        {
            EmergencyContactMobile.SendKeys("8035803784");
        }
        public void ClickSAVE()
        {
            SAVE.Click();
        }
        public bool IsWorkTelephoneDisplayed()
        {
            return WorkTelephone.Displayed;
        }
        public void ClickLoggingOutProfile()
        {
            LoggingOutprofile.Click();
        }
        public void ClickLOGOUT()
        {
            LOGOUT.Click();
        }
        public void ReNavigateTowebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials");
        }
        public void ReEnterAdminUsername()
        {
            ReAdminUsername.SendKeys("Admin");
        }
        public void ReEnterAdminpassword()
        {
            ReAdminPassword.SendKeys("admin123");
        }
        public void ReClickLogin()
        {
            ReLogin.Click();
        }
        public void ReClickPIM()
        {
            RePIM.Click();
        }
        public void ClickEmployeeList()
        {
            EmployeeList.Click();
        }
        public void EnterInsertEmployeename()
        {
           InsertEmployeename.SendKeys("LapiteAjenifuja");
        }
        public void ClickID()
        {
            ID.Click();
        }
        public void ClickDelete()
        {
            Delete.Click();
        }
        public void ClickOk()
        {
            Ok.Click();
        }
        public bool IsMaintenanceDisplayed()
        {
            return Maintenance.Displayed;
        }
        public void ClickProfileToLogOut()
        {
            ProfileToLogout.Click();
        }
        public void ClickLOGINOUT()
        {
            LOGINGOUT.Click();
        }


    }
}
