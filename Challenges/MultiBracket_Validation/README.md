# Multi-Bracket Validation
"Your function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:
Round Brackets : ()
Square Brackets : []
Curly Brackets : {}"

## Challenges
The challenge is to check if the bracket pairs are matched up with no strays. So the best we came up with is to have an initial test whether there is an even number of round, square and curly brackets. If so, continue on. If not, return false. If it passes this test, iterate through and have a counter for each bracket character. If the counter for each pairing character is the same across all three pairs, then return true. If not, return false.

## Solution
![image](/assets/MultiBracketValidation.jpg)