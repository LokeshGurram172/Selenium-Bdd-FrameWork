Feature: Login Functionality

Scenario: Valid Login
Given the user is on the SauceDemo login page
When the user enters valid credentials and clicks login
Then the user should be directed to the products page

Scenario: Invalid Login
Given the user is on the SauceDemo login page
When the user enters invalid credentials and clicks login
Then the user should see an error message