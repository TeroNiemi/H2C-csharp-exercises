

# Part 1

## Printing and reading

The basic structure of the program is given in the exercises:

```cs
using System;

namespace exercise_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            
        }
    }
}
```

The line **// Add your code here:** is a comment. The composer does not compose it, so you do not have to worry about it. You can remove it, if you want.

#### Exercise_01:
* create a program that writes the text **Hello World!** into the console. The program contains the basic structure pictured above.

#### Exercise_02:
* Let's write some more. Bonnie Tyler once sang about feelings, that also apply to coding:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
create a program using 3 Console.WriteLines, that prints these lyrics.

#### Exercise_03:
* Let's refine our program. Print the same message:  
**Once upon a time**  
**I was falling in love**  
**Now I'm only falling apart**  
This time, use only one Console.WriteLine

#### Exercise_04:
* The exercise has following structure:

```cs
using System;

namespace exercise_04
{
    class Program
    {
        public static void Main(string[] args)
        {
            string message = "Passport and floss!";
            Console.WriteLine(message);
        }
    }
}
```

Change it, so that it prints **Passport and a toothbrush!**
Do not change the line containing Console.WriteLine, only change the content of the variable!



#### Exercise_05:
* You will find following structure in the exercise:
  
```cs
using System;

namespace exercise_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Ada Lovelace";
            // Write your code here:
            
        }
    }
}
```

Modify the code, so that it prints **Hello Ada LoveLace!**
Do not modify the variable content!

#### Exercise_06
* create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line. Example output with **Hello** as input (input marked with **>** for clarification):

```console
Give input!
> Hello
Hello
```

#### Exercise_07
* create a program, that asks user for a string. After the user has given the string (written text and pressed enter), the program will print the given line 3 times. Example output with **Hello** as input:

```console
Give input!
> Hello
Hello
Hello
Hello
```

#### Exercise_08
* create a program, that asks user for their name and greets them. Example output with **Ada** as input:

```console
What is your name?
> Ada
Hello Ada!
```
Notice the exclamation mark.

#### Exercise_09
* create a program, that simulates a small conversation. The program will tell three lines, and expects two user inputs. Example output:

```console
Hello, how are you?
> Fine, thanks.
That's interesting, tell me more
> I learn coding
Thank you for sharing!
```

#### Exercise_10
* create a program, that asks the user for a name and a profession. Then make the program to write a little story with this information. Here is an example story with inputs **Ada** and **Data Scientist**.

NOTICE! Every **Ada** and **Data Scientist** in the story are the inputs by the user. Remember to save the **Console.ReadLines** into variables and use them as parts of the story!

```console
I will tell a story, but I need some information.
Give a name for main character:
> Ada
Give the character a profession:
> Data Scientist
Here is the story:
Once upon a time there was a Data Scientist called Ada
On her way to work, Ada often pondered what being Data Scientist meant to them.
When you work as a Data Scientist you meet interesting people.
Ada enjoys their work as Data Scientist, The end.
```

## Variables

#### Exercise_11
* The exercise comes with a template that prints the following:

```console
Days to summer:
100
Hours to lunch:
1
Coding is fun:
Are you sure?
```

Change the values of the variables, so the program will print

```console
Days to summer:
200
Hours to lunch:
3.5
Coding is fun:
It sure is!
```

#### Exercise_12
* create a program, that asks the user for an integer. After user input, the program will print the integer. Example prints:

```console
Give a number!
> 11
You gave 11
```

```console
Give a number!
> 42
You gave 42
```

#### Exercise_13
* create a program, that asks the user for a double. After user input, the program will print the double. Example prints:

```console
Give a number!
> 11.11
You gave 11.11
```

```console
Give a number!
> 41.999999
You gave 41.999999
```

#### Exercise_14
* create a program, that asks the user for a boolean. After user input, the program will print the boolean. Example prints:

```console
Give me the truth!
> tRuE
True
```

```console
Give me the truth!
> false
False
```

#### Exercise_15
* Let's combine everything you know so far. create program that asks the user for a string, an integer, a double and a boolean, and prints them like follows:

```console
Give a string:
> This is a masterpiece!
Give an integer:
> 42
Give a double:
> 3.1415
Give a boolean:
> True
Your string: This is a masterpiece!
Your integer: 42
Your double: 3.1415
Your boolean: True
```

## Calculations

#### Exercise_16

create a program, which asks user for amount of days, and prints the total amount of seconds for that amount of days, gives the answer and quits.

Example print:
```console
How many days?
> 2
172800
```
```console
How many days?
> 7
604800
```

#### Exercise_17

* create a program, which asks the user for two integers, and calculates their sum.  

Remember, that the input is a string, so you have to convert it to integer!

Example output:

```console
Give the first number!
> 8
Give the second number!
> 3
The sum is 11
```

```console
Give the first number!
> 3
Give the second number!
> -1
The sum is 2
```

#### Exercise_18

* Expand a little on the previous exercise. Now create a program, which asks for three integers, and calculates their sum.

```console
Give the first number!
> 3
Give the second number!
> -1
Give the third number!
> 2
The sum is 4
```

#### Exercise_19

* create a program, which asks the user for two integers and counts their sum. This time, also print the equation to the user, too.

```console
Give the first number!
> 3
Give the second number!
> 1
3 + 1 = 4
```

```console
Give the first number!
> 5
Give the second number!
> -1
3 + -1 = 2
```

#### Exercise_20

* create a program, which asks the user for two integers and multiplies them with each other.

```console
Give the first number!
> 3
Give the second number!
> 2
3 * 2 = 6
```

```console
Give the first number!
> 50
Give the second number!
> -2
50  * -2 = -100
```

#### Exercise_21

* create a program, which asks the user for two **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
The average is 2.5
```

#### Exercise_22

* create a program, which asks the user for three **integers** and calculates their **average** as a **double**.

```console
Give the first number!
> 3
Give the second number!
> 2
Give the third number!
> 1
The average is 2.0
```

#### Exercise_23

* Let's create a program, that does all the basic calculations from user input! Ask for two integers and do the calculations with them.

```console
Give the first number!
> 3
Give the second number!
> 2
3 + 2 = 5
3 - 2 = 1
3 * 2 = 6
3 / 2 = 1.5
```

## Conditionals and comparison

#### Exercise_24

* create a program, which asks the user for an integer.

If the given integer is larger than 120, output "Speeding!".

```console
Your speed:
> 5
````

```console
Your speed:
125
Speeding!
```

#### Exercise_25

* create a program which asks for an integer. If the integer is 1984, output "Orwell".

```console
Give a number:
>1985
```

```console
Give a number:
> 1984
Orwell
```

#### Exercise_26

* create a program which asks for an integer. If the integer is less than 1900, output "You're old".

```console
Give your age:
>1985
```

```console
Give your age:
> 1899
You're old
```

#### Exercise_27

* create a program which tells if the given number is positive (grEater than zero), or not.

```console
Give a number:
> 5
It is positive
```

```console
Give a number:
-2
It is not positive
```

### Exercise_28

* create a program which tell if the given person is legally adult (in Finland, over 18), or not.

```console
How old are you?
> 5
You're under age!
```

```console
How old are you?
> 18
You're an adult!
```

### Exercise_29

* create a program which asks for two integers. The program should tell which of them is grEater. If they are equal, that should be noted, too.

```console
Give the first number!
> 3
Give the second number!
> 2
The larger number is 3!
```

```console
Give the first number!
> 3
Give the second number!
> 4
The larger number is 4!
```

```console
Give the first number!
> 3
Give the second number!
> 3
They are equal!
```

#### Exercise_30

Here is the grading for this course:

| Percent | Grade|
|---|---|
| < 0 | Impossible |
| 0 - 49  | Fail |
| 50 - 59 | 1 |
| 60 - 69 | 2 |
| 70 - 79 | 3 |
| 80 - 89 | 4 |
| 90 - 100 | 5 |
| > 100 | Outstanding! |

* create a program, which asks the user for their percent, and gives them their score. For example:

```console
Give your percent [0 - 100]:
> -2
Impossible
```

```console
Give your percent [0 - 100]:
> 49
Fail
```

```console
Give your percent [0 - 100]:
> 75
Grade: 3
```

```console
Give your percent [0 - 100]:
> 99
Grade: 5
```

```console
Give your percent [0 - 100]:
> 9001
Outstanding!
```

#### Exercise_31

* create a program which asks for an integer and tells the user if it is even or not.

```console
Give a number:
> 2
It is even.
```

````console
Give a number
> 5
It is odd.
````

Hint: You might want to use the **%** operator to get the remainder after a division with 2.

#### Exercise_32

* create a program which asks for a string. If the string is "Mellon", print "Welcome, friend", otherwise print "They've got a cave troll!"

```console
Speak, friend, and enter!
> Let meeeee in!
They've got a cave troll!
```

```console
Speak, friend, and enter!
> Mellon
Welcome, friend
```

#### Exercise_33

* create a program which asks for two string. If the strings are equal, print "Echo", otherwise print "Nope".

```console
Give the first string:
> Potato
Give the second string:
> Potato
Echo!
```

```console
Give the first string:
> Potato
Give the second string:
> Tomato
Nope!
```

## Repetition

#### Exercise_34

* create a program which asks the user if they want to continue. If the user answers "no", then quit the program. Otherwise, ask again.

Hint: Use a while-loop!

```console
Do you want to continue?
> Yes
Do you want to continue?
> Hot potato
Do you want to continue?
> no
```

#### Exercise_35

* create a program, which asks the user for integers, until the user give the number "42".

```console
Give a number:
> 41
Give a number:
> 68
Give a number:
-42
Give a number:
42
```

#### Exercise_36

* create a program, which asks the user for integers. If the number is zero, exit the program. If the number is negative, give the user message "That is negative". If the number is positive, output the number, raised to its second power (the number multiplied with itself).

```console
Give a number:
> 5
25
Give a number:
> -2
That is negative
Give a number:
> 4
16
Give a number:
0
```

#### Exercise_37

* create a program which asks the user for integers. If the integer is 0, quit. In the end, output "Total amount of numbers:" and the amount. Do not count the 0 into the amount.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total amount of numbers: 3
```

#### Exercise_38

* create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total amount of **negative numbers** with "Total amount of negative numbers:" and the amount. Do not count the 0 into the amount.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total amount of negative numbers: 1
```

#### Exercise_39

* create a program which asks the user for integers. If the integer is 0, quit. In the end, output the total **sum** of the numbers with "Total sum of numbers:" and the sum. Do not count the 0 into the sum, even though it does not change the result.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total sum of numbers: 25
```

#### Exercise_40

* create a program which asks the user for integers. Exit with 0. In the end, output both the amount and the sum. Do not count 0 to either.

```console
Give a number:
> 5
Give a number:
> -2
Give a number:
> 22
Give a number:
> 0
Total sum of numbers: 25
Total amount of numbers: 3
```

Hint: You will need two variables to store the data, one for the sum, one for the amount.


# Part 2

## Subproblems

#### Exercise_41

* Write a program that reads an integer from the user input, and then prints the second power of the given integer, i.e. the integer multiplied by itself.

```console
> 4
16
```

```console
> 5
25
```

```console
> -3
9
```

#### Exercise_42

* Write a program that reads **two integers** from the user, and prints the **square root of the sum of these integers**. The program **does not need to work with negative values**.

You can get the square root of an integer with the command Math.Sqrt like this:

```cs
int number = 42;
double squareRoot = Math.Sqrt(number);
Console.WriteLine(squareRoot);
```

```console
> 1 
> 0 
1
```

```console
> 5 
> 4 
3
```

```console
> 1 
> 35 
6
```

#### Exercise_43

* Write a program, that reads an integer from the user. If the number is less than 0, it prints the number multiplied by -1. Otherwise the program prints the number itself. A few examples of the expected function below:

```console
> -3
3
```

```console
> 1
1
```

```console
> 0
0
```

#### Exercise_44

* Write a program that reads two integers from the user input. If the first number is grEater than the second, the program prints "(first) is grEater than (second)." If the first number is less than the second, the program prints "(first) is less than (second)." Otherwise the program prints "(first) is equal to (second)." The (first) and (second) should always be replaced with the actual numbers given by the user.

A few examples of the expected behaviour:

```console
> 8 
> 4 
8 is grEater than 4.
```

```console
> -3 
> 5 
-3 is less than 5.
```

```console
> 1 
> 1 
1 is equal to 1.
```

## More loops

#### Exercise_45

* Write a program that reads an integer from the user. Then the program prints numbers from 0 to the number given by the user. You can assume that the user always gives a positive number. Below is some examples of the wanted functionality. **You can use either a while-loop with a condition, or a for-loop.**

```console
> 4
0
1
2
3
4
```

```console
> 1
0
1
```

#### Exercise_46

* Write a program, which reads an integer from the user. Then the program prints numbers from that number to 100. You can assume that the user always gives a number less than 100. Below are some examples of the wanted functionality.

```console
> 99
99
100
```

```console
> -4
-4
-3
-2
-1
0
1
... (lots of numbers in between) ...
98
99
100
```

### NOTICE!
From now on, the exercises might be in multiple sections **in the instructions**, to make it easier to comprehend. In the end, you should still have **only one program per exercise** to return.  

Each section is counted separately, when calculating the total amount of exercises done. For example, the next exercise with 2 sections, counts as 2 exercises in the total sum you have done. 

Hint: The last section always shows what the program should do in total. When all the tests pass, you have done all the sections.

#### Exercise_47

##### Section 1
* Write a program, which prints integers from 1 to a number given by the user.

```console
Where to? 
>3 
1 
2 
3
```

```console
Where to? 
>5 
1 
2 
3 
4 
5
```

Hint: the number read from the user is now the upper limit of the condition. Remember that **a <= b** means a is smaller or equal to b.

##### Section 2

* Ask the user for the starting point as well.

```console
Where to? 
>8 
Where from? 
>5
5 
6 
7 
8
```

If the upper limit is larger than the starting point, nothing is printed:

```
Where to? 
> 12 
Where from? 
> 16
```

Hint: Remember that the lower and the upper limits can be negative!

#### Exercise_48

##### Section 1

* Implement a program that asks the user for numbers(the program first prints "Write numbers: ") until the user gives the number -1, When the user writes -1, the program prints "Thx! Bye!" and ends.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye!
```

##### Section 2

* Extend the program so, that it prints the sum of the numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
```

##### Section 3 
* Extend the program so, that it also prints the number of numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
```

##### Section 4

* Extend the program so, that it prints the mean of the numbers (not including the -1) the user has written.

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
Average: 3.666666666666
```

##### Section 5

* Extend the program so that it prints the number of even and odd numbers (excluding the -1).

```console
Give numbers: 
> 5 
> 2 
> 4 
> -1 
Thx! Bye! 
Sum: 11
Numbers: 3
Average: 3.666666666666
Even: 2
Odd: 1
```

### NOTICE!
When you are writing a program, whether it's an exercise or a personal project, figure out the types of parts the program needs to function and proceed by implementing them one part at a time. Make sure to test the program right after implementing each part.

Never try solving the whole problem at once, because that makes running and testing the program in the middle of the problem-solving process difficult. Start with something easy that you know you can do. When one part works, you can move on to the next.

Some of the exercises are already split into parts. However, it's often the case in programming that these parts need to be split into even smaller parts. You should almost always run the program after every new line of code. This ensures that the solution is moving in the right direction.

## Methods

In these exercises we practice making and calling our own methods.  
**If the exercise template says "// Call your method here:", call it once. Usually this is in the Main class**.

#### Exercise_49

* create a method called **PrintPhrase** which prints the phrase "In a hole in the ground there lived a method" and a newline (use WriteLine and not just Write).

```cs
public static void Main(string[] args)
{
  // Call your method here:
  PrintPhrase();

}

// Write your method here:
public static void PrintPhrase() 
{

}
```

```console
In a hole in the ground there lived a method
```

#### Exercise_50

* Expand the previous program so that the main program asks the user for the number of times the phrase will be printed (i.e. how many times the method will be called).

```cs
public static void Main(string[] args)
{
  // ask the user for the number of times that the phrase will be printed
  // use the while command to call the method a suitable number of times

}

// Write your method here:
public static void PrintPhrase() 
{

}
```

```console
How many times?
> 3
In a hole in the ground there lived a method
In a hole in the ground there lived a method
In a hole in the ground there lived a method
```

## Notice!
From here on out, when introducing methods, we might not explicitly mention they must be located in the correct place. Methods cannot be defined e.g. inside other methods.

#### Exercise_51

* create the following method in the exercise template: **public static void PrintUntilNumber(int number)**. It should print the numbers from one to the number passed as a parameter. Two examples of the method's usage are given below.

```cs
public static void Main(string[] args) 
{
  PrintUntilNumber(5);
}
```

```console
1
2
3
4
5
```

```cs
public static void Main(string[] args) 
{
  PrintUntilNumber(3);
}
```

```console
1
2
3
```

#### Exercise_52

* create the following method in the exercise template: **public static void PrintFromNumberToOne(int number)**. It should print the numbers from the number passed as a parameter down to one. Two examples of the method's usage are given below.

```cs
public static void Main(string[] args) 
{
  PrintFromNumberToOne(5);
}
```

```console
5
4
3
2
1
```

```cs
public static void Main(string[] args) 
{
  PrintFromNumberToOne(2);
}
```

```console
2
1
```

#### Exercise_53

* Write a method **public static void Division(int numerator, int denominator)** that prints the result of the division of the numerator by the denominator. Keep in mind that the result of the division of the integers is an integer -- in this case we want the result to be a floating point number (double).

#### Exercise_54

* Write a method **public static void DivisibleByThreeInRange(int beginning, int end)** that prints all the numbers divisible by three in the given range. The numbers are to be printed in order from the smallest to the grEatest.

```cs
public static void Main(string[] args) 
{
  DivisibleByThreeInRange(3, 6);
}
```

```console
3
6
```

```cs
public static void Main(string[] args) 
{
  DivisibleByThreeInRange(2, 10);
}
```

```console
3
6
9
```

#### Exercise_55

* Write a method **public static int NumberUno()** that returns the value 1.

#### Exercise_56

* Write a method **public static string Word()**. The method must return a string of your choice.

#### Exercise_57

* Expand the method **Sum**  in the exercise template so that it calculates and returns the sum of the numbers that are given as the parameters.
create the method using the following structure:

```cs
public static int Sum(int number1, int number2, int number3, int number4) 
{
  // write your code here
  // remember to include return (at the end)!
}

public static void Main(string[] args) 
{
    int answer = Sum(4, 3, 6, 1);
    Console.WriteLine("Sum: " + answer);
}
```
Output of the example:

```console
Sum: 14
```

#### Exercise_58

* Define a two-parameter method **Smallest** that returns the smaller of the two numbers passed to it as parameters.

```cs
public static int Smallest(int number1, int number2) 
{
  // write your code here
  // do not print anything inside the method

  // there must be a return command at the end
}

public static void Main(string[] args) 
{
  int answer =  Smallest(2, 7);
  Console.WriteLine("Smallest: " + answer);
}
```

The output of the program:

```console
Smallest: 2
```

#### Exercise_59

* Define a three-parameter method **GrEatest** that returns the grEatest of the three numbers passed to it as parameters.

```cs
public static int GrEatest(int number1, int number2, int number3) 
{
  // write your code here
  // do not print anything inside the method

  // there must be a return command at the end
}

public static void Main(string[] args) 
{
  int answer =  GrEatest(2, 7, 3);
  Console.WriteLine("GrEatest: " + answer);
}
```

The output of the program:

```console
GrEatest: 7
```

**NOTICE!** There has been an update to the template for exercises 60 and 61.  
The template should include empty methods for the exercise.  
IF YOU DO NOT GET THEM BY **GIT PULL**, JUST COPY THEM BY HAND!

#### Exercise_60

##### Section 1

* Define a method called **PrintStars** that prints the given number of stars and a line break.

Write the method in the following template:

```cs
public static void PrintStars(int number)
{
  // you can print one star with the command
  // Console.Write("*");
  // call the print command n times
  // in the end print a line break with the comand
  // Console.WriteLine("");
}

public static void Main(string[] args) 
{
  PrintStars(5);
  PrintStars(3);
  PrintStars(9);
}
```

The output of the program:
```console
***** 
*** 
*********
```

##### Section 2

* Define a method called **PrintSquare(int size)** that prints a suitable square with the help of the printStars method. So the method call **PrintSquare(4)** results in the following output:

```console
****
****
****
****
```

##### Section 3

* Write a method called PrintRectangle(int width, int height) that prints the correct rectangle by using the PrintStars method. So the method call PrintRectangle(17, 3) should produce the following output:

```console
***************** 
***************** 
*****************
```

##### Section 4

* create a method called PrintTriangle(int size) that prints a triangle by using the PrintStars method. So the call PrintTriangle(4) should print the following:

```console
*
**
***
****
```


#### Exercise_61

##### Section 1
* Define a method called PrintSpaces(int number) that produces the number of spaces specified by number. The method **does not print the line break**.

You will also have to either copy the **PrintStars** method from your previous answer or reimplement it in this exercise template.

##### Section 2

* create a method called **PrintRightTriangle(int size)** that uses PrintSpaces and PrintStars to print the correct triangle. So the method call **PrintRightTriangle(4)** should print the following:

```console
   *
  **
 ***
****
```

##### Section 3

* Define a method called **ChristmasTree(int height)** that prints the correct Christmas tree. The Christmas tree consists of a triangle with the specified height and the base. The base is two stars high and three stars wide, and is placed at the center of the triangle's bottom. The tree is to be constructed by using the methods PrintSpaces and PrintStars.

For example, the call **ChristmasTree(4)** should print the following:

```console
   * 
  *** 
 *****
******* 
  *** 
  ***
```
The call **christmasTree(10)** should print:

```console
         * 
        *** 
       ***** 
      ******* 
     ********* 
    *********** 
   ************* 
  *************** 
 ***************** 
******************* 
        *** 
        ***
```
NOTICE! Heights shorter that 3 don't have work correctly!


# Part 3

## Lists

#### Exercise_62

The exercise contains a base that asks the user for strings and adds them to a list. The program stops reading when the user enters an empty string. The program then prints the first element of the list.

Your assignment is to modify the program so that instead of the first value, the third value on the list is printed. Remember that programmers start counting from zero! The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Alex
```

```console
> Emma 
> Alex 
> Mary
>

Mary
```

#### Exercise_63

In the exercise template there is a program that reads integers from the user and adds them to a list. This ends when the user enters 0. The program then prints the first value on the list.

Modify the program so that instead of the first value, the program prints the sum of the second and third numbers. The program is allowed to malfunction if there are fewer than three entries on the list, so you don't need to prepare for such an event at all.

```console
> 1 
> 3 
> 5 
> 7 
> 0 
8
```

```console
> 2 
> 3 
> 4 
> 0 
7
```

#### Exercise_64

There is a program that uses a list in the exercise template. Modify it so that its execution always produces the error **ArgumentOutRangeException**. The user should not have to give any inputs to the program (e.g. write something on the keyboard)

#### Exercise_65

In the exercise template is a program that reads input from the user. Modify its working so that when the program quits reading (with an empty line), the program prints the number of values on the list.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
In total: 4
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
In total: 11
```

Notice! Be sure to use the **Count property** of the list.

The next exercises are meant for learning to use lists and indices. Even if you could complete the execises without a list, concentrate on training to use lists. The functionality in the exercises is to be implemented after reading the inputs.

#### Exercise_66

In the exercise template there is a program that reads inputs from the user and adds them to a list. Reading is stopped once the user enters an empty string.

Your task is to modify the method to print the last read value after it stops reading. Print the value that was read last from the list. Use the Count to help you. You do not have to take into consideration empty lists, you can assume that the user always gives at least one input.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Mary
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
Oscar
```

#### Exercise_67

In the exercise template there is a program that reads inputs from the user and adds them to a list. Reading is stopped once the user enters an empty string.

Modify the program to print both the first and the last values after the reading ends. You may suppose that at least two values are read into the list.

```console
> Tom 
> Emma 
> Alex 
> Mary
>
Tom
Mary
```

```console
> Juno 
> Elizabeth 
> Mason 
> Irene
> Olivia
> Liam
> Ida
> Christopher
> Mark
> Sylvester
> Oscar
>
Juno
Oscar
```

```console
> Tom 
> Mary
>
Tom
Mary
```

#### Exercise_68

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the functionality of the program so that after reading the numbers, it prints all the numbers received from the user. The number used to indicate stopping should not be printed.

```console
> 72
> 2
> 8
> 11
> -1 
72
2
8
11
```

#### Exercise_69

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the program to ask for a start and end indices once it has finished asking for numbers. After this the program shall prints all the numbers in the list that fall in the specified range (between the indices given by the user, inclusive). You may assume that the user gives indices that match some numbers in the list.

```console
> 72
> 2
> 8
> 11
> -1 
From where?
> 1
Where to?
> 9 
2 
8
```

```console
> 72
> 2
> 8
> 11
> -1 
From where?
> 0 
Where to?
> 20  
2
8
11 
```

#### Exercise_70

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Continue developing the program so that it ends the grEatest number in the list and prints its value after reading all the numbers. The programming should work in the following manner.

```console
> 72
> 2
> 8
> 93
> 11
> -1
The grEatest number: 93
```
You can assume that user always gives atleast one viable number.

You can use the source code below as an inspitation. It is used to find the smallest number.

```cs
// assume we have a list that contains integers

int smallest = list[0];

for(int i = 0; i < list.Count; i++) {
    int number = list[i];
    if (smallest > number) {
        smallest = number;
    }
}

Console.WriteLine("The smallest number: " + smallest);
```

#### Exercise_71

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Expand the program that then asks the user for a number, and reports that number's index in the list. If the number is not found, the program should not print anything.

```console
> 72 
> 2 
> 8 
> 8 
> 11 
> -1
Search for? 
> 2 
2 is at index 1
```

```console
> 72 
> 2 
> 8 
> 8 
> 11 
> -1
Search for? 
> 8 
8 is at index 2
8 is at index 3
```

#### Exercise_72

Write a program that reads numbers from the user. When number 9999 is entered, the reading process stops. After this the program will print the smallest number in the list, and also the indices where that number is found. Notice: the smallest number can appear multiple times in the list.

```console
> 72
> 2
> 8
> 8
> 11
> 9999
Smallest number: 2 
Found at index: 1
```

```console
> 72
> 44
> 8
> 8
> 11
> 9999
Smallest number: 8 
Found at index: 2 
Found at index: 3
```

HINT: combine the programs you wrote for the exercises "GrEatest number in the list" and "Index of the requested number". First find the smalleest number, and then find the index of that number.

#### Exercise_73

The exercise template contains a base that reads numbers from the user and adds them to a list. Reading is stopped once the user enters the number -1.

Modify the program so that after reading the numbers it calculates and prints the sum of the numbers in the list.

```console
> 72
> 2
> 8
> 11
> -1
Sum: 93
```

#### Exercise_74

In the exercise template there is a program that reads inputs from the user until an empty string is entered. Add the following functionality to it: after reading the inputs one more string is requested from the user. The program then tell whether that string was found in the list or not.

```
> Tom
> Emma
> Alex
> Mary
Search for?
> Mary
Mary was found!
```

```
> Tom
> Emma
> Alex
> Mary
Search for?
> Logan
Logan was not found!
```

#### Exercise_75

create the method **public static void PrintNumbersInRange(List\<int\> numbers, int lowerLimit, int upperLimit)** in the exercise template. The method prints the numbers in the given list whose values are in the range [lowerLimit, upperLimit]. A few examples of using the method are supplied below.

```cs
List<int> numbers = new List<int>();
numbers.Add(3);
numbers.Add(2);
numbers.Add(6);
numbers.Add(-1);
numbers.Add(5);
numnbers.Add(1);

Console.WriteLine("The numbers in the range [0, 5]");
PrintNumbersInRange(numbers, 0, 5);

Console.WriteLine("The numbers in the range [3, 10]");
PrintNumbersInRange(numbers, 3, 10);
```

```console
The numbers in the range [0, 5] 
3 
2 
5 
1 
The numbers in the range [3, 10] 
3 
6 
5
```

#### Exercise_76


create the method **public static int Sum(List\<int\> numbers)** in the exercise template. The method is to **return** the sum of the numbers in the parameter list.

```cs
List<int> numbers = new List<int>();
numbers.Add(3);
numbers.Add(2);
numbers.Add(6);
numbers.Add(-1);
Console.WriteLine(Sum(numbers));

numbers.Add(5);
numbers.Add(1);
Console.WriteLine(Sum(numbers));
```

```console
10
16
```

### Exercise_77

create the method **public static void RemoveLast(List\<string\> strings)** in the exercise template. The method should remove the last value in the list it receives as a parameter. If the list is empty, the method does nothing.

```cs
List<string> strings = new List<string>();

strings.Add("First");
strings.Add("Second");
strings.Add("Third");

// Remember, this is how you print all the items in a list
strings.ForEach(Console.WriteLine);

RemoveLast(strings);
RemoveLast(strings);

strings.ForEach(Console.WriteLine);
```

```console
First
Second
Third
First
```


## Arrays

#### Exercise_78

The exercise template already contains a program, that creates an array and prints the values of the array twice. Modify the program to do following: After the first printing, the program should ask for two indices from the user. The values in these two indices should be swapped, and in the end the values of the array should be printed once again.

```console
1 
3 
5 
7 
9

Give two indices to swap: 
> 2 
> 4

1 
3 
9 
7 
5
```

```console
1 
3 
5 
7 
9

Give two indices to swap: 
> 0 
> 1

3 
1 
5 
7 
9
```

You can assume the array to contain the given indices.   

Tip! You'll need an additional variable to store one of the values for little while.

#### Exercise_79

The exercise template has already an array containing numbers. Complete the program to ask the user for a number to search in the array. If the array contains the given number, the program tells the index containing the number. If the array doesn't contain the given number, the program will tell the number wasn't found.

```console
Search for? 
> 3 
3 is at index 4.
```

```console
Search for? 
> 7 
7 is at index 7.
```

```console
Search for? 
> 22 
22 was not found.
```

#### Exercise_80

The template has a method **public static int SumOfNumbersInArray(int[] array)**. Complete the method so, that it computes and returns the sum of the numbers in the array it receives as parameter.

You can try out the computation of the sum with this example:

```cs
int[] numbers = {5, 1, 3, 4, 2};
int sum = SumOfNumbersInArray(numbers);
Console.WriteLine(sum);
```

```console
15
```

#### Exercise_81

Complete the method **public static void PrintNEatly(int[] array)** in the template to make it print the numbers of the array it receives more nEatly. There should be a whitespace and a comma between each number. don't put a comma after the last number.

Print the numbers on one line using **Console.Write**.

You can try out your printing with this example:

```cs
int[] array = {5, 1, 3, 4, 2};
PrintNEatly(array);
```

```console
5, 1, 3, 4, 2
```

#### Exercise_82

Complete the method **public static void PrintArrayInStars(int[] array)** in the template to make it print a row of stars for each number in the array. The amount of stars on each row is defined by the corresponding number in the array.

You can try out the printing with this example:

```cs
int[] array = {5, 1, 3, 4, 2};
PrintArrayInStars(array);
```

```
***** 
* 
*** 
**** 
**
```

The 0th element of the array is 5, so the first line has 5 stars. The next one has 1 etc.

## Strings

#### Exercise_83

Write a program, that reads a string from the user and then prints it three times.

```console
Give a word: cake

cakecakecake
```

NOTICE! The program should ask for only one string. Don't use a loop here.

#### Exercise_84

Write a program that asks the user for a string. If the user writes the string "true", the program prints "You got it right!", otherwise it prints "Try again!".

```console
Give a string: true 
You got it right!
```


```console
Give a string: trueish 
Try again!
```

#### Exercise_85

write a program that recognizes the following users:


|username	|password|
|--|--|
|alex|	sunshine|
|emma|	haskell|

The program either shows a login message or informs of incorrect username or password.

```console
Enter username: 
>alex 
Enter password: 
> sunshine 
You have successfully logged in!
```
```console
Enter username: 
> emma 
Enter password: 
> haskell 
You have successfully logged in!
```

```console
Enter username: 
> alex 
Enter password: 
> haskell 
Incorrect username or password!
```

NOTICE! In read life login should not be implemented like this! This is just an exercise.

#### Exercise_86

Write a program that reads strings from the user. If the input is empty, the program stops reading input and halts. For each non-empty input it splits the string input by whitespaces and prints each part of the string on a new line.

```console
> once upon a time 
once 
upon 
a 
time 
> a little program 
a 
little 
program 
> halted 
halted
>
```

#### Exercise_87

Write a program, that reads user input until an empty line. For each non-empty string, the program splits the string by spaces and then prints the pieces that contain **av**, each on a new line.

```console
> navy blue shirt
navy
> Do you have a favourite flavour
have
favourite
flavour
> was that a cat
>
```

Tip! Strings have a Contains method, which tells if a string contains another string. It works like this:

```cs
string text = "volcanologist";

if (text.Contains("can")) 
{
  Console.WriteLine("can was found");
}

if (!text.Contains("tin")) 
{
  Console.WriteLine("tin wasn't found");
}
```

```console
can was found 
tin wasn't found
```

#### Exercise_88

Write a program, that reads user input until an empty line. For each non-empty line the program splits the string by spaces and prints the first part of the string.

```console
> one two three four 
one 
> this is a very important message 
this
>
```

#### Exercise_89

Write a program, that reads user input until an empty line. For each non-empty line the program splits the string by spaces and prints the last part of the string.

```console
> one two three four 
four 
> this is a very important message 
message
>
```

Tip! You can find out the length of the array like this:

```cs
string[] parts = {"one", "two", "three"};
Console.WriteLine("Number of parts: " + parts.Length);
```

```console
Number of parts: 3
```

#### Exercise_90

Write a program that reads names and ages from the user until an empty line is entered. The name and age are separed by a comma.

After reading the program prints the age of the oldest person. You can assume, that the user enters at least one person, and that one of the users is older than the others.

```console
> sebastian,2 
> lucas,2
> lily,1
> hanna,5
> gabriel,10
>
Age of the oldest: 10
```

#### Exercise_91

Write a program that reads names and ages from the user until an empty line is entered. The name and age are separed by a comma.

After reading the program prints the name of the oldest person. You can assume, that the user enters at least one person, and that one of the users is older than the others.

```console
> sebastian,2 
> lucas,2
> lily,1
> hanna,5
> gabriel,10
>
Name of the oldest: gabriel
```

#### Exercise_92

In this exercise you'll be asked for the length of the names. You can find out the length of a string with Length property:

```cs
string word = "equisterian";
int length = word.Length;
Console.WriteLine("The length of the word " + word + " is " + length);
```

```console
The length of the word equisterian is 11
```
Write a program that reads names and birth years from the user until an empty line is entered. The name and birth year are separed by a comma.

After that the program prints the longest name and the highest age. If multiple names are equally longest, you can print any of them. You can assume the user to enter at least one person, and the current year to be 2020.

```console
> sebastian,2017 
> lucas,2017 
> lily,2017 
> hanna,2014 
> gabriel,2009
>
Longest name: sebastian 
Highest age: 11
```

# Part 4

## Object Oriented Programming

When creating own classes, make sure to include the correct **namespace** so you can reference it from your Program.cs file. We'll get to namespaces later. For now, whenever you create a new class, **use the folder name as the namespace**.

You can test your own classes in the Main if you want to, but it is not necessary. It does, of course, help you understand your code, and the exercises might include some examples, how the classes should work.

#### Exercise_93

The exercise template comes with a ready-made class named Account. The Account object represents a bank account that has balance (i.e. one that has some amount of money in it). The accounts are used as follows:

```cs
Account heikkisAccount = new Account("Heikki's account", 100.00);
Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

Console.WriteLine("Intial state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);

heikkisAccount.Withdrawal(20);
Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
heikkisSwissAccount.Deposit(200);
Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

Console.WriteLine("End state");
Console.WriteLine(heikkisAccount);
Console.WriteLine(heikkisSwissAccount);
```

Write a program that 
- creates an account with a balance of 100.0, 
- deposits 20.0 in it, 
- and finally prints the balance. 

```console
120
```

NOTICE! Perform all the operations in this exact order.

#### Exercise_94

The Account from the previous exercise class is also available in this exercise.

Write a program that:

- CrEates an account named "Heikki's account" with the balance 1000.0
- CrEates an account named "Personal account" with the balance 0
- Withdraws 100.0 from Heikki's account
- Deposits 100.0 to its own personal account
- Prints account information (ToString) on both, first Heikki's, then Personal:

```console
Heikki's account balance: 900
Personal account balance: 100
```

#### Exercise_95

In this exercise, you'll practice crEating a class.

[**CHECK THIS MATERIAL FOR HELP**](https://centria.github.io/basic-coding/part4/1/#creating-a-new-class)

Name the class **Dog** (and the file **Dog.cs**)

You have now created a class called **Dog**. 
Add the variables 
- private string name,
- private string breed and 
- private int age   
to the class. As a class diagram, the class looks like this:

![Dog class diagram](https://github.com/centria/coding-exercises/raw/master/assets/images/dogclass.jpg)

NOTICE! You have to give your dog **namespace exercise_95** for it to function!

#### Exercise_96

create a class named **Room** (and file **Room.cs**). Add the variables **private string code** and **private int sEats** to the class. Then create a constructor **public Room(string classCode, int numberOfSEats)** through which values are assigned to the instance variables.

![Room class diagram](https://github.com/centria/coding-exercises/raw/master/assets/images/roomclass.jpg)

NOTICE! You have to give your room **namespace exercise_96** for it to function!

#### Exercise_97

create a class named **Whistle**. Add the variable **private string sound** to the class. After that, create the constructor **public Whistle(string whistleSound)**, which is used to create a new whistle that's given a sound. After that, create a method **public void Sound()** which prints out the sound (using Console.WriteLine).

```cs
Whistle duckWhistle = new Whistle("Kvaak");
Whistle roosterWhistle = new Whistle("Peef");

duckWhistle.Sound();
roosterWhistle.Sound();
duckWhistle.Sound();
```

```console
Kvaak 
Peef 
Kvaak
```

#### Exercise_98

create a class **Product** that represents a store product. The product should have a **price (double)**, a **quantity (int)** and a **name (string)**.

The class should have:

- the constructor **public Product(string name, double price, int quantity)**
- a method **public void PrintProduct()** that prints product information in the following format:

```console
Banana: price 1.1: 13 pcs
```

The output above is based on the product being assigned the name banana, with a price of 1.1, and a quantity of 13 .

#### Exercise_99

This exercise consists of multiple sections. Each section corresponds to one exercise point.

The exercise template comes with a partially executed class DecreasingCounter:

```cs
using System;

namespace exercise_99
{
  public class DecreasingCounter
  {
    private int value;   // a variable that remembers the value of the counter

    public DecreasingCounter(int initialValue)
    {
      this.value = initialValue;
    }

    public void PrintValue()
    {
      Console.WriteLine("value: " + this.value);
    }

    public void decrement()
    {
      // write the method implementation here
      // the aim is to decrement the value of the counter by one
    }

    // and the other methods go here
  }
}
```

The following is an example of how the main program uses the decreasing counter:

```cs
public static void Main(string[] args)
{
  DecreasingCounter counter = new DecreasingCounter(10);
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();
}
```

```console
value: 10
value: 9
value: 8
```

##### Section 1 : Implementation of the **Decrement() method**

Implement the **Decrement()** method in the class body in such a way that it decrements the value variable of the object it's being called on by one. Once you're done with the **Decrement()** method, the main program of the previous example should work to produce the example output.

##### Section 2 : The counter's value cannot be negative

Improve the **Decrement()** in such a way that the counter's value never becomes negative. This means that if the value of the counter is 0, it cannot be decremented. A conditional statement is useful here.

```cs
public static void Main(string[] args)
{

  DecreasingCounter counter = new DecreasingCounter(2);
  counter.PrintValue();

  counter.Decrement();
  counter.Decrement();
  counter.PrintValue();

  counter.Decrement();
  counter.PrintValue();
}
```

```console
value: 2
value: 0
value: 0
```

##### Section 3: Resetting the counter value

create the method **public void Reset()** for the counter that resets the value of the counter to 0. For example:

```cs
public static void Main(string[] args)
{

  DecreasingCounter counter = new DecreasingCounter(20);
  counter.PrintValue();

  counter.Reset();
  counter.PrintValue();
}
```

```console
value: 20
value: 0
```

#### Exercise_100

create the class **Debt** that has double-typed instance variables of **balance** and **interestRate**. The balance and the interest rate are passed to the constructor as parameters **public Debt(double initialBalance, double initialInterestRate)**.

In addition, create the methods **public void PrintBalance()** and **public void WaitOneYear()** for the class. The method PrintBalance prints the current balance, and the WaitOneYear method grows the debt amount.

The debt is increased by multiplying the balance by the interest rate.

The class should do the following:

```cs
public static void Main(string[] args)
{

  Debt mortgage = new Debt(120000.0, 1.01);
  mortgage.PrintBalance();

  mortgage.WaitOneYear();
  mortgage.PrintBalance();

  // Wait 20 years
  int years = 0;
  while (years < 20)
  {
    mortgage.WaitOneYear();
    years = years + 1;
  }

  mortgage.PrintBalance();
}
```

The example above illustrates the development of a mortgage with an interest rate of one percent.

Prints:

```console
120000
121200
147887.0328416936
```

### Exercise_101

Create a class called **Dalmatian**. The dalmatian has instance variables **string name** and **int spots**. Both are set in the **public Dalmatian(string name, int spots)** constructor. Also, give the variables ability for get and set:
**Make the variables public rather than private, and add { get; set; } on the declaring lines!**

```cs
Dalmatian spotty = new Dalmatian("Spot", 306);
Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
```

```console
Spot is a very good dog. He has 306 darker spots in his fur
```

#### Exercise_102

create the class **Gauge**. The gauge has the instance **public int value**, a **constructor without parameters** (sets the initial value of the meter variable to 0), and also the following three methods:

- Method **public void Increase()** grows the value instance variable's value by one. It does not grow the value beyond five.
- Method **public void Decrease()** decreases the value instance variable's value by one. It does not decrease the value to negative values.
- Method **public bool Full()** returns **True** if the instance variable value has the value five. Otherwise, it returns **False**.

Also, give the value ability for get and set:
**Make the value public rather than private, and add { get; set; } on the declaring lines!**

An example of the class in use.

```cs
public static void Main(string[] args)
{
  Gauge g = new Gauge();

  while (!g.Full())
  {
    Console.WriteLine("Not full! Value: " + g.value);
    g.Increase();
  }

  Console.WriteLine("Full! Value: " + g.value);
  g.Decrease();
  Console.WriteLine("Not full! Value: " + g.value);
}
```

```console
Not full! Value: 0
Not full! Value: 1
Not full! Value: 2
Not full! Value: 3
Not full! Value: 4
Full! Value: 5
Not full! Value: 4
```

### Exercise_103

The exercise template defines an Agent class, having a first name and last name. The Main method tries to print the introduction for mister Bond, but with no luck. This is what is should do:

```cs
public static void Main(string[] args)
{
  Agent bond = new Agent("James", "Bond");
  Console.WriteLine(bond);

  Agent bourne = new Agent("Jason", "Bourne");
  Console.WriteLine(bourne);
}
```

```console
My name is Bond. James Bond.
My name is Bourne. Jason Bourne.
```

Agent's ToString now returns an empty string. Fix it to introduce international agents in their proper form.

#### Exercise_104

create a class **Multiplier** that has a:

Constructor **public Multiplier(int number)**.
Method **public int Multiply(int number)** which returns the value number passed to it multiplied by the number provided to the constructor.
**You also need to create an instance variable in this exercise.** When you call the method Multiply, store the changed value into the instance variable!

An example of the class in use:

```cs
public static void Main(string[] args)
{
  Multiplier multiplyByThree = new Multiplier(3);

  Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

  Multiplier multiplyByFour = new Multiplier(4);

  Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
  Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
  Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
  Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
}
```

```console
multiplyByThree.Multiply(2): 6
multiplyByFour.Multiply(2): 8
multiplyByThree.Multiply(1): 6
multiplyByFour.Multiply(1): 8
multiplyByFour.Multiply(3): 24
```

NOTICE! The value stored in the objects is changed during the first calls!  
The calculations are actually ( in order):  
3 * 2 = 6  
4 * 2 = 8  
6 * 1 = 6  
8 * 1 = 8  
8 * 3 = 24

#### Exercise_105

The exercise template includes class **Statistics**

```cs
namespace exercise_105
{
  public class Statistics
  {
    public int count {get; set;}
    public int sum { get; set; }

    public NumberStatistics()
    {
      // initialize the variable count here
    }

    public void AddNumber(int number) {
        // write code here
    }
  }
}
```

The following program introduces the class' use:

```cs
Statistics statistics = new Statistics();
statistics.AddNumber(3);
statistics.AddNumber(5);
statistics.AddNumber(1);
statistics.AddNumber(2);
Console.WriteLine("Count: " + statistics.count);
Console.WriteLine("Sum: " + statistics.sum);
```

```console
Count: 4
Sum: 11
```

Expand the program as follows:
- When a number is added, **count** is increased by one
- When a number is added, **sum** is increased by the number's value

#### Exercise_106

In this exercise series, a class called PaymentCard is created which aims to mimic a cafeteria's payment process.

The template includes the **Program.cs** file. You have to create the **PaymentCard.cs** yourself.

- Add a new class to the project called **PaymentCard** (by creating the file mentioned above).
- create the PaymentCard object's constructor, which is passed the opening balance of the card, and which then stores that balance in the object's internal variable. 
- Write the ToString method, which will return the card's balance in the form **"The card has a balance of X euros"**.

Here is the template for the PaymentCard:

```cs
namespace exercise_106
{
  public class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
    }

    public override string ToString()
    {
      // write code here
    }
  }
}
```
The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(50);
  Console.WriteLine(card);
}
```

```console
The card has a balance of 50 euros
```

#### Exercise_107

Expand your answer from the exercise 106 by adding two methods:
- Method **public void EatLunch()**
- Method **public void DrinkCoffee()**

The method **EatLunch** should decrease the card's balance by 10.60 euros. The method **DrinkCoffee** should decrease the card's balance by 2.0 euros.

The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(50);
  Console.WriteLine(card);

  card.EatLunch();
  Console.WriteLine(card);
  
  card.DrinkCoffee();
  Console.WriteLine(card);
}
```

```console
The card has a balance of 50 euros
The card has a balance of 39.4 euros
The card has a balance of 37.4 euros
```

#### Exercise_108

Expand your previous answers, so that when an item is bought the balance is checked. If there is not enough money to buy, the balance does not change.

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(10);
  Console.WriteLine(card);

  card.EatLunch();
  Console.WriteLine(card);
  
  card.DrinkCoffee();
  Console.WriteLine(card);
}
```

```console
The card has a balance of 10 euros
The card has a balance of 10 euros
The card has a balance of 8 euros
```

Notice how EatLunch did not change the balance, as there was not enough money. DrinkCoffee still worked, as it should.

#### Exercise_109

Expand your previous answers, so that you can charge money on your card:

```cs
public void AddMoney(double amount) {
    // write code here
}
```

The purpose of the method is to increase the card's balance by the amount of money given as a parameter. However, the card's balance may not exceed 150 euros. As such, if the amount to be topped up exceeds this limit, the balance should, in any case, become exactly 150 euros.

The following main program tests the class:

```cs
public static void Main(string[] args)
{
  PaymentCard card = new PaymentCard(100);
  Console.WriteLine(card);

  card.AddMoney(49.99);
  Console.WriteLine(card);

  card.AddMoney(10000.0);
  Console.WriteLine(card);

  card.AddMoney(-10);
  Console.WriteLine(card);
}
```

```console
The card has a balance of 100 euros
The card has a balance of 149.99 euros
The card has a balance of 150 euros
The card has a balance of 150 euros
```

Notice! You cannot add negative money!

## Objects in list

#### Exercise_110

Implement the class **Main** described here. **Do not modify the class Item.**

Write a program that reads names of items from the user. If the name is empty, the program stops reading. Otherwise, the given name is used to create a new item, which you will then add to the items list.

Having read all the names, print all the items by using the ToString method of the Item class. The implementation of the Item class keeps track of the time of crEation, in addition to the name of the item.

NOTICE! The list has to be called "items" for the tests to work!

Example print:
```console
Name: Hammer
Name: Radio
Name: Hot Potato
Name: 

Hammer (created at: 9.2.2020 13.48.16)
Radio (created at: 9.2.2020 13.48.18)
Hot Potato (created at: 9.2.2020 13.48.21)
```

#### Exercise_111

The program described here should be implemented in the class Main. Do not modify the class PersonalInformation.

After the user has entered the last set of details (they enter an empty first name), exit the repEat statement. 

Print one empty line here for reading clarity.

Then print the collected personal information so that each entered object is printed in the following format: first and last names separated by a space (you don't print the identification number). An example of the working program is given below:

```console
First name: 
> Jean 
Last name: 
> Bartik 
Identification number: 
> 271224 
First name: 
> Betty 
Last name: 
> Holberton 
Identification number: 
> 070317 
First name:
>

Jean Bartik 
Betty Holberton
```

You can (and should) ask the identification number as a string.

#### Exercise_112

In the exercise template there is a ready-made class TelevisionProgram, representing a television program. The class has object variables name and duration, a constructor, and a few methods.

Implement a program that begins by reading television programs from the user. When the user inputs an empty string as the name of the program, the program stops reading programs.

After this the user is queried for a maximum duration. Once the maximum is given, the program proceeds to list all the programs whose duration is smaller or equal to the specified maximum duration.

```console
Name: Rick and Morty 
Duration: 25 
Name: Two and a Half Men 
Duration: 30 
Name: Love it or list it 
Duration: 60 
Name: House 
Duration: 60
Name:

Program's maximum duration? 30 
Rick and Morty, 25 minutes 
Two and a Half Men, 30 minutes
```

#### Exercise_113

This exercise is worth 2.

Write a program that first reads book information from the user. The details to be asked for each book include the title, the number of pages, and the publication year. Entering an empty string as the name of the book ends the reading process.

After this the user is asked for what is to be printed. If the user inputs "everything", all the details are printed: the book titles, the numbers of pages, and the publication years. However, if the user enters the string "title", only the book titles are printed. If something else than "everything" or "title" is given, the program should not print anything.

- Implement the class Book.
- Implement the functionality in the Main method.

Example of how the program in Main should work:

```console

Name: To Kill a Mockingbird 
Pages: 281 
Publication year: 1960 
Name: A Brief History of Time 
Pages: 256 
Publication year: 1988 
Name: Beautiful Code 
Pages: 593 
Publication year: 2007 
Name: The Name of the Wind 
Pages: 662 
Publication year: 2007 
Name:

What information will be printed? everything 
To Kill a Mockingbird, 281 pages, 1960 
A Brief History of Time, 256 pages, 1988 
Beautiful Code, 593 pages, 2007 
The Name of the Wind, 662 pages, 2007
```

```console
Name: To Kill a Mockingbird 
Pages: 281 
Publication year: 1960 
Name: A Brief History of Time 
Pages: 256 
Publication year: 1988 
Name: Beautiful Code 
Pages: 593 
Publication year: 2007 
Name: The Name of the Wind 
Pages: 662 
Publication year: 2007 
Name:

What information will be printed? title 
To Kill a Mockingbird 
A Brief History of Time 
Beautiful Code 
The Name of the Wind
```

## Files and reading data

#### Exercise_114

As a recap, a simple program of reading the input.

Write a program that reads strings from the user until the user inputs the string "end". At that point, the program should print how many strings have been read. The string "end" should not be included in the number strings read. You can find some examples below of how the program works.

```console
> I 
> have
> a
> feeling
> that
> I
> have
> written
> this
> wrong
> before
> end 
11
```

```console
> end 
0
```

#### Exercise_115

Write a program that reads strings from the user until the user inputs the string "end". As long as the input is not "end", the program should handle the input as an integer and print the cube of the number provided (i.e., number * number * number). Below are some sample outputs

```console
> 3 
27 
> -1 
-1 
> 11 
1331 
> end
```

```console
end
```

Remember to convert to integer before calculation!

#### Exercise_116

Write a program that prints the contents of a file called "data.txt", such that each line of the file is printed on its own line.

If the file content looks like so:

In a world   
Where code is built   

Then the program should print the following:

```console
In a world
Where code is built
```

#### Exercise_117

Write a program that asks the user for a string, and then prints the contents of a file with a name matching the string provided. You may assume that the user provides a file name that the program can find. You do not have to worry about getting errors when the file does not exist.

The exercise template contains the files "data.txt" and "song.txt", which you may use when testing the functionality of your program. The output of the program can be seen below for when a user has entered the string "song.txt". The content that is printed comes from the file "song.txt". Naturally, the program should also work with other filenames, assuming the file can be found.

```console
Which file should have its contents printed? 
> song.txt 

No option for duality 
The old is where we come 
Clockspeed is fast, but we'll survive 
The new will overcome 
We are challengers, not followers 
We take the ball to build 
Easy safe services 
Are here to stay

Value for society 
Value for life 
For you and me 
Tieto is here allright!
```

#### Exercise_118

The exercise template comes ready with functionality for the guest list application. It checks whether names entered by the user are on the guest list.

However, the program is missing the functionality needed for reading the guest list. Modify the program so that the names on the guest list are read from the file.

Name of the file: guestlist.txt

```console
Enter names, an empty line quits. 
> Chuck Norris 
The name is not on the list. 
> Jack Baluer 
The name is not on the list. 
> Jack Bauer 
The name is on the list. 
> Jack Bower 
The name is on the list.
>
Thank you!
```

NOTICE! The exercise template comes with two files, names.txt and other-names.txt, which have the following contents. Do not change the contents of the files!

NOTICE2! The exercise expects you to have a **string names** where you store the file!

names.txt:

ada  
arto  
leena  
test  
heikki  
   
other-names.txt:
  
leo   
jarmo   
alicia  
mike  
potato  
  
# Part 5

## Object oriented revision

#### Exercise_119

The exercise template comes with the **"ClockHand"** class described in the course material. Implement a **Timer** class based on the material's Clock class.

The timer has two hands, one for hundredths of a second and one for seconds. As it progresses, the number of hundredths of a second grows by one. When the hand corresponding to hundredths of a second reaches a value of 100, its value is set to zero, and the number of seconds grows by one. In the same way, when the value of the hand corresponding to seconds reaches the value of sixty, its value is set to zero.

- **public Timer()** creates a new timer.
- **public override string ToString()** returns a string representation of the timer. The string representation should be in the form "seconds: hundredths of a second", where both the seconds and the hundredths of a second are represented by two numbers. For example, **"19:83"** would represent the time 19 seconds, 83 hundredths of a second.
- **public void Advance()** moves the timer forward by a hundredth of a second.

You can test out the timer's functionality in the main program whenever you like. The example code below provides you with a program where the timer is printed and it advances once every hundredth of a second.

```cs
static void Main(string[] args)
{
  // create new timer
  Timer timer = new Timer();
  // Loop until you cancel the loop.
  // You can cancel with the CTRL + C
  while (true)
  {
    Console.WriteLine(timer);
    timer.Advance();
    // Some error proving, we'll talk about this later.
    // Known as try-catch.
    try
    {
      // Wait 100th of a second. 
      // Sleep(1000) waits one second, if you want to test at slower pace.
      System.Threading.Thread.Sleep(10);
    }
    // Other half of try-catch pair. 
    catch (Exception e)
    {
      Console.WriteLine("Error happened: +" + e);
    }
  }
}
```

#### Exercise_120

create a **Cube** class that represents a cube (i.e., a standard hexahedron). create a **public Cube (int edgeLength)** constructor for the class, that takes the length of the cube's edge as its parameter.

Make a **public int Volume()** method for the cube, which calculates and returns the cube's volume. The volume of the cube is calculated with the formula **edgeLength * edgeLength * edgeLength**. Moreover, make a **public override string ToString()** method for the cube, which returns a string representation of it. The string representation should take the form **"The length of the edge is l and the volume v"**, where l is the length and v the volume - both the length and volume must be represented as integers.

#### Exercise_121

[**The Karvonen method**](https://en.wikipedia.org/wiki/Heart_rate#Karvonen_method) allows you to calculate your target heart rate for physical exercise. The target heart rate is calculated with the formula **(maximum heart rate - resting heart rate) * (target heart rate percentage) + resting heart rate**, where the target heart rate is given as a percentage of the maximum heart rate.

For example, if a person has a maximum heart rate of 200, a resting heart rate of 50, and a target heart rate of 75% of the maximum heart rate, the target heart rate should be about ((200-50) * (0.75) + 50), i.e., 162.5 bEats per minute.

create an "exercise assistant" class called **Fitbyte**. Its constructor takes both an age and a resting heart rate as its parameters. The exercise assistant should provide a method **TargetHeartRate**, which is passed a number of type double as a parameter that represents a percentual portion of the maximum heart rate. The proportion is given as a number between zero and one. The class should have:

- A constructor **public Fitbyte(int age, int restingHeartRate)**
- A method **public double TargetHeartRate(double percentageOfMaximum)** that calculates and returns the target heart rate.

Use the formula **206.3 - (0.711 * age)** to calculate the maximum heart rate.
Use the formula **(maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate** to calculate the target heart rate.

Use case:

```cs
public static void Main(string[] args)
{
  Fitbyte assistant = new Fitbyte(30, 60);
  double percentage = 0.5;

  while (percentage < 1.0)
  {
    double target = assistant.TargetHeartRate(percentage);
    Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
    percentage = percentage + 0.1;
  }
}
```

```console
Target 50% of maximum: 122.48500000000001
Target 60% of maximum: 134.98200000000003
Target 70% of maximum: 147.479
Target 80% of maximum: 159.976
Target 89.99999999999999% of maximum: 172.473
Target 99.99999999999999% of maximum: 184.97000000000003
```


## Overloading

#### Exercise_122

The exercise template has a class Product, which represents a product in a shop. Every product has a name, location and weight.

Add the following three constructors to the Product class:

- **public Product(string name)** creates a product with the given name. Its location is set to "shelf" and its weight is set to 1.
- **public Product(string name, string location)** creates a product with the given name and the given location. Its weight is set to 1.
- **public Product(string name, int weight)** creates a product with the given name and the given weight. Its location is set to "warehouse".
You can test your program with the following code:

```cs
Product tapeMeasure = new Product("Tape measure");
Product plaster = new Product("Plaster", "home improvement section");
Product tyre = new Product("Tyre", 5);

Console.WriteLine(tapeMeasure);
Console.WriteLine(plaster);
Console.WriteLine(tyre);
```

```console
Tape measure (1 kg) can be found from the shelf. 
Plaster (1 kg) can be found from the home improvement section. 
Tyre (5 kg) can be found from the warehouse.
```

#### Exercise_123

Implement a class called **Counter**. The class contains a number, whichs value can be increased and decreased. The class must have the following constructors:

- **public Counter(int startValue)** sets the start value of the counter to startValue.

- **public Counter()** sets the start value of the counter to 0.

And the following methods and properties:

- **public int value { get; set; }**
- **public void Increase()** increases the value by 1
- **public void Decrease()** decreases the value by 1
- **public void Increase(int increaseBy)** increases the value of the counter by the value of increaseBy. If the value of increaseBy is negative, the value of the counter does not change.
- **public void Decrease(int decreaseBy)** decreases the value of the counter by the value of decreaseBy. If the value of decreaseBy is negative, the value of the counter does not change.

## Objects and references

#### Exercise_124

Implement a program that causes the **NullReferenceException** error. The error should occur directly after starting the program -- don't wait to read input from the user, for instance.

HINT! Change an object into null, and try to use it.

#### Exercise_125

In the exercise base there is the class **Person**, which we are already quite familiar with. There is also an outline for the class **HealthStation**. Health station objects process people in different ways, they e.g. weigh and feed people. In this exercise we will construct a health station. The code of the Person class should not be modified in this exercise!


##### Section 1 - Weighing people

The **Weigh** method receives a person as a parameter, and it is meant to return to its caller the weight of that person. The weight information can be found by calling a suitable property of the Person person. So your task is to complete the code of the method!

##### Section 2 - Feeding people

It is possible to modify the state of the object that is received as a parameter. Fill in the method called **public void Feed(Person person)** for the health station. It should increase the weight of the parameter person by one.

##### Section 3 - Counting weighings

Use the variable **public int weighings { get; private set; }** to count weighings - That is, when ever the method **Weigh** is called, the variable should increase by one.

Here's a Main class to test all of the sections:

```cs
public static void Main(string[] args)
{
  // create new Station
  HealthStation childrensHospital = new HealthStation();

  // create two new persons
  Person ethan = new Person("Ethan", 1, 110, 7);
  Person peter = new Person("Peter", 33, 176, 85);

  // Try out the Persons and method Weigh
  Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
  Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

  // Test feeding the persons
  childrensHospital.Feed(ethan);
  childrensHospital.Feed(peter);

  // See that the weights have changed
  Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
  Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

  // Keep weighing to increase the 'int weighings'
  childrensHospital.Weigh(ethan);
  childrensHospital.Weigh(ethan);
  childrensHospital.Weigh(ethan);
  childrensHospital.Weigh(ethan);

  // See that the variable has increased to 8
  Console.WriteLine("weighings performed: " + childrensHospital.weighings);
}
```

Should print out 

```console
Ethan weight: 110 kilos
Peter weight: 176 kilos
Ethan weight: 111 kilos
Peter weight: 177 kilos
weighings performed: 8
```

#### Exercise_126

In a previous exercises part we created a class called **PaymentCard**. The card had methods for Eating a lunch and drinking coffee, and also for adding money to the card.

However, there was a problem with the **PaymentCard** class that is implemented in this fashion. The card knew the prices of the different payments, and therefore was able to decrease the balance by the proper amount. What about if the prices are raised? Or new items are added to the list of offered products? A change in the pricing would mean that all the existing cards would have to be replaced with new cards that are aware of the new prices.

An improved solution is to make the cards "dumb"; unaware of the prices and products that are sold, and only keeping track of their balance. All the intelligence is better placed in separate objects, payment terminals.


##### Section 1

Let's first implement the **"dumb" version of the PaymentCard**. The card only has ability for asking for the balance, adding money, and taking money. Complete the method **public bool TakeMoney(double amount)** in the class below (and found in the exercise template), using the following as a guide:

```cs
namespace exercise_126
{
  public class PaymentCard
  {
    public double balance { get; private set; }

    public PaymentCard(double balance)
    {
      this.balance = balance;
    }

    public void AddMoney(double increase)
    {
      this.balance = this.balance + increase;
    }

    public bool TakeMoney(double amount)
    {
      // implement the method so that it only takes money from the card if
      // the balance is at least the amount parameter.
      // returns true if successful and false otherwise

      return false;
    }
  }
}
```

```cs
static void Main(string[] args)
{
  PaymentCard petesCard = new PaymentCard(10);

  Console.WriteLine("money " + petesCard.balance);
  bool wasSuccessful = petesCard.takeMoney(8);
  Console.WriteLine("successfully withdrew: " + wasSuccessful);
  Console.WriteLine("money " + petesCard.balance);

  wasSuccessful = petesCard.takeMoney(4);
  Console.WriteLine("successfully withdrew: " + wasSuccessful);
  Console.WriteLine("money " + petesCard.balance);

}
```

Should print like this:

```console
money 10
successfully withdrew: True
money 2
successfully withdrew: False
money 2
```

##### Section 2

When visiting a student cafeteria, the customer pays either with cash or with a payment card. The cashier uses a payment terminal to charge the card or to process the cash payment. First, let's create a terminal that's suitable for cash payments.

The outline of the payment terminal. The comments inside the methods tell the wanted functionality:

```cs
namespace exercise_126
{
  public class PaymentTerminal
  {
    private double money;  // amount of cash
    private int coffeeAmount; // number of sold coffees
    private int lunchAmount;  // number of sold lunches

    public PaymentTerminal()
    {
      // register initially has 1000 euros of money
    }

    public double DrinkCoffee(double payment)
    {
      // an coffee now costs 2.50 euros
      // increase the amount of cash by the price of an coffee mean and return the change
      // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
    }

    public double EatLunch(double payment)
    {
      // a lunch now costs 10.30 euros
      // increase the amount of cash by the price of a lunch and return the change
      // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
    }

    public override string ToString()
    {
      return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
    }
  }
}
```

The terminal starts with 1000 euros in it. Implement the methods so they work correctly, using the basis above and the example prints of the main program below.

```cs
PaymentTerminal lunchCafeteria = new PaymentTerminal();

double change = lunchCafeteria.DrinkCoffee(10);
Console.WriteLine("remaining change " + change);

change = lunchCafeteria.DrinkCoffee(5);
Console.WriteLine("remaining change " + change);

change = lunchCafeteria.EatLunch(20);
Console.WriteLine("remaining change " + change);

Console.WriteLine(lunchCafeteria);
```

```console
remaining change 7.5
remaining change 2.5
remaining change 13
money: 1015.3, number of sold coffees: 2, number of sold lunches: 1
```

##### Section 3

Let's extend our payment terminal to also support card payments. We are going to create new methods for the terminal. It receives a payment card as a parameter, and decreases its balance by the price of the meal that was purchased. Here are the outlines for the methods, and instructions for completing them.

```cs
public bool DrinkCoffee(PaymentCard card)
{
  // a coffee costs 2.50 euros
  // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
  // otherwise false is returned
}

public bool EatLunch(PaymentCard card)
{
  // a lunch costs 10.30 euros
  // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
  // otherwise false is returned
}
```

Notice! Card payments do not increase the cash in the register.

```cs
PaymentTerminal lunchCafeteria = new PaymentTerminal();

double change = lunchCafeteria.DrinkCoffee(10);
Console.WriteLine("remaining change: " + change);

PaymentCard annesCard = new PaymentCard(15);

bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
Console.WriteLine("there was enough money: " + wasSuccessful);
wasSuccessful = lunchCafeteria.EatLunch(annesCard);
Console.WriteLine("there was enough money: " + wasSuccessful);
wasSuccessful = lunchCafeteria.DrinkCoffee(annesCard);
Console.WriteLine("there was enough money: " + wasSuccessful);

Console.WriteLine(lunchCafeteria);
```

```console
remaining change: 7.5
there was enough money: True
there was enough money: False
there was enough money: True
money: 1002.5, number of sold coffees: 2, number of sold lunches: 1
```

##### Section 4

Let's create a method for the terminal that can be used to add money to a payment card. Recall that the payment that is received when adding money to the card is stored in the register (adding cash). The basis for the method:

```cs
public void AddMoneyToCard(PaymentCard card, double sum)
{
  // ...
}
```

A main program to illustrate:


```cs
public static void Main(string[] args)
{
  // Try your code here, if you want

  PaymentTerminal lunchCafeteria = new PaymentTerminal();
  Console.WriteLine(lunchCafeteria);

  PaymentCard annesCard = new PaymentCard(2);

  Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

  bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
  Console.WriteLine("there was enough money: " + wasSuccessful);

  lunchCafeteria.AddMoneyToCard(annesCard, 100);

  wasSuccessful = lunchCafeteria.EatLunch(annesCard);
  Console.WriteLine("there was enough money: " + wasSuccessful);

  Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

  Console.WriteLine(lunchCafeteria);
}
```

```console
money: 1000, number of sold coffees: 0, number of sold lunches: 0
amount of money on the card is 2 euros
there was enough money: False
there was enough money: True
amount of money on the card is 91.7 euros
money: 1100, number of sold coffees: 0, number of sold lunches: 1
```

#### Exercise_127

Two classes, Person and Pet, are included in the exercise template. Each person has one pet. Modify the **public override string ToString** method of the **Person class** so that the string it returns tells the pet's name and breed in addition to the person's own name.

```cs
public static void Main(string[] args)
{

  Pet lucy = new Pet("Lucy", "golden retriever");
  Person leo = new Person("Leo", lucy);
  Console.WriteLine(leo);

  Person mike = new Person("Mike");
  Console.WriteLine(mike);
  
  Person lilo = new Person();
  Console.WriteLine(lilo);
}
```

```console
Leo, has a friend called Lucy (golden retriever)
Lilo, has a friend called Stitch (blue alien)
Mike, has a friend called Toothless (dragon)
```

#### Exercise_128

Fill in the method **public bool LargerThan(Apartment compared)** that returns true if the apartment object whose method is called has a larger total area than the apartment object that is being compared.

An example of how the method should work:

```cs
public static void Main(string[] args)
{
  Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
  Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
  Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);

  Console.WriteLine(manhattanStudioApt.LargerThan(atlantaTwoBedroomApt));
  Console.WriteLine(bangorThreeBedroomApt.LargerThan(manhattanStudioApt));
}
```

```console
False
True
```

Fill in the method **public int PriceDifference(Apartment compared)** that returns the price difference of the apartment object whose method was called and the apartment object received as the parameter. The price difference is the absolute value of the difference of the prices (price can be calculated by multiplying the price per square by the number of squares). Use the method **private int Price()** to calculate the price for the apartments.

An example of how the method should work:

```cs
Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
Console.WriteLine(manhattanStudioApt.PriceDifference(atlantaTwoBedroomApt));
Console.WriteLine(bangorThreeBedroomApt.PriceDifference(manhattanStudioApt));
```

```console
71600
107000
```

Fill in the method **public bool MoreExpensiveThan(Apartment compared)** that returns true if the apartment object whose method is called is more expensive than the apartment object being compared.

An example of how the method should work:

```cs
Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));
```

```console
False
True
```

#### Exercise_129

In the exercise base there is a class called **Song** that can be used to create new objects that represent songs. Add to that class the **Equals** method so that the similarity of songs can be examined.

You can try your code with this:

```cs
public static void Main(string[] args)
{
  // Try your code here, if you want
  Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
  Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

  if (jackSparrow.Equals(anotherSparrow))
  {
    Console.WriteLine("Songs are equal.");
  }

  if (jackSparrow.Equals("Another object"))
  {
    Console.WriteLine("Strange things are afoot.");
  }
}
```

#### Exercise_130

There is a program in the exercise base that asks for books from the user and adds them to a list.

Modify the program so that books that are already on the list are not added to it again. Two books should be considered the same if they have the same name and publication year.

Example print:

```console
Name (empty will stop): 
> Bossypants 
Publication year: 
>2013 
Name (empty will stop):
> Seriously...I'm Kidding
Publication year:
> 2012 
Name (empty will stop):
> Seriously...I'm Kidding 
Publication year:
> 2012 
The book is already on the list. Let's not add the same book again. 
Name (empty will stop):
>

Thank you! Books added: 2
```

#### Exercise_131

The program should read items from the user. When all the items from the user have been read, the program prints the information of each item.

For each item, its identifier and name should be read. If the identifier or name is empty, the program stops asking for input, and prints all the item information.

Example print:

```console
Identifier? (empty will stop):
> B07H8ND8HH 
Name? (empty will stop):
> He-Man figure
Identifier? (empty will stop):
> B07H8ND8HH 
Name? (empty will stop):
> He-Man 
Identifier? (empty will stop):
> B07NQFMZYG 
Name? (empty will stop):
> He-Man figure 
Identifier? (empty will stop):
> B07NQFMZYG 
Name? (empty will stop):
> He-Man figure
Identifier? (empty will stop):
>

==Items== 
B07H8ND8HH: He-Man figure 
B07NQFMZYG: He-Man figure
```


The printing format of the items should be identifier: name.

After entering the items, each item is printed at most once. Two items should be considered the same if their identifiers are the same (there can be variation in their names in different countries, for instance).

If the user enters the same item multiple times, the print uses the item that was added first.

Hint! It is probably smart to add each item to the list at most once -- compare the equality of the objects based on their identifiers.

#### Exercise_132

This exercise is worth 2.

With the exercise base the class SimpleDate is supplied. The date is stored with the help of the object variables year, month, and day. There are some methods that need fulfilling:

- **public void Advance()** advances the date by one day.  In this exercise we assume that each month has 30 day. Remember! In certain situations you need to change the values of month and year.
- **public void Advance(int howManyDays)** advances the date by the amount of days. Use the method Advance() that you implemented to help you in this.
- **public SimpleDate AfterNumberOfDays(int days)**  It creates a new SimpleDate object whose date is the specified number of days grEater than the object that the method was called on. You may still assume that each month has 30 days. Notice that the old date object must remain unchanged!

Since the last method must create a new object, the structure of the code should be somewhat similar to this:

```cs
SimpleDate newDate = new SimpleDate( ... );

// Do something here

return newDate;
```

The whole class template looks like this:

```cs
namespace exercise_132
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public void Advance() {
      // Do something here
    }

    public void Advance(int howManyDays) {
      // Do something here
    }

    public SimpleDate AfterNumberOfDays(int days) {
      SimpleDate newDate = new SimpleDate( ... );

      // Do something here

      return newDate;
    }

    
    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    // used to check if this date object (`this`) is before
    // the date object given as the parameter (`compared`)
    public bool Before(SimpleDate compared)
    {
      // first compare years
      if (this.year < compared.year)
      {
        return true;
      }

      // if the years are the same, compare months
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }

      // the years and the months are the same, compare days
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }

      return false;
    }
  }
}
```

Here's example use:
```cs
public static void Main(string[] args)
{
  SimpleDate date = new SimpleDate(13, 2, 2015);
  Console.WriteLine("Friday of the examined week is " + date);

  SimpleDate newDate = date.AfterNumberOfDays(7);
  int week = 1;
  while (week <= 7)
  {
    Console.WriteLine("Friday after " + week + " weeks is " + newDate);
    newDate = newDate.AfterNumberOfDays(7);

    week = week + 1;
  }

  Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
  // Console.WriteLine("Try " + date.AfterNumberOfDays(790));

}
```

```console
Friday of the examined week is 13.2.2015
Friday after 1 weeks is 20.2.2015
Friday after 2 weeks is 27.2.2015
Friday after 3 weeks is 4.3.2015
Friday after 4 weeks is 11.3.2015
Friday after 5 weeks is 18.3.2015
Friday after 6 weeks is 25.3.2015
Friday after 7 weeks is 2.4.2015
The date after 790 days from the examined Friday is ... try it out yourself!
```

NOTICE! Instead of modifying the state of the old object we return a new one with **AfterNumberOfDays**. Imagine that the SimpleDate class has a method Advance that works similarly to the method we programmed, but it modifies the state of the old object. In that case the next block of code would cause problems.

```cs
SimpleDate now = new SimpleDate(13, 2, 2015);
SimpleDate afterOneWeek = now;
afterOneWeek.Advance(7);

Console.WriteLine("Now: " + now);
Console.WriteLine("After one week: " + afterOneWeek);
```

```console
Now: 20.2.2015 
After one week: 20.2.2015
```

This is because a normal assignment only copies the reference to the object. So the objects now and afterOneWeek in the program now refer to the **one and same SimpleDate object**.

#### Exercise_133

This exercise is worth 2.

In the Payment card exercise we used a double-type object variable to store the amount of money. In real applications this is not the approach you want to take, since as we have seen, calculating with doubles is not exact. A more reasonable way to handle amounts of money is create an own class for that purpose. Here is a layout for the class:

```cs
namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      Money newMoney = new Money(/* Do something here*/);
      // create a new Money object that has the correct worth

      // return the new Money object
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money(/* Do something here*/);
      // create a new Money object that has the correct worth

      // return the new Money object
      return newMoney;
    }

    public bool LessThan(Money compared)
    {
      // Do something here
      return false;
    }

    public string toString()
    {
      string zero = "";
      if (cents <= 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
```

Next we'll create a few operations for processing money.

- First create the method **public Money Plus(Money addition)** that returns a new money object that is worth the total amount of the object whose mehtod was called and the object that is received as the parameter.

The basis for the method is the following:

```cs
public Money Plus(Money addition)
{
  Money newMoney = new Money(/* Do something here*/);
  // create a new Money object that has the correct worth

  // return the new Money object
  return newMoney;
}
```
NOTICE! If the cents would go over 100, the euros should increase as well!

- create the method **public bool LessThan(Money compared)** that returns true if the money object whose method is called has a grEater worth than the money object that is received as the method parameter.

- Write the method **public Money Minus(Money decreaser)** that returns a new money object worth the difference of the object whose method was called and the object received as the parameter. If the difference would be negative, the worth of the created money object is set to 0.

NOTICE! If the cents would go under 0, the euros should decrease as well!

Example of all the methods:
```cs
Money money = new Money(100, 00);
Money moreMoney = new Money(500, 50);

Money combined = money.Plus(moreMoney);

Console.WriteLine(money);
Console.WriteLine(moreMoney);
Console.WriteLine(combined);

Money lessMoney = moreMoney.Minus(money);

Console.WriteLine(money);
Console.WriteLine(moreMoney);
Console.WriteLine(lessMoney);

lessMoney = lessMoney.Minus(money);

Console.WriteLine(money);
Console.WriteLine(moreMoney);
Console.WriteLine(lessMoney);

Console.WriteLine(lessMoney.LessThan(moreMoney));
Console.WriteLine(lessMoney.LessThan(money));

lessMoney = lessMoney.Minus(moreMoney);
Console.WriteLine(lessMoney);
```

Prints out

```console
100.00e
500.50e
600.50e
100.00e
500.50e
400.50e
100.00e
500.50e
300.50e
True
False
0.00e
```

# Part 6

## User interfaces

#### Exercise_134

The exercise base contains the **GradeRegister** from the material. In this exercise you will further develop the program, so that it can calculate the average of grades and exam results.

##### Section 1 - Average grade

create the method **public double AverageOfGrades()** for the class **GradeRegister**. It should return the average of the grades, rounded to 2 decimals. If the register contains no grades, the method should return **-1**. Use the **grades** list to calculate the average. Example:

```cs
GradeRegister register = new GradeRegister();
register.AddGradeBasedOnPoints(93);
register.AddGradeBasedOnPoints(91);
register.AddGradeBasedOnPoints(92);
register.AddGradeBasedOnPoints(88);

Console.WriteLine(register.AverageOfGrades());
```

```console
4.75
```

##### Section 2 - Average points

Give the class GradeRegister a new object variable: a list where you will store the exam points every time that the method **AddGradeBasedOnPoints** is called. After this addition, create a method **public double AverageOfPoints()** that calculates and returns the average of the exam points, rounded to 2 decimals. If there are no points added to the register, the method should return the number -1. Example:

```cs
GradeRegister register = new GradeRegister();
register.AddGradeBasedOnPoints(93);
register.AddGradeBasedOnPoints(91);
register.AddGradeBasedOnPoints(92);

Console.WriteLine(register.AverageOfPoints());
```

```console
92
```

##### Section 3 - Prints in the user interface

As a final step, add the methods implemented above as parts of the user interface. When the program prints the grade distribution, it should also print the averages of the points and the grades.

```console
Points:
> 82 
Points:
> 83
Points:
> 96 
Points: 
> 51 
Points:
> 48 
Points:
> 56 
Points:
> 61 
Points:
>

5: * 
4: ** 
3: 
2: * 
1: ** 
0: * 
The average of points: 68.14
The average of grades: 2.43
```

#### Exercise_135

NOTICE! This exercise does **NOT HAVE TESTS**. It is up to you to decide, when the exercise is ready. **I WILL CHECK THEM, SO DON'T CHEat.**

NOTICE 2! This is worth double the points, so 4 in total (2 per section).

The exercise base contains the following program that has been written "in the main".

```cs
using System;
using System.Collections.Generic;

namespace exercise_135
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> jokes = new List<string>();
      Console.WriteLine("What a joke!");

      while (true)
      {
        Console.WriteLine("Commands:");
        Console.WriteLine(" 1 - add a joke");
        Console.WriteLine(" 2 - draw a joke");
        Console.WriteLine(" 3 - list jokes");
        Console.WriteLine(" X - stop");

        string command = Console.ReadLine();

        if (command == "X")
        {
          break;
        }

        if (command == "1")
        {
          Console.WriteLine("Write the joke to be added:");
          string joke = Console.ReadLine();
          jokes.Add(joke);
        }
        else if (command == "2")
        {
          Console.WriteLine("Drawing a joke.");

          if (jokes.Count == 0)
          {
            Console.WriteLine("Jokes are in short supply.");
          }
          else
          {
            Random draw = new Random();
            int index = draw.Next(0, jokes.Count);
            Console.WriteLine(jokes[index]);
          }

        }
        else if (command == "3")
        {
          Console.WriteLine("Printing the jokes.");
          foreach (string joke in jokes)
          {
            Console.WriteLine(joke);
          }
        }
      }
    }
  }
}
```

The application is in practice a storage for jokes. You can add jokes, get a randomized joke, and the stored jokes can be printed. In this exercise the program is divided into parts in a guided manner.

##### Section 1 - Joke manager

Create a class called **JokeManager** and move the functionality to manage jokes in it. The class must have a parameter-free constructor, and the following methods:

* **public void AddJoke(string joke)** - adds a joke to the manager.
* **public string DrawJoke()** - chooses one joke at random and returns it. It there are no jokes stored in the joke manager, the method should return the string "Jokes are in short supply.".
* **public void PrintJokes()** - prints all the jokes stored in the joke manager.

An example of how to use the class:

```cs
JokeManager manager = new JokeManager();
manager.AddJoke("What is red and smells of blue paint? - Red paint.");
manager.AddJoke("What is blue and smells of red paint? - Blue paint.");

Console.WriteLine("Drawing jokes:");
for (int i = 0; i < 5; i++)
{
  Console.WriteLine(manager.DrawJoke());
}

Console.WriteLine("");
Console.WriteLine("Printing jokes:");
manager.PrintJokes();
```

Below is a possible output of the program. Notice that the jokes will probably not be drawn as in this example.

```console
Drawing jokes: 
What is blue and smells of red paint? - Blue paint. 
What is red and smells of blue paint? - Red paint. 
What is blue and smells of red paint? - Blue paint. 
What is blue and smells of red paint? - Blue paint. 
What is blue and smells of red paint? - Blue paint.

Printing jokes: 
What is red and smells of blue paint? - Red paint. 
What is blue and smells of red paint? - Blue paint.
```

##### Section 2 - User Interface

Create a class called **UserInterface** and move the UI functionality of the program there. The class must have a constructor with one parameter: an instance of the JokeManager class. In addition, the class should have the method **public void Start()** that can be used to start the user interface.

The user interface should provide the user with the following commands:

* X - ending: exits the method start.
* 1 - adding: asks the user for the joke to be added to the joke manager, and then adds it.
* 2 - drawing: chooses a random joke from the joke manager and prints it. If there are no jokes in the manager, thi string "Jokes are in short supply." will be printed.
* 3 - printing: prints all the jokes stored in the joke manager.

An example of how to use the UI:

```cs
JokeManager manager = new JokeManager();
UserInterface ui = new UserInterface(manager);
ui.Start();
```

```console
Commands: 
 1 - add a joke 
 2 - draw a joke 
 3 - list jokes
  X - stop 
> 1 
Write the joke to be added:
> Did you hear about the claustrophobic astronaut? -- He just needed a little space. 
Commands:
 1 - add a joke
 2 - draw a joke
 3 - list jokes 
 X - stop 
> 3 
Printing the jokes. 
Did you hear about the claustrophobic astronaut? -- He just needed a little space. 
Commands:
 1 - add a joke
 2 - draw a joke
 3 - list jokes 
 X - stop 
> X
```

## Static

#### Exercise_136

Our template has the **Person** class and some use for it in Main. create a **public static void HowManyNames(Person person)** for the **Main Program**, which prints the name and the amount of names as follows:

```cs
public static void Main(string[] args)
{
  Person ada = new Person("Ada Lovelace");
  Person jack = new Person("Jack The Ripper");
  Person mike = new Person("Mike The Incredible Magic Mouse");

  HowManyNames(ada);
  HowManyNames(jack);
  HowManyNames(mike);
}
```

```console
Ada Lovelace has 2 names.
Jack The Ripper has 3 names.
Mike The Incredible Magic Mouse has 5 names.
```

NOTICE! The **Console.WriteLine** is called from inside the method this time!

#### Exercise_137

Our template has the **Person class** and some use for it in Main. create a **public int HowManyNames()** in the **Person class**, which returns the amount of names a person has, like follows:

```cs
public static void Main(string[] args)
{
  Person ada = new Person("Ada Lovelace");
  Person jack = new Person("Jack The Ripper");
  Person mike = new Person("Mike The Incredible Magic Mouse");

  Console.WriteLine(ada + " has " ada.HowManyNames() + " names.");
  Console.WriteLine(jack + " has " jack.HowManyNames() + " names.");
  Console.WriteLine(mike + " has " mike.HowManyNames() + " names.");
}
```


