Feature: NewTransaction

Create a New 61 Transaction

@NewTransaction_1
Scenario: Create_a_New_Transaction
	Given I am Logged in to TMS
	When I Select Application EAM from App switch Over
	When I Navigated to EAM Main New Transaction -> New Transaction Menu
	When I Select Transaction Code -> New Transaction Page -> 61 as -> 61
	When I Select Transaction Code -> New Transaction Page -> Type of Application as -> Paper Enrollment
	When New Transaction -> MBI -> AMI
	Then Lets wait for 15 seconds