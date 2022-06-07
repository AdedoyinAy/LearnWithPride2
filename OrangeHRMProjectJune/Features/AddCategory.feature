Feature: AddCategory
	As the admin, i want to add a new category

@mytag
Scenario: Admin to Add category
	Given the admin navigate to website
	And Admin enter username
	And Admin enter password
	And Admin clicks on log in
	And Admin clicks on ADMIN
	And admin clicks job
	And admin clicks on job categories
	And Admin clicks on add
	And Admin enters new category
	When Admin clicks on save 
	Then Admin should be able to add new category successfully
	And Admin clicks on profile
	And Admin clicks on Logout

 
	@mytag
Scenario: Admin to delete Job Category
	Given the ADMIN navigate to website
	And ADMIN enter username
	And ADMIN enter password
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







