# -Rationals
First school assignment at Jensen Education. Create a calculator for rational numbers.

______________________________
1. The application:
The solution to this problem will be a console application written in C# where the user can input
binary operations expression and the result of that operation is displayed, if successful, as the
output. Otherwise an error message is displayed.

The application MUST support the following operations:

    - Addition
    - Subtraction
    - Multiplication
    - Division
    
The application terminates when the user types the command “quit”. This command is case
insensitive and spaces before or after are discarded. This means that “QuIt”, “ quit ” or “ QuIt ”
will also terminate the program. However “qu it “ will produce an error message.

2. The input:
The user will be able to input rational numbers in three ways:
1- An integer (2, -5, etc)
2- A decimal number (3.14, -2.71784, etc). The decimal separator is the dot, not the comma
3- A fraction of integers (-4 / 3, 4/5, 7/-9, -5/-7, etc).
Any other option would be considered a syntax error. E.g 3.25 / 4 because 2.25 is not integer
The operators allowed are +, -, * and :
Notice that division is defined with colon (:) and not with slash (/). The slash is used to define the
fractions.
Spaces between the operands and operators are irrelevant. The following expressions are the same:
“2+3/2” and “ 2 + 3 / 2 “
If the user doesn’t type any operation, the result is either the same number (in case of integer or
decimal) or a fraction in reduced form otherwise.

3. The output:
When the calculation is successful, the output will be the result in reduced terms. This means, if the
result is a fraction, the fraction will be shown in reduced form; if the result is an integer number, the
output is the integer (not the fraction with 1 in the denominator).
When the calculation fails, one of the following errors must be emitted (depending on the case)
