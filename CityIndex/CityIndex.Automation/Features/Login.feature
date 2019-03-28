Feature: Login to the app

	
Background: 
    Given I am on Login page
    
Scenario: Login valid credentials
    
    When I enter "bob@mail.com" in Username field
    And I enter "1234" in Password field
    And I tap Login button
    Then I can see "You are logged in." text

Scenario: Login invalid credentials

	When I enter "InvalidUsername" in Username field
    And I enter "InvalidPassword" in Password field
	And I tap Login button
    Then I can see Login Failed pop up
    
Scenario: Dismiss Login Failed pop up

    When I enter "InvalidUsername" in Username field
    And I enter "InvalidPassword" in Password field
    And I tap Login button
    Then I can see Login Failed pop up
    When I tap OK button
    Then Login Failed pop up is dismissed
    
       
     #When I Launch Repl
    
