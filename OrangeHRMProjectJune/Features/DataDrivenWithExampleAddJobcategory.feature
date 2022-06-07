Feature: DataDrivenWithExampleAddJobcategory
	

@mytag
Scenario Outline: Admin add Job category
	Given the admin navigate to website"https://opensource-demo.orangehrmlive.com/"
	And Admin enter Username"<UsernameAdmin>"
	And Admin enter Password"<UserpasswordAdmin>"
	And Admin clicks on log in
	And Admin clicks on ADMIN
	And admin clicks job
	And admin clicks on job categories
	And Admin clicks on add
	And i enters new Category"<NewJobCategory>"
	When Admin clicks on save 
	Then Admin should be able to add new category successfully
	And Admin clicks on profile
	And Admin clicks on Logout

	Examples: 
	|UsernameAdmin  | UserpasswordAdmin | NewJobCategory    |
	|Admin          | admin123          | Automation Tester |
	| Admin         | admin123          | Onigbajamo        |
	| Admin         | admin123          | Telecoms Engineer |
	| Admin         | admin123          | Baker             |