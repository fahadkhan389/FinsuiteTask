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
	And i entered text
	Then todo should be created"

	Scenario: Edit a task
	And i selected already created to do
	And i changed the todo values
	Then Todo should be updated with changes
