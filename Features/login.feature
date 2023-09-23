Feature: login
first Ever Page to successfully run in this framework ........
@mytag
Scenario: login_to_TMS
	Given I am Logged in to TMS
	When I Select Application RAMX from App switch Over
	When I Select Application EAM from App switch Over
	When I Select Application RAM from App switch Over