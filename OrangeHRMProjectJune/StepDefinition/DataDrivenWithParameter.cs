using OrangeHRMProjectJune.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;
        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }



        [Given(@"I navigate to website ""(.*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            dataDrivenWithParameterPage.NavigateTowebsite(url);
        }

        [Given(@"I Enter admin username""(.*)""")]
        public void GivenIEnterAdminUsername(string adminusername)
        {
            dataDrivenWithParameterPage.EnterAdminUsername(adminusername);
        }
        [Given(@"I Enter admin password""(.*)""")]
        public void GivenIEnterAdminPassword(string adminpasswor )
        {
            dataDrivenWithParameterPage.EnterAdminpassword(adminpasswor);
        }
        [Given(@"I Enter employee first name""(.*)""")]
        public void GivenIEnterEmployeeFirstName(string employeefirstname)
        {
            dataDrivenWithParameterPage.EnterEmployeeFirstName(employeefirstname);
        }

        [Given(@"I Enter employee lastname ""(.*)""")]
        public void GivenIEnterEmployeeLastname(string employeelastname)
        {
            dataDrivenWithParameterPage.EnterEmployeeLastname(employeelastname);
        }

        [Given(@"I Enter employee username""(.*)""")]
        public void GivenIEnterEmployeeUsername(string employeeusername)
        {
            dataDrivenWithParameterPage.EnterEmployeeUsername(employeeusername);
        }

        [Given(@"I Enter employee password""(.*)""")]
        public void GivenIEnterEmployeePassword(string employeepassword)
        {
            dataDrivenWithParameterPage.EnterEmployeePassword(employeepassword);
        }

        [Given(@"I Enter password confirmation""(.*)""")]
        public void GivenIEnterPasswordConfirmation(string employeepasswodconfirmation)
        {
           dataDrivenWithParameterPage.EnterEmployeerPasswordConfirmation(employeepasswodconfirmation);
        }
        [Given(@"I Enter my username""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }

        [Given(@"I Enter my password""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }

        [Given(@"I Enter emergency contact name""(.*)""")]
        public void GivenIEnterEmergencyContactName(string emergencycontactname)
        {
            dataDrivenWithParameterPage.EnterEmergencyContactName(emergencycontactname);
        }

        [Given(@"I Enter emergency contact relationship""(.*)""")]
        public void GivenIEnterEmergencyContactRelationship(string emergencycontactrelationship)
        {
            dataDrivenWithParameterPage.EnterEmergencyContactRelationship(emergencycontactrelationship);
        }

        [Given(@"I Enter emergency contact mobile""(.*)""")]
        public void GivenIEnterEmergencyContactMobile(String emergencycontactmobile)
        {
            dataDrivenWithParameterPage.EnterEmergencyContactMobile(emergencycontactmobile);
        }

        [Given(@"I Re Enter admin username""(.*)""")]
        public void GivenIReEnterAdminUsername(string reenteradminusername)
        {
            dataDrivenWithParameterPage.ReEnterAdminUsername(reenteradminusername);
        }

        [Given(@"I  Re Enter admin password""(.*)""")]
        public void GivenIReEnterAdminPassword(string reenteradminpassword)
        {
            dataDrivenWithParameterPage.ReEnterAdminpassword(reenteradminpassword);
        }

        
        [Given(@"I Enter the employee name""(.*)""")]
        public void GivenIEnterTheEmployeeName(string insertemployeename)
        {
            dataDrivenWithParameterPage.Enterinsertemployeename(insertemployeename);
        }

        





    }

}







        