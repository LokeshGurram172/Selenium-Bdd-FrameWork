Feature: Login Functionality Verification

Scenario: Valid Login
	Given I am on the Swag Labs login page
	When I enter valid credentials and submit
	Then I should be redirected to the products page

Scenario: Invalid Login
	Given I am on the Swag Labs login page
	When I enter invalid credentials and submit
	Then I should remain on the login page and see an error message