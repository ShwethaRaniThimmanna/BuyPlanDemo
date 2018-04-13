Feature: WorklistFeature
	In order to test the worklist page functionalites
	As a Team leader
	I want to perform the worklist features available to me.

Background:
	Given I have navigated to the application
	And I am in the login page
	When I enter 'teamleaderie' as username and 'Taxback@483' as password
	And I click the login button

@smoke @worklist @positive
Scenario: Select a worklist item for assignation
	Given I am in the worklist page
	And I select the '1' row from the worklist
	When I click the View Details button
	Then the View Details section should be displayed

@smoke @worklist @positive
	Scenario: Click Manual search in view details page
	Given I am in the worklist page
	And I select the '1' row from the worklist
	When I click the View Details button
	And I click on manual check button
	Then I should be navigated to customer page

