Feature: Login Functionality
Scenario: Valid Login with Detailed Steps
	Given I have opened a web browser
	And I navigate to the Swag Labs login page
	When I enter the username 'standard_user'
	And I enter the password 'secret_sauce'
	And I click on the login button
	Then I should be redirected to the products page
Scenario: Invalid Login with Detailed Steps
	Given I have opened a web browser
	And I navigate to the Swag Labs login page
	When I enter the username 'invalid_user'
	And I enter the password 'wrong_sauce'
	And I click on the login button
	Then I should see an error message