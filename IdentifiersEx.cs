using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IdentifiersEx
{
    class Class
    {
        static void Main(string[] args)
        {

            // Some common data types: 
            


            // Numeric Types 

            // Integer
            int wholeNumber = 9;
            Console.WriteLine(wholeNumber);

            // Float (Decimal)
            float Decimal = 50.9F;
            Console.WriteLine(Decimal);

            // Long 
            long bigNumber = 1234567898765434567;
            Console.WriteLine(bigNumber);

            // Double 
            double Decimal_2 = 4567890.4567876567;
            Console.WriteLine(Decimal_2);



            // Character Types 

            // String
            string name = "Sam";
            Console.WriteLine(name);

            // Character 
            char grade = 'A';
            Console.WriteLine(grade);



            // Other 

            // Boolean
            bool Question_2 = true;
            Console.WriteLine(Question_2);

            // Array
            string[] Groceries = new string[] { "Apple", "Banana", "Cherry"};
            foreach (string grocery in Groceries)
            {
                Console.WriteLine(grocery);
            }
              // Arrays can only store the same data type throughout which is 
              //  known at its declaration (string[] can only hold strings) 
              // Unless the array is declared as a dynamic array 

            // Dictionary
            Dictionary<string, int> IDs = new Dictionary<string, int>();
            IDs.Add("Alex", 100);
            IDs.Add("Sasha", 200);
            IDs.Add("Shawn", 300);
            IDs.ToList().ForEach(x => Console.WriteLine(x.Key));


            Console.ReadLine();



            // Operations 

            // Arithmetic 
            int a = 3;
            int b = 4;

            Console.WriteLine(a + b); // addition
            Console.WriteLine(a - b); // subtraction 
            Console.WriteLine(a * b); // multiplication 
            Console.WriteLine(a / b); // division
            Console.WriteLine(a % b); // remainder

            // String 
            string c = "Hello";
            string d = "World";

            Console.WriteLine(c + d); // concatenation 


            // Operations cannot be between mixed data types 

            // Console.WriteLine(a + c); -> will result in a build error
            // Need to convert to the same data type if possible 

            Console.WriteLine(a.ToString() + c); // int + string -> string + string 

            // You can perform operations between numeric data types
            double e = 4.5;
            Console.WriteLine(a + e); // Outputs a double 
            Console.WriteLine(a / e); // Outputs a double 




            Console.ReadLine();






        }
    }
}
