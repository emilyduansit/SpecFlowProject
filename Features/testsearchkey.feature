Feature: testsearchkey
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: testsearchkey
	Given I goto homepage
	And  input motor in search field 
	When click search key 
	Then get search  results