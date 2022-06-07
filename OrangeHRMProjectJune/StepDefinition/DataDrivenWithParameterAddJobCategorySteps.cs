using OrangeHRMProjectJune.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterAddJobCategorySteps
    {
        DataDrivenWithParameterAddJobCategoryPage dataDrivenWithParameterAddJobCategoryPage;
       public  DataDrivenWithParameterAddJobCategorySteps()
        {
            dataDrivenWithParameterAddJobCategoryPage = new DataDrivenWithParameterAddJobCategoryPage();
        }



        [Given(@"the admin navigate to website""(.*)""")]
        public void GivenTheAdminNavigateToWebsite(string Url)
        {
            dataDrivenWithParameterAddJobCategoryPage.NavigateToWebsite(Url);
        }

        [Given(@"Admin enter username""(.*)""")]
        public void GivenAdminEnterUsername(string Username)
        {
            dataDrivenWithParameterAddJobCategoryPage.EnterAdminUserName(Username);
        }

        [Given(@"Admin enter password""(.*)""")]
        public void GivenAdminEnterPassword(string Password)
        {
            dataDrivenWithParameterAddJobCategoryPage.EnterAdminpassword(Password);
        }

        [Given(@"i enters new category""(.*)""")]
        public void GivenIEntersNewCategory(string NewJobCategory)
        {
            dataDrivenWithParameterAddJobCategoryPage.EnterNewJobcategory(NewJobCategory);
        }
        [Given(@"ADMIN enter username""(.*)""")]
        public void GivenADMINEnterUsername(string Adminusername)
        {
           dataDrivenWithParameterAddJobCategoryPage.EnterAdminUserName(Adminusername);
        }

        [Given(@"ADMIN enter password""(.*)""")]
        public void GivenADMINEnterPassword(string Adminpassword)
        {
           dataDrivenWithParameterAddJobCategoryPage.EnterAdminPassword(Adminpassword);
        }




    }
}
