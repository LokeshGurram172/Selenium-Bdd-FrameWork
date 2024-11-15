Feature: Login Functionality

Scenario: Valid Login
	Given I am on the Swag Labs login page
	When I enter valid credentials
	Then I should be redirected to the products page

Scenario: Invalid Login
	Given I am on the Swag Labs login page
	When I enter invalid credentials
	Then an error message should be displayed