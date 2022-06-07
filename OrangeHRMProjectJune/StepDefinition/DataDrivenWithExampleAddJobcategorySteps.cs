using OrangeHRMProjectJune.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleAddJobCategorySteps
    {
        DataDrivenWithExampleAddJobCategoryPage dataDrivenWithExampleAddJobCategoryPage;
        public DataDrivenWithExampleAddJobCategorySteps()
        {
            dataDrivenWithExampleAddJobCategoryPage = new DataDrivenWithExampleAddJobCategoryPage();
        }

        [Given(@"Admin enter Username""(.*)""")]
        public void GivenAdminEnterUsername(string AdminUserName)
        {
            dataDrivenWithExampleAddJobCategoryPage.EnterADMINusername(AdminUserName);
        }
        
        [Given(@"Admin enter Password""(.*)""")]
        public void GivenAdminEnterPassword(string AdminPassWord)
        {
            dataDrivenWithExampleAddJobCategoryPage.EnterADMINpassword(AdminPassWord);
        }
        
        [Given(@"i enters new Category""(.*)""")]
        public void GivenIEntersNewCategory(string NewJobCategory)
        {
            dataDrivenWithExampleAddJobCategoryPage.EnterJobCATegories(NewJobCategory);
        }
    }
}
