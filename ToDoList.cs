using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace IdentifiersEx
{
    class Class
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program is made to keep track of school assignments!");

            LinkedList<string[]> todoList = new LinkedList<string[]>(); //Initialize linked list of assignments

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("----------");
                Console.WriteLine("1 - View Tasks");
                Console.WriteLine("2 - Create a Task");
                Console.WriteLine("3 - Remove a Task");
                Console.WriteLine("4 - Exit Program");
                Console.WriteLine("----");

                Console.Write("Enter a number: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice){

                    case 1: //Diplays tasks in terminal
                        viewTasks(todoList);
                        break;

                    case 2: 
                        string[] tempTask = createTask(); //User enters info to create task
                        todoList = addTask(todoList, tempTask); //Task is added to linkedlist and ordered
                        break;

                    case 3: //Allows user to remove task and reorder list 
                        viewTasks(todoList);
                        todoList = removeTask(todoList);
                        break;

                    case 4: //Ends program
                        break;

                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }



            }
            while (choice != 4);

            Console.WriteLine("Goodbye! This will not be saved between sessions until ToDoList 2.0");

            Console.ReadLine();

        }

        static void viewTasks(LinkedList<string[]> todoList) //Displays tasks
        {
            Console.WriteLine(); 
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Num  |  Task   |   Course   |   Due Date");
            Console.WriteLine("========================================");
            //Loops through the linkedlist and displays each task on a new line 
            foreach (string[] entry in todoList) { Console.WriteLine(entry[0] + " | " + entry[1] + " | " + entry[2] + " | " + entry[3]); }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
        
        static string[] createTask() //User creates new task
        {
            
            //User enters task info
            Console.Write("Enter a task: ");
            string task = Console.ReadLine();
            Console.Write("Enter the course: ");
            string course = Console.ReadLine();
            Console.Write("Enter the due date (YYYY-MM-DD): ");
            string due = Console.ReadLine();

            //task number is assigned as placeholder
            string num = "-1";

            //creates task array
            string[] item = new string[] {num, task, course, due};

            //returns task array
            return item;

        }
        
        static LinkedList<string[]> addTask(LinkedList<string[]> todoList, string[] temp) //Task is added to linkedlist and ordered
        {
            LinkedListNode<string[]> current; //linkedlist node is instantiated to represent current node in loop iteration

            foreach (string[] entry in todoList) //loops through linkedlist
            {
                current = todoList.Find(entry); // current node being looked at is assigned to current variable 

                if ((string.Compare(temp[3], entry[3]) == -1))  // if the date of the node being looked at in the linkedlist comes after the node being added
                    //adds node to linkedlist BEFORE current node 
                {
                    todoList.AddBefore(current, temp);
                    break;
                }

                else if (string.Compare(temp[3], entry[3]) == 0) // if date of the node being looked at in the linkedlist is the same date as the ndoe being added 
                    //adds node to linkedlist AFTER current node
                {
                    todoList.AddAfter(current, temp);
                    break;
                }

            }

            if (todoList.Contains(temp) == false) // if node was not added then that means that the date of the node being added is after all of the dates of the nodes in the list 
                //adds node to end of linkedlist (becomes the tail node)
            {
                todoList.AddLast(temp);
            }

            string taskNum = "1"; //instantiates variable to assign task numbers 

            foreach (string[] task in todoList) //loops through linkedlist and updates each array with the new task number
            {
                task[0] = taskNum;
                taskNum = Convert.ToString(Convert.ToInt32(taskNum)+1);
            }

            return todoList;
        }

        static LinkedList<string[]> removeTask(LinkedList<string[]> todoList) //removes task from linkedlist
        {
            Console.Write("Enter task number you wish to remove: ");
            string toRemove = Console.ReadLine(); //user enters number of task they want removed 

            bool delete = false; //boolean instantiated to keep track of whether the target node has been deleted 
            LinkedListNode<string[]> current; //linkedlist node instantiated to keep track of current node being looked at in loop iteration 

            foreach (string[] task in todoList) //loops through linkedlist
            {
                current = todoList.Find(task); // node being looked at in loop is assigned as current node

                if (task[0] == toRemove) //checks to see if the node being looked at has the same task number as the task to be removed 
                    //if yes, it is removed and delete is set to true 
                {
                    todoList.Remove(current);
                    delete = true;
                    break;
                }
  
            }

            if (delete == true) //if node was deleted then the linkedlist is looped through all the tasks are reassigned task numbers
            {
                string taskNum = "1";
                foreach (string[] task in todoList)
                {
                    task[0] = taskNum;
                    taskNum = Convert.ToString(Convert.ToInt32(taskNum) + 1);
                }

                Console.WriteLine("Task removal was successful");
            }
            else //if node was not deleted then an error message is printed to terminal 
            {
                Console.WriteLine("Unable to remove task");
            }

            return todoList;
        }


    }

}
