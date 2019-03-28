Feature: Logout from the app

	
Scenario: Logout from the app

	Given I am on Login page
    When I enter "bob@mail.com" in Username field
    And I enter "1234" in Password field
    And I tap Login button
    Then I can see "You are logged in." text
    When I tap Logout button
    Then I am logged out successfully
    
