Feature: Calculator
       In order to avoid silly mistakes
       As a math idiot
       I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
       Given I have entered 50 into the calculator
       And I have also entered 70 into the calculators
       When I press add
       Then the result should be 120 on the screen

@my2ndtag
Scenario: Subtract two numbers
       Given I have entered 50 into the subcalculator
       And I have entered 10 into the subcalculators
       When I press subtract
       Then the result must be 40 on the screen