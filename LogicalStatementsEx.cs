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

            int x = 5; 
            
            // one-condition if/else 

            if (x > 4)
            {
                Console.WriteLine("5 is greater than 4");
            }
            else
            {
                Console.WriteLine("5 is less than 4");
            }


            // multi-condition if/else 

            if (x > 4 && x < 6)
            {
                Console.WriteLine("5 is greater than 4 and less than 6");
            }
            else
            {
                Console.WriteLine("5 is less than 4 and greater than 6");
            }


            // if/else/else if 

            if (x < 1)
            {
                Console.WriteLine("5 is less than 1");
            }
            else if (x < 6)
            {
                Console.WriteLine("5 is less than 6");
            }
            else
            {
                Console.WriteLine("5 is greater than 1 and greater than 6");
            }


            // short-circuit 

            if (x < 4 && Example1())
            {
                Console.WriteLine("If the program short circuits, then the code in the Example 1 method should NOT execute");
            }
            else
            {
                Console.WriteLine("If this program short circuits, then only this string will output to the terminal (and not the string in the Example 1 method)");
            }

            ///// Using a single ampersand will circumvent short circuiting
            if (x < 4 & Example1())
            {
                Console.WriteLine("If the program short circuits, then the code in the Example 1 method should NOT execute");
            }
            else
            {
                Console.WriteLine("If this program short circuits, then only this string will output to the terminal (and not the string in the Example 1 method)");
            }


            // switch-case 

            int ex = 3;
            switch (ex)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2: 
                    Console.WriteLine("Two");
                    break;
                case 3: 
                    Console.WriteLine("Three");
                    break;
                case 4: 
                    Console.WriteLine("Four");
                    
                    break;
            }


            Console.ReadLine();
         

        }

        static bool Example1()
        {
            Console.WriteLine("The program went into example 1");
            return true;           
        }
    }
}