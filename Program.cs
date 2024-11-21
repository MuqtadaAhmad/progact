using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char operation = 'o';
            ToDo Task = new ToDo();
            while (operation != 'E')
            {
                Console.WriteLine("C for create Task ");
                Console.WriteLine("e for for editing on a task ");
                Console.WriteLine("D fot delete Task");
                Console.WriteLine("E fot end todo list");
                Console.WriteLine("s fot display todo list");
                Console.WriteLine("I for display specific task");
                operation = Convert.ToChar(Console.ReadLine());
                if (operation == 'C')
                {
                    Console.WriteLine("id of task");
                    string id = Console.ReadLine();
                    Console.WriteLine("name of task");
                    string name = Console.ReadLine();
                    Console.WriteLine("due date of task");
                    string date = Console.ReadLine();
                    Console.WriteLine("priority of task");
                    int priority = Convert.ToInt32(Console.ReadLine());
                    Task.Add(id, name, date, priority);
                }
                else if (operation == 'e')
                {
                  
                    Console.WriteLine("what you want change ?");
                    Console.WriteLine("n for name");
                    Console.WriteLine("d for due date");
                    Console.WriteLine("i for due id");
                    Console.WriteLine("p for  priority");
                    Console.WriteLine("if you want multiple selection select select them                      Ex:nd ");
                    Console.WriteLine("A for  change all");
                   string change= Console.ReadLine();
                    Task.Edit(change);
                }
                if (operation == 'D')
                {
                    Console.WriteLine("which Task you want delete? Enter the index  ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Task.Delete(index);
                }

                if (operation == 's')
                {
                    Task.DisplayAll();
                }
                if (operation == 'l')
                {
                    Console.WriteLine("Choose the the task");
                    int task = Convert.ToInt32(Console.ReadLine());
                    
                    Task.Display(task);
                }
            }



        }
    }
}
