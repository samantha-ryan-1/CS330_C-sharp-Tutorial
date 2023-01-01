# CS330 C# Tutorial
A repository for my Structure and Organization of Programming Languages course where I will explore C#.

### NOTE: Examples of everything described below can be found in other files within this repository

## History
C# was created in 2000 by Anders Hejlsberg, a Microsoft employee[^1]. It was developed as the need for web applications that could create high-performance software rose[^2], and as Microsoft aimed to compete with Java and corner more of the software market. It is a multi-purpose language that has been used to create software such as mobile and desktop apps, cloud-based services, etc. - though it is mainly used for Windows applcaitions, games, and website development. Examples include Windows Installer XML, Paint.NET, and OpenRA[^1]. More info can be found at sites such as, [Microsoft](https://dotnet.microsoft.com/en-us/learn/csharp), [GeeksForGeeks](https://www.geeksforgeeks.org/csharp-programming-language/), and [w3schools](https://www.w3schools.com/cs/index.php).  


## Getting Started
While different programming environments can be used, Visual Studio IDE is recommended as it shares the same parent company as the C# language (Microsoft) and has more built-in support for running C# programs. 
- To install it, you can go [here](https://visualstudio.microsoft.com/downloads/) and download the Community version of the IDE. 
  - While installing, make sure to select “.NET desktop development” as a feature you want included in the installation; this is the tool that will build and run C# code[^3]. 
- Once you have the IDE installed, select “create a new project” and choose to create a “console app” 
  - This will allow you to create applications that run in and can take input from the command line
- Once you have set this all up the IDE will open a file for you which you can write code in 
  - The program may already come with a template that includes a namespace declaration (a container for classes and other namespaces), a class declaration (a container for data and methods), and a Main method declaration (the entry point for the computer to run the program from) - all of this can be left in
- To start with a simple program such as Hello World, add a Console.WriteLine command (this will output text to the command line) and a Console.ReadLine command (this will pause the program to wait for user input from the command line) as shown below. When you are ready to run, hit the play button near the top of the IDE and your code will be compiled and run in a popup command line. 

```
namespace Hello 
{
    class HelloWorld 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!"); //writes Hello World to the terminal
            Console.ReadLine(); //pauses program to wait for user input
        }
    }
}

```

- There are two ways to add comments - single-line comments can be written by including an “//” at the start of the line, or multi-line comments can be written by encasing the lines with a “/*” the beginning and a “*/” at the end [^4]. 
```
// This is a single-line comment 

/* This is 
   a multi-line 
   comment */
```


## Naming Conventions
Naming identifiers in C# is rather straightforward - the identifier must begin with either a letter, underscore, or at symbol, and the rest of the identifier can include any digits, letters, or the underscore symbol. Any whitespace or characters other than the above mentioned are valid in identifier names[^5].  
C# has 79 keywords (such as “as”, “double”, “public”, “int”, etc.) that hold special meanings in the language and cannot be used as identifier names - EXCEPT when they are preceded by an at symbol. An extensive list can be found [here](https://www.programiz.com/csharp-programming/keywords-identifiers#:~:text=Besides%20regular%20keywords%2C%20C%23%20has,as%20identifiers%20outside%20that%20context.) 
C# also has 25 contextual keywords, which have specific meanings within certain contexts (such as “add”, “group”, “value”, “var”, etc.) Outside of these contexts, these keywords can be used as identifier names without the at symbol. An extensive list can be found [here](https://www.programiz.com/csharp-programming/keywords-identifiers#:~:text=Besides%20regular%20keywords%2C%20C%23%20has,as%20identifiers%20outside%20that%20context.) 
It is important to note that identifier names are case sensitive[^5]. 


## Data Types
The most common data types are:[^6] 
* Number types
  * Int - used for whole numbers 
  * Long - used for whole numbers (includes a wide range of numbers) 
  * Float - used for fractions 
  * Double - used for fractions (includes a wider range of decimal digits) 
* Bool - true and false 
* Char - single characters 
* String - character sequences 

As C# is a strongly and statically typed language, variable data types are declared within the code and must be known at compile time (as they are bound by type at compile time). They cannot be changed later on in the code (i.e., cannot store a string in a variable that was declared as an integer) unless the variable is converted into a different valid data type (i.e. int sum = 6 can be converted into a variable that holds the string “6”)[^7]. 
Though there is a notable exception - identifiers instantiated with the dynamic variable type can be changed throughout the program as the data type does not need to be known until runtime[^7].
All built-in variable types are mutable by default - they can be changed through the reference type through specific modifiers (such as using stringbuilder on a string)[^8]. 


## Operators
The math data types can use arithmetic operators 
* Division -> /
* Multiplication -> *
* Addition -> +
* Subtraction -> -
* Remainder -> %

The string data types can use the + for concatenation. 
Mixed type operations are not allowed and data types must be converted to the same data type (if possible) to use operators between them.


## Complex Data Types
Some more complex data types are:[^9] 
* Arrays - a list with a set number of items 
  * Can only store one data type (unless a dynamic list) 
* Dictionaries - stores key value pairs 
* Enumerations - a value type that has a set of named constants that it can be equal to[^10]


## Booleans
An important data type is note is the boolean data type - the boolean values in C# are “true” or “false” (starting with lowercase letters)[^11]. Boolean variables are declared with the “bool” keyword. 


## Selection Statements
If you want to run a code block only when a certain condition is met, then you can use the selection statements if, else, and else if[^12]. They are set up in the following format: 

```
if (conditionalStatement){
   statement;
   }
else if (conditionalStatement){ // Optional else-if; can have more than one
   statement;
   }
else{ // Optional else 
   statement;
   }
```

The code inside of each statement is delimited in curly brackets. If the code in the if or else if conditional statement is true, then the code block under that statement runs. Otherwise, the code in the else statement (if it is included) runs instead. In an if/else statement, the else if and else are optional BUT if included must be in the order if -> else if -> else. Multiple else if statements can be included but only one if and else statement will count towards the whole selection statement - if more than one if statement is included, then a new selection statement is started. 
Further, C# associates else statements with the closest if statement[^13] as to prevent misinterpretation of the logic trees created from if/else statements. 

C# also supports short-circuiting. If a selection statement includes two conditional statements, and they use the logical operators && (and) or || (or), then the program will only check the conditional statements one at a time. For example, if the first conditional statement in an “and” selection statement evaluates to be False, then the program will not check the state of the second conditional statement as the first conditional statement already stops the following code block from executing. 
However, if the logical operators & (and) or | (or) are used, then the program will not use short circuiting[^14].

C# also support use of the switch statement, which will run specific blocks of code depending on the condition (the case) (much like an if/else statement). In each case statement, a break statement must be included at the end of the code block to exit the case statement[^15].  


## Loops
When you want to run the same block of code over and over again, instead of manually typing it out you can use a loop to repeat the execution of certain pieces of code until a condition is met. C# supports three types of loops[^16]: 
* While - loops code until a condition is met (which is tested before each loop interaction execution) 
* For - loops code for a predetermined number of iterations 
* Do While - much like a While loops it loops code until a condition is met, but it testes the loop condition at the end of each iteration; this ensures that the code block inside the loop is executed at least once[^17]  
Loops (of different or the same types) can also be nested inside of one another.  


## Functions
When you have a code block that you want to be able to repeat multiple times throughout the code you can use a function, which will allow you to refer to and execute certain code at different points in your program (as long as you call it). Functions are declared inside of classes[^18], and the syntax is as follows: 

```
<modifiers> <return type> <method name>(parameter list){}
```

* Modifiers - (async, unsafe, static, or extern) are used to modify declarations of types. 
* Return Type - specifies the data type of the value that is sent back to where the function was called. If no value is returned, then the keyword “void” is used.
  * Functions can not return multiple values at once in C#. Instead, data types such as tuples and arrays (containing multiple items) can be returned as a workaround[^19]. 
* Method Name - is the name of the function, and aside from using the same standard naming conventions as identifiers it is also common practice to use PascalCase. 
* Parameter List - is the list of arguments/values that is sent into the function. If no parameters are taken in, then an empty set of parentheses are used. 
  * Functions can return multiple parameters of different types as well[^20] 
Local functions are private and therefore do not use access modifiers[^21]. 

C# is both a pass-by-reference and pass-by-value language. This means that when values are passed into functions through the parameter list, either the reference (place in memory) that the value is stored at is passed to the function (pass-by-reference) or the value itself (not the actual value at the place in memory but instead a copy of that value) is passed in. 
By default, C# uses pass-by-value (so for example, if the variable “sum” that holds the int value 5 is passed in to a function and stored in a new variable “sum2”, the value in sum2 is a different value 5 than the value 5 in sum rather than being the same value 5). However, if the ref keyword is used then C# will use pass-by-reference[^22].  

C# utilizes both the stack and the heap - local variables are stored on the stack, while objects of reference type variables are stored on the heap[^23]. 

Local variables are stored on the stack because of their limited scope, depending on where the variable is initialized[^24]: 
* Class level scope - variables that are initialized inside of a class and outside of any method; they can be accessed anywhere within the class
* Method level scope - variables that are initialized inside of a method; can be accessed anywhere within that method 
* Block level scope - variables that are initialized inside code blocks such as for and while statements; can only be accessed within the body of the statement that they are declared in 

Functions can also be recursive[^25], meaning that a function can be called within itself.

  
## Side Effects
Side effects can occur when the state of something is changed outside of its scope. This can lead to holes in the program where a variable or object is changed in one place locally, but is not changed in a global way. Many practices can be implemented to prevent these, such as (but not limited to): 
Returning new states from functions instead of modifying existing states within functions - this will ensure the states are changed outside of functions instead of just within functions 
Making objects immutable (which is possible with the readonly keyword) - this will ensure that the only way to change a property is to replace that object with a new one that contains the change[^26].

  
## Objects
C# also supports objects, which are instances of a particular class that have their own methods (functions) and fields (data variables)[^27]. They are useful for creating multiple structures that all store the same type of information, but different specific information (for example, a Student can be a class where each object, or each student, has a name field, ID field, date of birth field, etc.). Naming conventions for objects, class, etc. follow the same criteria as naming identifiers, and it is good practice to use PascalCase[^28]. 

C# does not have many standard methods, but a common method to include is the class constructor method which is used to initialize the fields of an object upon its creation[^29].  
Class Inheritance
Class inheritance is also supported in C#, where a class (the child or derived class) can “inherit”, or borrow methods and from another class (the parent or base class)[^30]. C# does not support multiple inheritance (on class inheriting from multiple classes)[^31]. If a base class and derived class each have a method with the same name, then either an override modifier (which will use the method from the parent/base class) or new modifier (which will use the method from the child/derived class) is needed[^32]. 

  
 
 
 
 
[^1]: https://www.pluralsight.com/blog/software-development/everything-you-need-to-know-about-c-?exp=3
[^2]: https://www.bairesdev.com/technologies/csharp/#:~:text=Developed%20by%20Microsoft%20in%202000,putting%20out%20high%2Dperformance%20software.
[^3]: https://www.youtube.com/watch?v=GhQdlIFylQ8
[^4]: https://www.w3schools.com/cs/cs_comments.php
[^5]: https://www.programiz.com/csharp-programming/keywords-identifiers#:~:text=Besides%20regular%20keywords%2C%20C%23%20has,as%20identifiers%20outside%20that%20context.
[^6]: https://www.w3schools.com/cs/cs_data_types.php
[^7]: https://www.c-sharpcorner.com/UploadFile/mahesh/dynamic-keyword-in-C-Sharp/#:~:text=The%20dynamic%20keyword%20is%20used,errors%20are%20thrown%20at%20runtime.
[^8]: https://www.techopedia.com/definition/25628/mutable-type-c#:~:text=All%20built%2Din%20value%20types,C%23%20compiler%20generates%20a%20warning.
[^9]: https://medium.com/@ibrahimyengue/complex-data-structure-and-some-advance-concept-in-c-3f865a51a19c#:~:text=In%20C%23%2C%20we%20do%20have,fix%20set%20of%20possible%20values. 
[^10]: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum 
[^11]: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool
[^12]: https://www.w3schools.com/cs/cs_conditions.php
[^13]: https://www.cs.csub.edu/~melissa/cs350-f15/notes/notes08.html
[^14]: https://www.c-sharpcorner.com/article/short-circuit-evaluation-in-c-sharp/  
[^15]: https://www.w3schools.com/cs/cs_switch.php
[^16]: https://www.tutorialspoint.com/csharp/csharp_loops.html 
[^17]: https://www.tutorialsteacher.com/csharp/csharp-do-while-loop 
[^18]: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions
[^19]: https://www.c-sharpcorner.com/UploadFile/9b86d4/how-to-return-multiple-values-from-a-function-in-C-Sharp/ 
[^20]: https://www.w3schools.com/cs/cs_method_parameters.php 
[^21]: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions 
[^22]: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters#pass-a-value-type-by-value
[^23]: https://endjin.com/blog/2022/07/understanding-the-stack-and-heap-in-csharp-dotnet#:~:text=Again%3A%20C%23%20variables%20are%20stored,are%20stored%20on%20the%20stack.
[^24]: https://www.geeksforgeeks.org/scope-of-variables-in-c-sharp/
[^25]: https://tutorialslink.com/Articles/What-is-Recursion-in-Csharp-Csharp-Tutorials/2346#:~:text=C%23%20%7C%20C%23%20Tutorials-,The%20recursive%20function%20or%20method%20is%20a%20very%20strong%20functionality,known%20as%20a%20recursive%20function.
[^26]: https://dev.to/htissink/zen-and-functional-c-3mo3 
[^27]: https://www.w3schools.com/cs/cs_classes.php 
[^28]: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions 
[^29]: https://www.w3schools.com/cs/cs_constructors.php
[^30]: https://www.w3schools.com/cs/cs_inheritance.php
[^31]: https://www.geeksforgeeks.org/c-sharp-multiple-inheritance-using-interfaces/
[^32]: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords 
