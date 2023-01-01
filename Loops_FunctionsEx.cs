using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace
{
    class Class
    {
        static void Main(string[] args)
        {

            // For loop - loops codeblock a predetermined number of times 

            for (int i = 0; i < 10; i++) 
                // i = 0 is the value of the variable i at the start of the loop 
                // i < 10 is the condition that must be met for the loop to break 
                // i++ means that the value of i will be incremented by 1 at the beginning of each loop iteration
            {
                Console.WriteLine(i);
            }


            // While loop - loops codeblock while a condition is met
            // The condition is checked at the beginning of each loop iteration

            int ex = 4; 
            while (ex < 10) // loop will run while ex is less than 10 
            {
                Console.WriteLine(ex);
                ex++; // the variable is incremented during each loop iteration to eventually break the loop 
            }


            // Do While loop - the same as the while loop except the condition is checked at the end of each loop iteration 
            // ensures that the codeblock will run at least once 

            int ex2 = 3;
            do
            {
                Console.WriteLine(ex2);
                ex2++;
            }
            while (ex2 < 7);


            // foreach loop - loops through arrays to handle each item at a time 

            string[] letters = new string[] { "A", "B", "C" };
            foreach (string l in letters)
            {
                Console.WriteLine(l);
            }






            // Functions
            int a = 3;
            int b = 4; 
            int multiplyExample = multiply(ref a, ref b);
            Console.WriteLine(multiplyExample); // sends in two values and the product is returned an outputted to the termianl 
            // use pass-by-reference to demonstrate that it can be done but must explicitly use ref keyword for value types 

            int c = 4;
            int factorialExample = factorial(c);
            Console.WriteLine(factorialExample); // sends in a value and the factorial of it is returned - achieved through use of recursive functions 
            // pass-by-value to demonstrate that it c# is pass-by-value by default for value types 

            string UserStr;
            Console.Write("Enter a two-word phrase: "); 
            UserStr = Console.ReadLine();

            string[] splitExVar = SplitEx(UserStr);
            foreach (string word in splitExVar)
            {
                Console.WriteLine(word);
            }


            Console.ReadLine();

        }

        static int multiply(ref int a,ref int b) // return type int is specified in the declaration; the data types of the parameters are also specified
        {
            //Using pass-by-reference in this function: the reference to where the values are stored in memory are passed into the function  
            return a * b; // returns the product of the two values sent in 
        }


        static int factorial(int c) 
        {
            if (c != 0)
            {
                return c * factorial(c - 1); // recursive function - calls itself 
            }
            return 1;
        }

        static string[] SplitEx(string phrase)
        {
            string[] splitUp = phrase.Split(' ');
            return splitUp; //need to return an array of values as C# does not allow for multiple values to be returned
        }
    }
}