using NUnit.Framework;
using OrangeHRMProjectJune.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRMProjectJune.StepDefinition
{
    [Binding]
    public class AddCategorySteps
    {

        AddCategoryPage addCategoryPage;
            public AddCategorySteps()
        {
            addCategoryPage = new AddCategoryPage();
        }
        
      


        [Given(@"the admin navigate to website")]
        public void GivenTheAdminNavigateToWebsite()
        {
            addCategoryPage.AdminNavigateToWebsite();
        }
        
        [Given(@"Admin enter username")]
        public void GivenAdminEnterUsername()
        {
            addCategoryPage.EnterAdminUsername();
        }
        
        [Given(@"Admin enter password")]
        public void GivenAdminEnterPassword()
        {
            addCategoryPage.EnterAdminpassword();
        }
        
        [Given(@"Admin clicks on log in")]
        public void GivenAdminClicksOnLogIn()
        {
            addCategoryPage.ClickLogin();
        }
        
        [Given(@"Admin clicks on ADMIN")]
        public void GivenAdminClicksOnADMIN()
        {
            addCategoryPage.clickADMIN();
        }
        
        [Given(@"admin clicks job")]
        public void GivenAdminClicksJob()
        {
           addCategoryPage.ClickJob();
        }
        
        [Given(@"admin clicks on job categories")]
        public void GivenAdminClicksOnJobCategories()
        {
            addCategoryPage.Clickjobcategories();
        }
        
        [Given(@"Admin clicks on add")]
        public void GivenAdminClicksOnAdd()
        {
            addCategoryPage.ClickAdd();
        }
        
        [Given(@"Admin enters new category")]
        public void GivenAdminEntersNewCategory()
        {
            addCategoryPage.EnterNewcategory();
        }
        
        [When(@"Admin clicks on save")]
        public void WhenAdminClicksOnSave()
        {
            addCategoryPage.ClickSave();
        }
        
        [Then(@"Admin should be able to add new category successfully")]
        public void ThenAdminShouldBeAbleToAddNewCategorySuccessfully()
        {
            //Thread.Sleep(5000);
            //Assert.That(addCategoryPage.IsDirectoryDisplayed);
        }
        [Then(@"Admin clicks on profile")]
        public void ThenAdminClicksOnProfile()
        {
            addCategoryPage.ClickPROFILE();
        }

        [Then(@"Admin clicks on Logout")]
        public void ThenAdminClicksOnLogout()
        {
            addCategoryPage.Clicklogout();
        }



        [Given(@"the ADMIN navigate to website")]
        public void GivenTheADMINNavigateToWebsite()
        {
            addCategoryPage.ADMINNavigateToWebsite();
        }

        [Given(@"ADMIN enter username")]
        public void GivenADMINEnterUsername()
        {
            addCategoryPage.EnterADMINusername();
        }

        [Given(@"ADMIN enter password")]
        public void GivenADMINEnterPassword()
        {
            addCategoryPage.EnterADMINpassword();
        }

        [Given(@"ADMIN clicks on log in")]
        public void GivenADMINClicksOnLogIn()
        {
            addCategoryPage.ClickADMINLogin();
        }

        [Given(@"ADMIN clicks on ADMIN")]
        public void GivenADMINClicksOnADMIN()
        {
            addCategoryPage.clickADMIN();
        }

        [Given(@"ADMIN clicks job")]
        public void GivenADMINClicksJob()
        {
            addCategoryPage.ClickJOB();
        }

        [Given(@"ADMIN clicks on job categories")]
        public void GivenADMINClicksOnJobCategories()
        {
            addCategoryPage.ClickJOBCATEGORIES();
        }

        [Given(@"ADMIN clicks on added job categories")]
        public void GivenADMINClicksOnAddedJobCategories()
        {
            addCategoryPage.ClickAddedJobCategory();
        }

        [Given(@"ADMIN clicks on delete")]
        public void GivenADMINClicksOnDelete()
        {
            addCategoryPage.ClickDelete();
        }

        [When(@"ADMIN clicks on ok")]
        public void WhenADMINClicksOnOk()
        {
           addCategoryPage.ClickOk();
        }

        [Then(@"ADMIN should be able to delete job category succesfully")]
        public void ThenADMINShouldBeAbleToDeleteJobCategorySuccesfully()
        {
            //Thread.Sleep(3000);
            //Assert.That(addCategoryPage.IsAddDisplayed);
        }
        [Then(@"I click profile")]
        public void ThenIClickProfile()
        {
           addCategoryPage.Clickprofile();
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            addCategoryPage.ClickLogout();
        }




        [Given(@"I clicks on Leave")]
        public void GivenIClicksOnLeave()
        {
            addCategoryPage.ClickLeave();
        }

        [Given(@"I click on assign leave")]
        public void GivenIClickOnAssignLeave()
        {
            addCategoryPage.ClickAssignLeave();
        }

        [Given(@"I Select leave type")]
        public void GivenISelectLeaveType()
        {
            addCategoryPage.SelectLeaveTypeFromDropdown();
        }
        [Given(@"Admin clicks on profile")]
        public void GivenAdminClicksOnProfile()
        {
            addCategoryPage.ClickPROfile();
        }

        [Given(@"Admin clicks on Logout")]
        public void GivenAdminClicksOnLogout()
        {
            addCategoryPage.ClickLOGout();
        }





    }

}
