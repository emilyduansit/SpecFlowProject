Feature: testluckykey
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I  goto homepage
	And  input  motor in search field 
	When click lucky key 
	Then get lucky  results