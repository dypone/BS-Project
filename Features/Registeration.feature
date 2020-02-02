Feature: Registeration
	In order to use www.gifrete.com
	I need to register with valid details
	
	Scenario: Registeration with valid details
		Given I navigate to the website
			And i click on Register button
		When I enter the First name
			And I enter the Last name
			And I enter an acceptable password
			And I enter the confirm password
			And I click on the Sign up button
		Then I should be a registered member

	Scenario: Registeration Negative Test
		Given I navigate to the website
			And i click on Register button
		When I enter the First name
			And I enter the Last name
			And I enter an acceptable password
			And I enter a wrong password for the confirm password
			And I click on the Sign up button
		Then I should not be a registered member