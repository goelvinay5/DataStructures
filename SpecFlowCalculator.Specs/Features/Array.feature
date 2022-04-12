Feature: Array
	Array Data Structure

@arrayrotation
Scenario Outline: Rotate array a of size n by d elements
	Given an array <arr> of size <n>
	When the array is rotated by <d> elements
	Then the array <r> should be returned

	Examples:
		| arr                                   | d | n  | r                                     |
		| 1, 2, 3, 4, 5, 6, 7                   | 2 | 7  | 3, 4, 5, 6, 7, 1, 2                   |
		| 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 | 3 | 12 | 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3 |