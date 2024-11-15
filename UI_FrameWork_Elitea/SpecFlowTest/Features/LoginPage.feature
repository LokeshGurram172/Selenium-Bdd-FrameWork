Feature: Login Functionality
  As a user, I want to log into the web application so that I can access my dashboard.

  @login
  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the dashboard

  @invalid_login
  Scenario: Unsuccessful Login with Invalid Credentials
    Given I am on the login page
    When I enter invalid credentials
    And I click the login button
    Then I should see an error message indicating invalid credentials