Feature: Tests

	Background: 
	Given Lorem ipsum home page is open

	Scenario: Check that language is change into russian	
	When I click russian language item
	Then the result should contains the world "рыба"

	Scenario: Check that generetion	button works
	When I click generation button
	Then the result should start with "Lorem ipsum dolor sit amet, consectetur adipiscing elit"

	Scenario: Check generation by start checkbox works
	When I click unchek start checkbox	
	And I run generate paragraphs
	Then the result should't start with "Lorem ipsum"

	Scenario: Check randonly generated paragraphs
	When I run generate paragraphs 
	Then everage numbers should by between 2 and 3

	Scenario Outline: Generation of x-bytes equals to actual numbers of byte on the page
	When I generate <amount> bytes of text default starting text
	Then <expectedAmout> bytes has been found on the page
	Examples: 
	| amount | expectedAmout |
	| -5    | 5             |
	| 0     | 5             |	
	| 20    | 20            |


	Scenario Outline: Generation of x-words equals to actual numbers of words on the page
	When I generate <amount> words of text default starting text
	Then <expectedAmout> words has been found on the page
	Examples: 
	| amount | expectedAmout |
	| -1    | 5             |
	| 0     | 5             |
	| 5     | 5             |
	| 10    | 10            |
	| 20    | 20            |
