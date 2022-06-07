Feature: DataDrivenWithParameterAddJobCategory
	

@mytag
Scenario: Admin to Add job category
    Given the admin navigate to website"https://opensource-demo.orangehrmlive.com/index.php/auth/validateCredentials"
	And Admin enter username"Admin"
	And Admin enter password"admin123"
	And Admin clicks on log in
	And Admin clicks on ADMIN
	And admin clicks job
	And admin clicks on job categories
	And Admin clicks on add
    And i enters new category"Automation Tester"
	When Admin clicks on save 
	Then Admin should be able to add new category successfully
	And Admin clicks on profile
	And Admin clicks on Logout



	@mytag
Scenario: Admin to delete Job Category
	Given the ADMIN navigate to website
	And ADMIN enter username"Admin"
	And ADMIN enter password"admin123"
	And ADMIN clicks on log in
	And ADMIN clicks on ADMIN
	And ADMIN clicks job
	And ADMIN clicks on job categories
	And ADMIN clicks on added job categories
	And ADMIN clicks on delete
	When ADMIN clicks on ok
	Then ADMIN should be able to delete job category succesfully
	And I click profile
	And I click logout
