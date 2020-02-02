Feature: Community
	As a user of gifrete.com
	I want to be able to view the community page

Scenario: Navigate to Community as an unregistered user
	Given I navigate to the website
		And I do not sign in
	When I click on Community
	Then I should be able to see how community works

	Scenario: Navigate to Community as a registered user
	Given I navigate to the website
		And I Sign In
	When I click on Community
	Then I should be able to view all communities