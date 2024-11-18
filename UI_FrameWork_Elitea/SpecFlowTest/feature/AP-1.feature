Feature: Login Functionality Verification for Swag Labs

  As a user, I want to be able to log in to Swag Labs using valid credentials to access the products page and using invalid credentials to see an error message.

  Scenario: Successful login with valid credentials
    Given I am on the Swag Labs login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page

  Scenario: Unsuccessful login with invalid credentials
    Given I am on the Swag Labs login page
    When I enter invalid username 'invalid_user' and password 'invalid_password'
    And I click the login button
    Then I should see an error message 'Username and password do not match any user in this service.'