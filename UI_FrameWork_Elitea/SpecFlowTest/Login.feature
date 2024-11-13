Feature: Login Functionality

  Scenario: Valid Login
    Given I am on the Swag Labs login page
    When I enter valid credentials
    And I click on the login button
    Then I should be redirected to the products page indicating a successful login