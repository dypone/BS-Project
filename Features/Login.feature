Feature: Login
	As a registered user of www.gifrete.com
	I want to be logged in
	So that i can have access to the member page

Scenario: Login with Valid user details
	Given I am a registered user of www.gifrete.com
	When i navigate to the website
		And i click on sign in
		And I input a valid username
		And i input a valid password
	Then i should be logged in

Scenario: Login with Invalid user details
	Given I am a registered user of www.gifrete.com
	When i navigate to the website
		And i click on sign in
		And I input an invalid username
		And i input a valid password
	Then i should not be logged in