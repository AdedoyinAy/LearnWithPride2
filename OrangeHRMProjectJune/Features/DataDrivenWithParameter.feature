Feature: DataDrivenWithParameter


@mytag
Scenario: Admin To Log in to add Employee
	Given I navigate to website "https://opensource-demo.orangehrmlive.com"
	And I Enter admin username"Admin"
	And I Enter admin password"admin123"
	And I click on login 
	And I click on PIM
	And I click on add employee
	And I Enter employee first name"Lapite"
	And I Enter employee lastname "Ajenifuja"
	And I load employee photograph
	And I click on log in details
	And I Enter employee username"Lapiteajenifuja"
	And I Enter employee password"ikumapayi123"
	And I Enter password confirmation"ikumapayi123"
	When I click on save
	Then I should be able to add an employee successfully
	And I click on profile
	And I click on Logout


	@mytag
Scenario:Employee to add emergency contact
Given I navigate to the website
And I Enter my username"Lapiteajenifuja"
And I Enter my password"ikumapayi123"
And I click on Loging in
And I click on my info
And I click on emergency contact
And I click on add
And I Enter emergency contact name"OrimogunjeApaokagi"
And I Enter emergency contact relationship"Onigbajamo"
And I Enter emergency contact mobile"8035803764"
When I click on SAVE
Then I should be able to add emergency contact
And i click on logging out profile
And I click on LOGOUT

   
   @mytag
Scenario:Admin to delete newly added employee details
Given I Re navigate to the website
And I Re Enter admin username"Admin"
And I  Re Enter admin password"admin123"
And I Re click on LOGIN
And I Re click on PIM
And I click employee list
And I Enter the employee name"LapiteAjenifuja"
And I Click on ID
And I click on Delete
When I click on oK
Then I should be able to successfully delete the added employee details
And I click on profileToLogout
And I click on LOGGINGOUT


