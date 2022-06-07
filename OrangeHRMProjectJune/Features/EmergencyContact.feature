Feature: EmergencyContact
	Employee should be able to add an emergency contact

@mytag
Scenario:Log in as Admin to add employee
	Given I navigate to website
	And  I enter admin username
	And I enter admin password
	And I click on login 
	And I click on PIM
	And I click on add employee
	And I enter employee first name
	And I enter employee lastname
	And I load employee photograph
	And I click on log in details
	And I enter employee username
	And I enter employee password
	And i enter password confirmation
	When I click on save
	Then I should be able to add an employee successfully
	And I click on profile
	And I click on Logout



	@mytag
Scenario:Employee to add emergency contact
Given I navigate to the website
And I enter my username
And I enter my password
And I click on Loging in
And I click on my info
And I click on emergency contact
And I click on add
And I enter emergency contact name
And I enter emergency contact relationship
And I enter emergency contact mobile
When I click on SAVE
Then I should be able to add emergency contact
And i click on logging out profile
And I click on LOGOUT


@mytag
Scenario:Admin to delete newly added employee details
Given I Re navigate to the website
And I Re enter admin username
And I  Re enter admin password
And I Re click on LOGIN
And I Re click on PIM
And I click employee list
And I insert employee details
And I click ID
And I click on Delete
When I click on oK
Then I should be able to successfully delete the added employee details
And I click on profileToLogout
And I click on LOGGINGOUT
