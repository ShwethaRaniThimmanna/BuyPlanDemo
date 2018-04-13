Feature: Login
	In order to test the authentication functionality
	As a test user
	I want to login to the application using various credentials

@smoke @positive @security
Scenario: Check login with username and password for a user with team leader role
	Given I have navigated to the application
	And I am in the login page
	When I enter 'teamleaderie' as username and 'Taxback@483' as password
	And I click the login button
	Then I should get logged in to the application with the username 'Team Leader IE'
	Then I logout from the application
	
@smoke @positive @security
Scenario: Check login with username and password for a user with sales agent role
  Given I have navigated to the application
  And I am in the login page
  When I enter 'salesagentie' as username and 'Taxback@483' as password
  And I click the login button
  Then I should get logged in to the application with the username 'Sales Agent IE'
  Then I logout from the application