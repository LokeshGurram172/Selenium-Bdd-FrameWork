Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Login with valid credentials
	Given I am on the Swag Labs login page
	When I enter valid username 'standard_user' and password 'secret_sauce'
	And I click the login button
	Then I should be redirected to the products page

Scenario: Login with invalid credentials
	Given I am on the Swag Labs login page
	When I enter invalid username 'invalid_user' and password 'invalid_password'
	And I click the login button
	Then I should see an error message 'Username and password do not match any user in this service.'