Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Valid Login
	Given I am on the Swag Labs login page
	When I enter valid credentials
	Then I should be redirected to the products page

Scenario: Invalid Login
	Given I am on the Swag Labs login page
	When I enter invalid credentials
	Then I should see an error message 'Username and password do not match any user in this service'