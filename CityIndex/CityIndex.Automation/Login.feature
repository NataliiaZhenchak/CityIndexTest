Feature: Login





Scenario: Login invalid credentials
    #When I Launch Repl
    Given I am on Login page
	When I enter "InvalidUsername" in Username field
	And I enter "InvalidPassword" in Password field
    And I tap Login button
    Then I can see Login Failed pop up

