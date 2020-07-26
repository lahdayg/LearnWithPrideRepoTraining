Feature: UploadPicture
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I navigate to "https://www.qa.giftrete.com/Account/edit_profile/"
	When I enter my email address "lahdayg@yahoo.com"
	And I enter my password in the text box 
	And I click on Sign in button
	And I click on Akin Oladeji
	And I click on Account Details
	And I click on Camera Icon
	And I click on Choose File
	#Then the result should be 120 on the screen
