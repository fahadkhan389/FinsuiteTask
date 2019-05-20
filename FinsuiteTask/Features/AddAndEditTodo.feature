Feature: AddHorseBetting
	As online Punter
	I should be able to add horse bet to Bet slip 
	after adding stake	

	Background: 
	Given i have opened a FireFox browser
	And i am on Todo MVC Website
	And I click on Labs
	And I click on Angular link

Scenario: Add A Task to todo list
	And i selected first competitor for winning and enter stake "10.5"
	Then Bet should be added in BetSlip section of stake "$ 10.5"

	Scenario: Edit a task
	And i selected first competitor for winning and enter stake "10.5"
	Then Bet should be added in BetSlip section of stake "$ 10.5"
