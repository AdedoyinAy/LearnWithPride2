Feature: DataDrivenByExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline:admin to log in and add employee
	Given I navigate to website "https://opensource-demo.orangehrmlive.com"
	And I Enter admin username"Admin"
	And I Enter admin password"admin123"
	And I click on login 
	And I click on PIM
	And I click on add employee
	And I Enter employee Firstname"<EmployeeFirstName>"
	And I Enter employee Lastname "<EmployeeLastName>"
	And I load employee photograph
	And I click on log in details
	And I Enter employee Username"<UserName>"
	And I Enter employee Password"<UserPassword>"
	And I Enter password Confirmation"<UserPasswordConfirmation>"
	When I click on save
	Then I should be able to add an employee successfully
	And I click on profile
	And I click on Logout

	Examples: 
	| EmployeeFirstName | EmployeeLastName | UserName    | UserPassword | UserPasswordConfirmation |
	| Folawiyo           | Kilanko          | Folakilanko | kilafola123      | kilafola123                  |
	| Jackie             | Chan             | Jackiechan  | jackie123    | jackie123                |