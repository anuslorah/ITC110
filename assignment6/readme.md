Create a program that calculates a grade point average divided into the following methods:

A method to take the input from the user
A method that calculates the GPA and returns a double
A display method that calls the input method, and the Calculation and displays the result.
The Main method which starts the program and calls the display method
This program should ask the user how many grades they want to enter. You should create two arrays of that size, one for the grades and one for the number of credits. Loop through the arrays prompting the users to enter the grades and credits for each course. (Do both arrays in the same loop to keep the indexes aligned.) Both arrays should be passed as parameters to a second method that does the calculations. 

GPA is a weighted average, You get the weight by multiplying the grade point times the credits. This is so a 2 credit class doesn't count as much as a 5 credit class. Then you total the credits and the weight and divide the weight by the total credits. Here is an example with three grades:

 Weight = gradePoint * Credits
GPA = TotalWeight / Total Credits

Grade	Credits	Weight
3.4	5	17
2	1	2
4	5	20
 	11	39
 

39 divided by 11=3.5