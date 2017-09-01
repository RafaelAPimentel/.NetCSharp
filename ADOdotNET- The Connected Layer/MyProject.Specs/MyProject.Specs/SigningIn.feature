Feature: SigningIn
		Because these application were written
		very long ago logging into your account is
		a hassle 

@mytag
Scenario: Signing in with a regular account
	Given I am on the login page
	When I enter the right credentials
	And click the login button
	Then I should be taken into my account

@mytag
Scenario: Signing in with duplicate account
	Given I am on the login page
	When I enter the right credentials
	And I click the login button
	And two accounts return 
	Then I should be prompted to pick an account
	Then I should be taken to that account

