Feature: Login Functionality for Swag Labs Website

  As a user of Swag Labs
  I want to be able to log in with valid credentials
  So that I can access the product page

  Scenario: Successful login with valid credentials
    Given I am on the Swag Labs login page
    When I enter valid username "standard_user" and password "secret_sauce"
    And I click on the login button
    Then I should be redirected to the products page