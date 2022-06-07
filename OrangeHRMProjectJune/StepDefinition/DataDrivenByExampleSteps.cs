using OrangeHRMProjectJune.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class DataDrivenByExampleSteps
    {
        DataDrivenByExamplePage dataDrivenByExamplePage;
        public DataDrivenByExampleSteps()
        {
            dataDrivenByExamplePage = new DataDrivenByExamplePage();
        }
            


        [Given(@"I Enter employee Firstname""(.*)""")]
        public void GivenIEnterEmployeeFirstname(string employeefirstname)
        {
            dataDrivenByExamplePage.EnterEmployeeFirstName(employeefirstname);
        }
        
        [Given(@"I Enter employee Lastname ""(.*)""")]
        public void GivenIEnterEmployeeLastname(string employeelastname)
        {
           dataDrivenByExamplePage.EnterEmployeeLastname(employeelastname);
        }
        
        [Given(@"I Enter employee Username""(.*)""")]
        public void GivenIEnterEmployeeUsername(string employeeusername)
        {
            dataDrivenByExamplePage.EnterEmployeeUsername(employeeusername);
        }
        
        [Given(@"I Enter employee Password""(.*)""")]
        public void GivenIEnterEmployeePassword(string employeepassword)
        {
            dataDrivenByExamplePage.EnterEmployeePassword(employeepassword);
        }
        
        [Given(@"I Enter password Confirmation""(.*)""")]
        public void GivenIEnterPasswordConfirmation(string employeepasswordconfirmation)
        {
            dataDrivenByExamplePage.EnterEmployeerPasswordConfirmation(employeepasswordconfirmation);
        }
    }
}
