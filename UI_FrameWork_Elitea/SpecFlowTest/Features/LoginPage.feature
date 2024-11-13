Feature: Login Functionality
Scenario: Valid Login
	Given I am on the Swag Labs login page
	When I enter valid credentials and submit
	Then I should be redirected to the products page