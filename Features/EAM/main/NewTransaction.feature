Feature: NewTransaction

A short summary of the feature

@NewTransaction_1
Scenario: Create_a_New_Transaction
	Given I am Logged in to TMS
	When I Select Application EAM from App switch Over
	When I Navigated to EAM Main New Transaction -> New Transaction Menu
