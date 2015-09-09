# c--part1-exam-prep1
Problem 1 – 3-6-9
In secret services, they use very secret techniques to send encrypted secret messages. One such secret technique is sending secret texts as secret numbers secretly encoded with secret codes. Unfortunately the secret servant responsible for that particular secret technique is on secret vacation, so it is your duty to translate the secret messages. Since you are lazy scumbag (and that is no secret), you need to write a secret program, calculating the secret algorithm. Well, if you want, calculate it by hand but, you know, BGCoder will not be very happy!
The secret algorithm accepts three numbers, one of which is a secret code, defining a mathematical (don’t hate us, math is a universal language) function for the other two. Afterwards, a magic number 3 appears in the calculations and distorts the answer. That’s all! Such a secret, isn’t it?
You are given three secret numbers A, B, C, where B is actually the secret code symbol.
•	If the code is 3 –find the sum of A and C. Example: A = 5, C = 3, A + C = 8.
•	If the code is 6 –find the product of A and C. Example: A = 5, C = 3, A * C = 15.
•	If the code is 9 –find the remainder after A is divided by C. Example: A = 5, C = 3, A % C = 2.
After you find the result R from the code transformation, if R can be divided by 3 with remainder 0, find R divided by three. Otherwise find the remainder after R is divided by 3. 
For example, if R is 15, it can be divided by 3 with no remainder, so the answer is 5. If R is 8, it cannot be divided by 3, so the answer is 2.
Input
The input data should be read from the console.
On the first input line you will receive the positive integer A.
On the second input line you will receive the positive integer B.
On the third input line you will receive the positive integer C.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
If R can be divided by 3 with no remainder, on the first output line you should print R divided by 3.
Otherwise, on the first output line you should print the remainder after R is divided by 3.
On the second output line, you should print R.
Constraints
•	A, B and C will be positive integers between 1 and 999 999, inclusive.
•	Allowed working time for your program: 0.10 seconds. Allowed memory: 16 MB.


Problem 1 – Next Date
We are given a date (day + month + year). Write a program to print the next day.
Input
The input data consists of 3 lines holding the integer numbers: day, month and year.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console in the format day.month.year (no leading zeroes).
Constraints
•	The number day is in the range [1…31] inclusive.
•	The number month is in the range [1…12] inclusive.
•	The number year is in the range [2000…2013] inclusive.
•	The date is valid according to the classical calendar system.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.


Problem 1 – Sevenland Numbers
In Sevenland we use a numeral system of base 7. It consists of seven digits (instead of the traditional 10) and these 7 digits are: 0, 1, 2, 3, 4, 5, and 6. The numbers in the system of base 7 are just like the decimal numbers, but after 6 the next number is 10. More general, the numbers in the 7-base numeral system are: 0, 1, 2, 3, 4, 5, 6, 10, 11, …, 16, 20, 21, …, 26, 30, …, 65, 66, 100, 101, …, 106, 110, …, 166, 200, …, 666, 1000.
Write a program that takes as input a 7-based integer number K and calculates and prints the next number following it (K+1).
Input
The input data should be read from the console and consists of a single line holding a 7-based integer K.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The output should consist of a single line holding the number K+1 (in 7-based numeral system).
Constraints
•	The number K is in the range [0…666] inclusive.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.


Problem 1 – Triple Rotation of Digits
In Kaspichan we drink a lot. One evening we drunk enough so we invited an interesting game: Someone says a number. The first person after him rotates the digits of this number by moving its last digit at its start (e.g. 12345  51234). The second person after that again rotates the number (e.g. 51234  45123). Finally the third person after him also rotates the number (e.g. 45123  34512). The obtained number then is sent by SMS to a fellow group of alcoholics who continue the game at their drink place.
Write a program that helps the Kaspichan drinkers to calculate the triple digits rotation of given number K. Note that zeroes could also take part in the play and the leading digits are lost after each rotation, e.g. the triple rotation of 180001 is 1180 (180001  118000  011800  11800  01180  1180).
Input
The input data should be read from the console and consists of a single line holding an integer number K.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The output should consist of a single line holding the number obtained after applying a triple digits rotation of the number K.
Constraints
•	The number K is in the range [1…999 999] inclusive.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.


Problem 2 – A-nacci
The A-nacci sequence (read "ei nachi"), often called "ei-nachi, aman ot teya zadachi" (read it however you like) is a sequence similar to the Fibonacci sequence – each element is formed by the sum of the previous two, but with a little different rules for the elements.
The elements in the A-nacci sequence are the capital letters from the English alphabet. Each letter has a code, determined by its position in the alphabet – A has the code 1, B has the code 2, …, Z has the code 26. Here are all the elements that can be in an A-nacci sequence, along with their codes:
A	B	C	D	E	F	G	H	I	J	K	L	M	N	O	P	Q	R	S	T	U	V	W	X	Y	Z
1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18	19	20	21	22	23	24	25	26
The first two elements in the sequence can be any two of the letters above. Every next element has a code equal to the sum of the codes of the previous two elements. 
For example, if A and B are the first two elements, the third element will be C (code(A) = 1, code(B) = 2, 1 + 2 = 3, code(C) = 3). Analogically, the fourth element's code will be determined by the sum of the codes of B and C, so the fourth element will be E.
If the sum of two codes is larger than 26, then that sum is taken by its modulus by 26 (you know this as the % operator in C#). For example, if the sum is 27, then the code will be (27 by modulus 26) = 1, which is the code of A. Another example – if the first two elements are Y and D, then the sum of their codes is 25 + 4 = 29, which is larger than 26, so the code of the next element will be (29 by modulus 26) = 3, which is the code of C.
The A-nacci figure consists of lines of sequential elements from an A-nacci sequence, printed out similarly to the letter A (but without the dash in the middle). The first line contains exactly one element – the first element of an A-nacci sequence. The second line contains the second and third elements of the sequence, concatenated (that is, not separated by anything). Each of the next lines contains exactly two elements – the next elements of the sequence, separated by a certain number of whitespaces. The number of whitespaces separating the elements on the third line, fourth line and so on, are as follows:
•	The third line has exactly one whitespace between the two elements
•	The fourth line has exactly two whitespaces between the two elements
•	…
•	The Nth line has exactly N-2 whitespaces between the two elements
Write a program, which, by given the first two elements (letters) of the A-nacci sequence and the number of lines in the A-nacci form, prints an A-nacci form on the console.
Input
The input data should be read from the console.
The first two lines will contain the values of the first two elements of the A-nacci sequence – each element will be a capital English letter on a separate line.
On the third line of the input there will be the number L – the number of lines in the A-nacci form.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The output should contain exactly L lines. The first line should contain exactly one capital English letter. The second line (if L>1) should contain exactly two capital English letters. The third line should contain two capital English letters, separated by a single whitespace (" ") and so on. There shouldn't be any whitespaces after the second (i.e. last) letter on a line.
Constraints
•	1 ≤ L ≤ 42.
•	All elements of the A-nacci sequence are characters, which are capital letters from the English alphabet.
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 2 – Quadronacci Rectangle
You all know the Fibonacci sequence. Well, the Quadronacci sequence is almost the same, but it uses the last four numbers (instead of the last two) to calculate the next number in the sequence. So, we can define each element in the sequence as:
Q n = Q n-1 + Q n-2 + Q n-3 + Q n-4
where Q n is the current Quadronacci number (n is the index of the current Quadronacci number).
The Quadronacci sequence can begin with any four integer numbers – positive or negative – and continue as described by the formula above.
Now, a Quadronacci rectangle is what you probably expect – a rectangle (matrix) of numbers from the Quadronacci sequence. So we can say that the rectangle's height is actually the number of rows and the rectangle's width is the numbers of columns of numbers.
If use R for the number of rows and C for the number of columns, then the first row in the rectangle contains the first C numbers from the sequence, the second row contains the next C numbers from the sequence and so on.
Your task is to write a program, which prints to the console a Quadronacci rectangle by given the first four numbers of the Quadronacci sequence, the number of rows and the number of columns in the rectangle.
Input
The input data should be read from the console.
The first four lines will contain the values of the first four numbers of the Quadronacci sequence – each number will be on a separate line.
On the fifth line there will be the number R – the number of rows of the Quadronacci rectangle.
On the sixth line there will be the number C – the number of columns of the Quadronacci rectangle.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The output should contain exactly R lines with exactly C numbers per line – representing each line of the Quadronacci rectangle. Numbers should be separated by exactly one whitespace (" "), and there shouldn't be any whitespaces after the last number on a line.
Constraints
•	1 ≤ R ≤ 20.
•	4 ≤ C ≤ 20.
•	Any number in the Quadronacci rectangle can be stored in a 64-bit signed integer.
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 2 – The Horror
Every one of us has little or big real-life horrors from which we are quite scared. Sometimes spiders, sometimes heights, sometimes darkness, no one is fearsome. Programmers’ biggest horror is the “living code”. The “living code” has its own opinion. The “living code” sometimes works, sometimes does not. The “living code” gives unexpected results. It shows no mercy! Everyone will see it one day but only few managed to survive! Brrrr, goose bumps!
Well, you do not have anything to worry, do you? Your code is perfectly fine, you say? Sweet!
This problem is simple. You are given a text with some digits. Your task is to find all digits in every even position (starting from zero) throughout the text and calculate their sum.
Input
The input data should be read from the console.
On the only input line you will receive the text.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
On the only input line you should print the total amount of digits in even positions and their sum separated by space.
Constraints
•	The text’s length will be a valid integer number.
•	Allowed working time for your program: 0.10 seconds. Allowed memory: 16 MB.


Problem 2 – Tribonacci Triangle
You all know the Fibonacci sequence. Well, the Tribonacci sequence is almost the same, but it uses the last three numbers (instead of the last two) to calculate the next number in the sequence. So, we can define each element in the sequence as:
T n = T n-1 + T n-2 + T n-3
where T n is the current Tribonacci number (n is the index of the current Tribonacci number).
The Tribonacci sequence can begin with any three integer numbers – positive or negative – and continue as described by the formula above.
Now, a Tribonacci triangle is a triangle of numbers from the Tribonacci sequence. The first line of the triangle contains only the first number of the Tribonacci sequence. The second line contains the second and third numbers of the Tribonacci sequence, separated by a single whitespace (" "). The third line contains the next three numbers of the Tribonacci sequence (again, separated by whitespaces). The fourth line contains the next four numbers and so on. Basically, every line contains one more number than the previous.
Your task is to write a program, which prints to the console a Tribonacci triangle by given the first three numbers of the Tribonacci sequence, and the number of lines in the triangle.
Input
The input data should be read from the console.
The first three lines will contain the values of the first three numbers of the Tribonacci sequence – each number will be on a separate line.
On the fourth line of the input there will be the number L – the number of lines in the Tribonacci triangle.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The output should contain exactly L lines. The first line should contain exactly one number, the second line – exactly two numbers, the third line (if L>2) – exactly three numbers, …, the L-th line should contain exactly L numbers. Numbers should be separated by exactly one whitespace (" "), and there shouldn't be any whitespaces after the last number on a line.
Constraints
•	2 ≤ L ≤ 20.
•	Any number in the Tribonacci triangle can be stored in a 64-bit signed integer.
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 3 – Excel Columns
Columns are a fundamental part of any spreadsheet program such as Microsoft Excel. Columns run vertically in a worksheet. Each column is identified by a capital Latin letters in the column header starting with column with identifier A and running through to column with identifier Z. After Z you get AA, AB, AC etc. until you get to AZ. Then it is BA, BB, BC, …, ZY, ZZ, AAA, AAB, …, AAZ, ABA, …, ZZY, ZZZ, AAAA, AAAB and so on… The last column is ZZZZZZZZZZ.
 
Recently Todor has learned how to work with Excel. Since then all that he do is giving integer indices to every possible column. Starting from the first column A (with index 1), through Z (with index 26), AA (with index 27), and so on. Of course this is a very, very hard and time-wasting job. You, as programmer, know that this can be solved easily with a computer program.
Help Todor by writing a program that converts excel column identifier to a column index.
Input
The input data should be read from the console.
On the first line of the input there will be an integer N – column identifier length.
On each of the next N lines there will be a single character. All characters together construct a column identifier.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the only output line print the column index.
Constraints
•	N will be between 1 and 10, inclusive.
•	Each column character in the input will be capital Latin letter (‘A’ – ‘Z’)
•	Allowed work time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 3 – Poker
Mitko is a famous poker player. But he is not a good developer. One day he found interesting 5-card poker game which is played by a deck of 52 cards. Nothing strange here, except that the cards have no suit (color). Mitko decided to start playing this game, but he needs a program to show him the best hand that he has. Write а program to help Mitko. The program should read the cards and check each of the following conditions and display one of the messages:
• If the five cards are equal, the program outputs “Impossible”, otherwise:
• if four of them are equal, the program outputs “Four of a Kind”, otherwise:
• if there are three equal and the another two are also equal (example: ‘2’, ‘2’, ‘10’, ‘10’, ‘2’), the program outputs “Full House”, otherwise:
• if the five are consecutive (example: ‘2’, ‘3’, ‘4’, ‘5’, ‘6’), the program outputs “Straight”, otherwise:
• if three of them are equal, the program outputs “Three of a Kind”, otherwise:
• if two pairs contain respectively equal numbers (example ‘A’, ‘K’, ‘A’, ‘K’, ‘J’), the program outputs “Two Pairs”, otherwise:
• if only two cards are equal, the program outputs “One Pair”, otherwise;
• the program outputs “Nothing”.
Cards are given with one of the following strings ‘2’, ‘3’, ‘4’, ‘5’, ‘6’, ‘7’, ‘8’, ‘9’, ‘10’, ‘J’, ‘Q’, ‘K’ or ‘A’ (without the quotes). The combination of ‘10’, ‘J’, ‘Q’, ‘K’ and ‘A’ are considered as a consecutive cards. Note that ‘A’, ‘2’, ‘3’, ‘4’ and ‘5’ are also consecutive cards so your program should output “Straight” in this case.
Input
The input data should be read from the console.
You will be given exactly 5 lines with one card per line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
The standard output has to display an appropriate message with the exact letters case.
Constraints
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 3 – Sheets
Asya loves confetti. One day she decided to create exactly N small pieces of sheets with paper size A10.
A10 is a standard for paper sizes. A9 is another standard that is twice as bigger as A10, so A9 can be cut into 2 pieces of size A10. A8 is twice as bigger as A9 and so on. A0 is twice as bigger as A1. See the picture on the left.
Asya has only one sheet of each type (totally 11 sheets). She wants to have exactly N pieces of size A10 by cutting as few sheets as possible.
Asya should not have any wasted sheets.
Write a program for her.
For example if we want to cut sheets into 9 pieces with the size of A10, we will use the only A7 sheet (cut into 8 pieces of size A10) and the only sheet with size A10. Then we will use 2 sheets. All other 9 sheets will not be used.
Input
On the only line of the input there will be the number N.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
Print the sizes of the sheets that will not be used after Asya’s cutting. Print one size on a single line.
The order of the paper sizes doesn’t matter. See the examples below.
Constraints
•	N will be between 0 and 2046, inclusive.
•	Allowed work time for your program: 0.1 seconds. Allowed memory: 16 MB.


Problem 3 - X – Expression
Bonnie is a very powerful witch. Since the power of the nature is not enough to fight against all the vampires and werewolves, she started to master the power of the Expression.
Expression is a very difficult to master, since its spells depend of the ability to quickly solve complex mathematical expressions. To cast an expression spell, the witch-caster should know the result in advance.
An expression spell consists of set of simple mathematical expressions. Each mathematical expression can contain SUM, SUBTRACT, DIVIDE and/or MULTIPLY operations. The expression is solved like a calculator would do (example follows) and can contain brackets. Everything inside a bracket is solved first. An expression can contain multiple brackets, but cannot contain nested brackets (i.e. expression containing (…(…)…) is invalid, but expression containing (…)…(…) is valid).
Example:
Given the expression: 
 
It is solved as follows:
 
Since Bonnie is quite pretty, but not smart at all, she needs your help to master the art of Expression.
Input
The input data consists of single line on the console
The line represents the expression to solve. The line will always end with the symbol ‘=’. The ‘=’ at the end marks the end of the expression.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed at the console on a single line – the result from the calculated expression.
The result should be rounded to the 2 digit after the decimal point
Constraints
•	The expression will contain no more than 2500 characters
•	The numbers in an expression will always be in the range [1…9]
•	The operators in an expression will always be among + (SUM), – (SUBTRACT), / (DIVIDE) or * (MULTIPLY)
•	The result will always be in the range [-100000.00, 100000.00]
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 4 MB.


Problem 4 – Carpets
Telerik Academy is considering opening a new office in Great Britain. Therefore the whole Trainers team is traveling to the United Kingdom for the important event. Of course all of them want to feel exactly like home in the new office, so they ordered some special carpets from Chiprovtsi. Those carpets consist of many embedded rhombs. Please help them and print some carpets in different sizes for the new Telerik Academy Head Quarters.
Input
The input data should be read from the console.
You have an integer number N (always even number) showing the width and the height of the most outer rhomb. The width and the height will always be equal.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Use the “/” and “\” characters to print the rhomb sides and “.” (dot) for the rest. You should print exactly one space between each rhomb.
Constraints
•	N will always be a positive even number between 6 and 80 inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Example
input	Example
output
6	../\..
./  \.
/ /\ \
\ \/ /
.\  /.
..\/..
Example input	Example output
12	...../\.....
..../  \....
.../ /\ \...
../ /  \ \..
./ / /\ \ \.
/ / /  \ \ \
\ \ \  / / /
.\ \ \/ / /.
..\ \  / /..
...\ \/ /...
....\  /....
.....\/.....



Problem 4 – Binary Digits Count
You are given a sequence of N positive integer numbers and one binary digit B (0 or 1). 
Your task is to write a program that finds the number of binary digits (B) in each of the N numbers in binary numeral system. Example: 20 in the binary numeral system looks like this: 10100. The number of binary digits 0 of the number 20 in the binary numeral system is 3.
Input
The input data is being read from the console. 
On the first input line there will be the digit B.
On the second line you must read the number N.
On each of the following N lines there is one positive integer number written – the consequent number, whose sum of binary digits B we are searching for.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output must be printed on the console.
In the output you must have N lines. Each line must have 1 integer number – the number of digits B in the binary representation of the given consequent number.
Constraints
•	Number N is a positive integer between 1 and 1000, inclusive.
•	Each of the N numbers is a positive integer between 1 and 4 000 000 000, inclusive.
•	The digit B will be only 0 or 1.
•	Allowed work time for your program: 0.25 second.
•	Allowed memory: 16 MB.
Examples
Input Example	Output Example
1
10
1
2
3
4
5
6
7
8
9
10	1
1
2
1
2
2
3
1
2
2

0
4
20
1337
2147483648
4000000000	3
5
31
19

0
6
1
4
16
64
256
1024	0
2
4
6
8
10





Problem 4 - Diamond Trolls
In the peaceful village of Tel’Er’ik the two internet trolls Baa Zil and Juliette fell in love. After years of sharing a small swamp Baa Zil decided he wanted to propose to his girlfriend troll. So he went to the mall and bought flowers and a lovely “diamond” silver ring. But later that day he noticed that the “diamond” was actually a fake piece of plastic. 
Now this is where you come in – your task is to create a diamond for Baa Zil with which he can propose to his kind-of-cute-for-a-troll girlfriend. He will give you the size N for the top of the diamond and you must create it for him.
The width of the diamond must be N*2 + 1. 
The height must be (6 + ((N – 3) / 2) * 3).
The diamond must have a line going vertically through its middle and a horizontal line where the top and the bottom parts connect.
Input
The input data should be read from the console.
You have an integer number N – the width of the top of the diamond.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Use the “*” (star) characters for the lines and “.” (dot) for the rest.
Constraints
•	N will always be a positive number between 3 and 27 inclusive.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Example input	Example output
5	...*****...
..*..*..*..
.*...*...*.
***********
.*...*...*.
..*..*..*..
...*.*.*...
....***....
.....*.....
Examples
Example
input	Example
output
3	..***..
.*.*.*.
*******
.*.*.*.
..***..
...*...
 
Example input	Example output
7	....*******....
...*...*...*...
..*....*....*..
.*.....*.....*.
***************
.*.....*.....*.
..*....*....*..
...*...*...*...
....*..*..*....
.....*.*.*.....
......***......
.......*.......



Problem 5 – Formula Bit 1
The residents of Bitlandia are huge sports fans. The bits have played almost every single sport that they have learned from watching human TV i.e. EuroBitSport and BitTV. Today for the first time they watched Formula 1 and now they certainly want to build a local track and start practicing right away. Of course the bits don’t want to copy the humans. They want to be unique and therefore they’ve added some special rules:
1.	The track must be built on a grid of 8x8 cells, containing only zeros and ones. 
2.	The track itself must contain only zeros. The width of the track will be one cell.
3.	The track must start from the upper right corner and end on the lower left corner.
4.	The cars can move only in 3 directions – South (down), West (left) And North (up). 
5.	The first direction must always be south.
6.	The cars must move in the current direction, while it is possible i.e. the cars can turn only when it reaches the end of the grid or a cell, containing a bit with a value of one.
7.	The cars can switch between directions only in the following order:
South -> West -> North -> West (and then again South -> West and so on)
You will receive information about the grid as a list of 8 bytes (positive integers in the range [0…255]) n0, n1, …, n7. The grid itself is represented by the bits of those bytes.
Your task is to find whether a track can be built on the given grid. If the grid is appropriate, you should print the length of the track and the count of the turns in it (the switches between directions), otherwise you should print “No” and the length of the track until it was interrupted.
Input
The input data should be read from the console.
There will be exactly 8 lines each holding an integer number (n0, n1… n7).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
On the only output row you should print two numbers in the following format “X Y”, where X is the length of the track and Y is the count of the turns. If a track cannot be built, you should print “No X”, where X is the length of the track, until it was interrupted.
Constraints
•	The numbers n0, n1, …, n7 are positive integers in the range [0…255]
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
	7	6	5	4	3	2	1	0	
0	0	0	0	0	0	0	1	0	n0 = 2
1	0	0	1	0	0	1	1	0	n1 = 38
2	0	0	0	1	0	1	0	0	n2 = 20
3	0	0	1	1	0	0	0	0	n3 = 48
4	0	1	1	0	1	1	1	1	n4 = 111
5	0	0	0	0	1	1	1	1	n5 = 15
6	0	0	0	0	0	0	1	1	n6 = 3
7	0	0	1	0	1	0	1	1	n7 = 43
		7	6	5	4	3	2	1	0	
0	0	0	0	0	0	0	1	0	n0 = 2
1	0	0	1	0	0	1	1	0	n1 = 38
2	0	0	0	1	1	1	0	0	n2 = 28
3	0	0	0	1	0	0	0	0	n3 = 16
4	0	1	0	0	0	1	1	1	n4 = 71
5	1	0	0	0	1	1	1	1	n5 = 143
6	0	0	0	0	0	0	1	1	n6 = 3
7	0	0	1	0	1	0	1	1	n7 = 43

Examples
Example
input	Example
output
2
38
20
48
111
15
3
43	21 4

Example
input	Example
output
2
38
28
16
71
143
3
43	No 7



Problem 5 – Warhead

Soldier: - Wake up, marine! Jackson! Wake up! Move your ass and don’t ask any questions! The commander has a very important task for you! Move, move, move!
Private Jackson: - Commander Kenov, Sir! You wanted to see me, Sir!
Commander Kenov: - Yes private! I am finding myself in a rather odd situation. See, the other two privates, private Vlad and private Vasko (waves at them and they wave back), just managed to bring down a nuclear warhead from the sky, that was going to pretty much end our country as we know it, but it turns out, that the warhead is still armed.
I have red your file and it says that you have taken the C# Part 1 course in the Telerik Academy. We figured that you might be able to somehow write a simulator that we can use in disarming the real bomb.
Here is what we know so far:
There is a circuit board full of capacitors. The circuit board is 16x16 cells wide and tall. The capacitors are placed in a different manner. The circuit board is divided into two sections of 8x16 cells. In the left section, there is an attached red wire and on the right section – there is a blue one.
We also took notice that some capacitors are randomly placed, and some are forming figures. The other two privates calculated that if there are exactly 8 capacitors that form a square, having a single empty cell inside of it, they have exactly the right amount of current to sustain the warhead.
111
101
111
We believe and strongly hope, that if we use an electro-magnetically charged screwdriver to touch the center of this shape of capacitors, we can safely remove them. After removing all such shapes from one section, we can cut the wire that connects to it and the warhead will be dead.
- Can you do it, Jackson? Can you save as all?
Instructions from the other two privates:
You need to create a simulator, that has the following functionalities:
1.	The command “hover” will not touch the board, but it will gently place the screwdriver on top of a selected location and it must return “*” if there is a capacitor in this location, and “-” if the cell is empty. This command is totally safe and cannot set the nuclear off.
2.	The command “operate” must place the magnetic screwdriver on the selected location, so you can disturb the electric current of the board at this position and safely remove all the 8 capacitors around it. If there are less than 8 capacitors around the location, you should do nothing,
 There is a risk when performing the “operate” command. If you try to operate on top of a capacitor and touch it directly, the bomb will detonate. Note: There will be no case in which you can remove two shapes with one “operate” command! This means that there will be no case in which capacitors are placed like this:
11111
10101
11111
3.	For a location of a figure, we take the location of the center cell that is empty.
Input
You will receive a random number of commands from the console. Each command will be on a separate line of the console. You must read the commands and print your answer accordingly. The program will finish when the warhead is either disarmed or when it explodes. This will be valid at all times.
After each command you will receive two integers, which will represent the location in which you must perform the command. The first integer will hold the line of the circuit board, and the second integer will hold the cell, in which you must perform the command.
Output
You have different output scenarios, but only one will be valid in a given situation.
If you cut the red wire and there are no square shapes with a single empty cell in them in the left sector of the circuit board, the warhead will be disarmed. In this case you need to print 2 lines. On the first one you must say how many shapes with exactly 8 capacitors and a single empty cell in the middle are there on the other side of the board. On the second one you must type “disarmed”.
If you cut the blue wire, you need to do the same, but in reverse.
If you hit a capacitor, the bomb will detonate instantaneously. In this case you need to print 3 lines. On the first one you must print “missed”, on the second one you should print the number of shapes with 8 capacitors with a single empty cell inside for both sections, and on the third one you must print “BOOM”.
If you cut a wire, but not all shapes of 8 capacitors with a single empty cell are removed from the current section of the board, the warhead will detonate instantaneously. In this case you must print 2 lines. On the first one you must print the number of these shapes in the current section, not the opposite one. Meaning if you cut the red wire, you must look at the left sector, and vise versa. On the second line you must print “BOOM”.
Only one of these scenarios will be valid for the given situation. You cannot have more than one of these in a single case.
Constraints
•	The circuit board of the warhead will always be 16x16.
•	The only shape that you need and can remove is a shape of 8 capacitors with a single empty space, or:
111
101
111
None of the other shapes matters, and only this shape can be removed by the “operate” command.
•	The integers for line and cell will always be valid, meaning 0 – 15 inclusive.
•	Allowed work time for your program: 0.1 seconds.
•	Allowed memory: 16 MB. 
Examples
Example
Input	Example
output
1110000000000000
1010000000000000
1110000001110000
0000000001010000
0000000001110000
0000000000000000
0000100000000000
0000100000000000
0000100000000000
0000000000000000
0000000100000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
hover
0
0
operate
0
3
hover
3
0
hover
3
9
operate
3
10
cut
blue

	*
-
*
1
disarmed

Example
input	Example
output
0110000000000000
1010000000000000
1110000001110000
0000000001010000
0000000001010000
0000000000000000
0000100001110000
0000100001010000
0000100001110000
0000000000000000
0000000100000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
operate
0
7
operate
7
3
operate
7
10
operate
7
4	missed
0
BOOM

Example
input	Example
output
0110000000000000
1010000000000000
1000000001110000
0000000001010000
0000000001110000
0000000000000000
0000100001110000
0000100001010000
0000100001110000
0000000000000000
0000000100000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
0000000000000000
operate
3
10
cut
red

	1
disarmed





