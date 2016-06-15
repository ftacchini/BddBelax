Feature: ApiOperationHistory
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@api
Scenario: Perform 3 operations
	Given I performed three operations
	And set then api count to three
	When I send the request 
	Then the result should be three in the response
