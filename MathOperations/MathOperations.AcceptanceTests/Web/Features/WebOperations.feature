Feature: Web Operations
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the result of an operation

@web
Scenario Outline: Add two numbers
	Given I have entered <number1> into the calculator
	And I have pressed the "add" button
	And I have entered <number2> into the calculator
	When I press the equals button
	Then the result should be <result> on the screen

Examples:
    | number1 | number2 | result |
    | 12      | 5       | 17     |
    | -20     | -5      | -25    |
    | 180     | -3      | 177    |
    | -24     | 32      | 8      |
    | -1123   | 2       | -1121  |
    | 2512    | 51      | 2563   |

@web
Scenario Outline: Substract two numbers
	Given I have entered <number1> into the calculator
	And I have pressed the "substract" button
	And I have entered <number2> into the calculator
	When I press the equals button
	Then the result should be <result> on the screen

Examples:
    | number1 | number2 | result |
    | 12      | 5       | 5      |
    | -20     | -5      | -15    |
    | 180     | -3      | 183    |
    | -24     | 32      | -56    |
    | -1123   | 2       | -1123  |
    | 2512    | 51      | 2461   |

@web
Scenario Outline: Divide two numbers
	Given I have entered <number1> into the calculator
	And I have pressed the "divide" button
	And I have entered <number2> into the calculator
	When I press the equals button
	Then the result should be <result> on the screen

Examples:
    | number1 | number2 | result |
    | 12      | 6       | 2      |
    | -20     | -5      | 5      |
    | 180     | -3      | -60    |
    | -8      | 2       | -4     |

@web
Scenario Outline: Multiply two numbers
	Given I have entered <number1> into the calculator
	And I have pressed the "multiply" button
	And I have entered <number2> into the calculator
	When I press the equals button
	Then the result should be <result> on the screen

Examples:
    | number1 | number2 | result |
    | 12      | 6       | 72     |
    | -20     | -5      | 100    |
    | 180     | -3      | -540   |
    | -8      | 2       | -16    |
