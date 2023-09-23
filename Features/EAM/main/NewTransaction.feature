Feature: NewTransaction

Create a New 61 Transaction

@NewTransaction_1
Scenario: Create_a_New_Transaction
	Given I am Logged in to TMS
	When I Select Application EAM from App switch Over
	When I Navigated to EAM Main New Transaction -> New Transaction Menu
