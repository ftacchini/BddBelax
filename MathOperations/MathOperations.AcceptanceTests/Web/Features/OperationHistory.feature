Feature: OperationHistory
	In order to see previous operation 
	I want to a history operation to be shown

Background: 
	Given I have navigated to the calculators page

@web
Scenario: Show previous operations
	When I performed five operations
	Then the result are shown in history operations
