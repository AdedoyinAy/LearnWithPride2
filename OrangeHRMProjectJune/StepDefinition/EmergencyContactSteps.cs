using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
   
{

    [Binding]
    public class EmergencyContactSteps
    {


        EmergencyContactPage emergencyContactPage;
        public EmergencyContactSteps()
        {
            emergencyContactPage = new EmergencyContactPage();
        }
        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            emergencyContactPage.NavigateTowebsite();
        }
        
        [Given(@"I enter admin username")]
        public void GivenIEnterAdminUsername()
        {
            emergencyContactPage.EnterAdminUsername();
        }
        
        [Given(@"I enter admin password")]
        public void GivenIEnterAdminPassword()
        {
            emergencyContactPage.EnterAdminpassword();
        }
        
        [Given(@"I click on login")]
        public void GivenIClickOnLogin()
        {
            emergencyContactPage.ClickLogin();
        }
        
        [Given(@"I click on PIM")]
        public void GivenIClickOnPIM()
        {
            emergencyContactPage.ClickPIM();
        }
        
        [Given(@"I click on add employee")]
        public void GivenIClickOnAddEmployee()
        {
            emergencyContactPage.ClickAddEmloyee();
        }
        
        [Given(@"I enter employee first name")]
        public void GivenIEnterEmployeeFirstName()
        {
            emergencyContactPage.EnterEmployeeFirstName();
        }
        
        [Given(@"I enter employee lastname")]
        public void GivenIEnterEmployeeLastname()
        {
            emergencyContactPage.EnterEmployeeLastname();
        }
        
        [Given(@"I load employee photograph")]
        public void GivenILoadEmployeePhotograph()
        {
            emergencyContactPage.UploadEmployeephotograph();
        }
        
        [Given(@"I click on log in details")]
        public void GivenIClickOnLogInDetails()
        {
            emergencyContactPage.ClickEmployeelogindetails();
        }
        
        [Given(@"I enter employee username")]
        public void GivenIEnterEmployeeUsername()
        {
            emergencyContactPage.EnterEmployeeUsername();
        }
        
        [Given(@"I enter employee password")]
        public void GivenIEnterEmployeePassword()
        {
            emergencyContactPage.EnterEmployeePassword();
        }
        
        [Given(@"i enter password confirmation")]
        public void GivenIEnterPasswordConfirmation()
        {
            emergencyContactPage.EnterEmployeerPasswordConfirmation();
        }
        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            emergencyContactPage.ClicksaveEmployeeDetails();
        }

        [Then(@"I should be able to add an employee successfully")]
        public void ThenIShouldBeAbleToAddAnEmployeeSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(emergencyContactPage.IsJobDisplayed);
        }

        [Then(@"I click on profile")]
        public void ThenIClickOnProfile()
        {
            emergencyContactPage.ClickProfile();
        }

        [Then(@"I click on Logout")]
        public void ThenIClickOnLogout()
        {
            emergencyContactPage.ClickLogout();
        }







        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            emergencyContactPage.NavigateToThewebsite();
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            emergencyContactPage.EnterUsername();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            emergencyContactPage.EnterPassword();
        }
        
        [Given(@"I click on Loging in")]
        public void GivenIClickOnLogingIn()
        {
            emergencyContactPage.ClickLogingin();
        }
        
        [Given(@"I click on my info")]
        public void GivenIClickOnMyInfo()
        {
            emergencyContactPage.ClickMyinfo();
        }
        
        [Given(@"I click on emergency contact")]
        public void GivenIClickOnEmergencyContact()
        {
            emergencyContactPage.ClickEmergencyContact();
        }
        
        [Given(@"I click on add")]
        public void GivenIClickOnAdd()
        {
            emergencyContactPage.ClickAdd();
        }
        
        [Given(@"I enter emergency contact name")]
        public void GivenIEnterEmergencyContactName()
        {
            emergencyContactPage.EnterEmergencyContactName();
        }
        
        [Given(@"I enter emergency contact relationship")]
        public void GivenIEnterEmergencyContactRelationship()
        {
            emergencyContactPage.EnterEmergencyContactRelationship();
        }
        
        [Given(@"I enter emergency contact mobile")]
        public void GivenIEnterEmergencyContactMobile()
        {
            emergencyContactPage.EnterEmergencyContactMobile();
        }


        [When(@"I click on SAVE")]
        public void WhenIClickOnSAVE()
        {
            emergencyContactPage.ClickSAVE();
        }

        [Then(@"I should be able to add emergency contact")]
        public void ThenIShouldBeAbleToAddEmergencyContact()
        {
            Assert.That(emergencyContactPage.IsWorkTelephoneDisplayed);
        }

        [Then(@"i click on logging out profile")]
        public void ThenIClickOnLoggingOutProfile()
        {
            emergencyContactPage.ClickLoggingOutProfile();
        }
        [Then(@"I click on LOGOUT")]
        public void ThenIClickOnLOGOUT()
        {
            emergencyContactPage.ClickLOGOUT();
        }

        [Given(@"I Re navigate to the website")]
        public void GivenIReNavigateToTheWebsite()
        {
            emergencyContactPage.ReNavigateTowebsite();
        }

        [Given(@"I Re enter admin username")]
        public void GivenIReEnterAdminUsername()
        {
           emergencyContactPage.ReEnterAdminUsername();
        }

        [Given(@"I  Re enter admin password")]
        public void GivenIReEnterAdminPassword()
        {
            emergencyContactPage.ReEnterAdminpassword();
        }

        [Given(@"I Re click on LOGIN")]
        public void GivenIReClickOnLOGIN()
        {
            emergencyContactPage.ReClickLogin();
        }

        [Given(@"I Re click on PIM")]
        public void GivenIReClickOnPIM()
        {
            emergencyContactPage.ReClickPIM();
        }

        [Given(@"I click employee list")]
        public void GivenIClickEmployeeList()
        {
            emergencyContactPage.ClickEmployeeList();
        }

        [Given(@"I insert employee details")]
        public void GivenIInsertEmployeeDetails()
        {
            emergencyContactPage.EnterInsertEmployeename();
        }

        [Given(@"I click ID")]
        public void GivenIClickID()
        {
            emergencyContactPage.ClickID();
        }


        [Given(@"I click on Delete")]
        public void GivenIClickOnDelete()
        {
            emergencyContactPage.ClickDelete();
        }

        [When(@"I click on oK")]
        public void WhenIClickOnOK()
        {
            emergencyContactPage.ClickOk();
        }

        [Then(@"I should be able to successfully delete the added employee details")]
        public void ThenIShouldBeAbleToSuccessfullyDeleteTheAddedEmployeeDetails()
        {
            Thread.Sleep(4000);
            Assert.That (emergencyContactPage.IsMaintenanceDisplayed);
        }
        [Then(@"I click on profileToLogout")]
        public void ThenIClickOnProfileToLogout()
        {
            emergencyContactPage.ClickProfileToLogOut();
        }

        [Then(@"I click on LOGGINGOUT")]
        public void ThenIClickOnLOGGINGOUT()
        {
            emergencyContactPage.ClickLOGINOUT();
        }





    }
}
