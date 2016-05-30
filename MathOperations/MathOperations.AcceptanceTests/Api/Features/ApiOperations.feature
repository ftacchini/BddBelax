Feature: Api Operations
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of an operation
	
@api
Scenario Outline: Add two numbers api
	Given I have set <number1> in a request as first number
	And I have set <number2> in a request as second number
	When I send the "add" request
	Then the result should be <result> on the response


Examples:
    | number1 | number2 | result |
    | 12      | 5       | 17     |
    | -20     | -5      | -25    |
    | 180     | -3      | 177    |
    | -24     | 32      | 8      |
    | -1123   | 2       | -1121  |
    | 2512    | 51      | 2563   |
	
@api
Scenario Outline: Substract two numbers api
	Given I have set <number1> in a request as first number
	And I have set <number2> in a request as second number
	When I send the "substract" request
	Then the result should be <result> on the response

Examples:
    | number1 | number2 | result |
    | 12      | 5       | 7      |
    | -20     | -5      | -15    |
    | 180     | -3      | 183    |
    | -24     | 32      | -56    |
    | -1123   | 2       | -1125  |
    | 2512    | 51      | 2461   |
	
@api
Scenario Outline: Divide two numbers api
	Given I have set <number1> in a request as first number
	And I have set <number2> in a request as second number
	When I send the "divide" request
	Then the result should be <result> on the response

Examples:
    | number1 | number2 | result |
    | 12      | 6       | 2      |
    | -20     | -5      | 4      |
    | 180     | -3      | -60    |
    | -8      | 2       | -4     |

@api
Scenario Outline: Multiply two numbers api
	Given I have set <number1> in a request as first number
	And I have set <number2> in a request as second number
	When I send the "multiply" request
	Then the result should be <result> on the response

Examples:
    | number1 | number2 | result |
    | 12      | 6       | 72     |
    | -20     | -5      | 100    |
    | 180     | -3      | -540   |
    | -8      | 2       | -16    |
