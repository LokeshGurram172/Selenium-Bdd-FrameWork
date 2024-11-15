Feature: Login Functionality

  Scenario: Successful Login with Valid Credentials
    Given I am on the Swag Labs login page
    When I enter valid username 'standard_user' and password 'secret_sauce'
    And I click the login button
    Then I should be redirected to the products page

  Scenario: Unsuccessful Login with Invalid Credentials
    Given I am on the Swag Labs login page
    When I enter invalid username 'invalid_user' and password 'invalid_password'
    And I click the login button
    Then I should see an error message 'Username and password do not match any user in this service.'