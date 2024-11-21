using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ToDo
    {
         string id;
         string name;
         string dueDate;
         int priority;

     public  string Id{ get { return id; } }
     public  string Name { get { return name; } }
        public  string DueDate { get { return dueDate; } }
        public  int Priority { get { return priority; } }
        List<ToDo> Task = new List<ToDo>();
        public void Add(string id, string name, string dueDate, int priority)
        {
            Task.Add(new ToDo { id = id, name = name, dueDate = dueDate, priority = priority });
        }
        public void Edit(string select)
        {
            if (Task.Count == 0)
                Console.WriteLine("there is no task in list");
            else
            {
                Console.WriteLine("what the id of task that you want to edit on?");
                string id = Console.ReadLine();
                int task = 0;
                for (int i = 0; i < Task.Count; i++)
                {
                    if (id == Task[i].id)
                    {
                        task = i;
                        break;
                    }
                }
               
                if (select.Length == 1)
                {
                    if (select == "n")
                    {
                        Console.WriteLine("change it");
                        string change = Console.ReadLine();
                        Task[task].name = change;

                    }
                    else if (select == "d")
                    {
                        Console.WriteLine("change it");
                        string change = Console.ReadLine();
                        Task[task].dueDate = change;
                    }
                    else if (select == "p")
                    {
                        Console.WriteLine("change it");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;
                    }
                }
                else if (select.Length == 2)
                {
                    if (select == "np" || select == "pn")
                    {
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;
                        Console.WriteLine("change priority");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;

                    }
                    else if (select == "nd" || select == "dn")
                    {
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;
                        Console.WriteLine("change it");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;

                    }
                    else if (select == "dp" || select == "pd")
                    {
                        Console.WriteLine("change due date");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;
                        Console.WriteLine("change priority");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;
                    }
                    else if (select == "ni" || select == "in")
                    {
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;

                    }
                    else if (select == "di" || select == "id")
                    {
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change due date");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;

                    }
                    else if (select == "pi" || select == "ip")
                    {
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change priority");
                        int changeP = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = changeP;

                    }
                }
                else if (select.Length == 3)
                {
                    if (select == "ndi")
                    {
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change due date");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;

                    }
                    else if (select == "ndp")
                    {
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;
                        Console.WriteLine("change due date");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;
                        Console.WriteLine("change priority");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;
                    }
                    else if (select == "nip")
                    {
                        Console.WriteLine("change name");
                        string changeN = Console.ReadLine();
                        Task[task].name = changeN;
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change priority");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;
                    }
                    else if (select == "dip")
                    {
                        Console.WriteLine("change due date");
                        string changeD = Console.ReadLine();
                        Task[task].dueDate = changeD;
                        Console.WriteLine("change id");
                        string changeI = Console.ReadLine();
                        Task[task].id = changeI;
                        Console.WriteLine("change priority");
                        int change = Convert.ToInt32(Console.ReadLine());
                        Task[task].priority = change;
                    }
                }
                else if (select.Length == 3)
                {
                    Console.WriteLine("change name");
                    string changeN = Console.ReadLine();
                    Task[task].name = changeN;
                    Console.WriteLine("change id");
                    string changeI = Console.ReadLine();
                    Task[task].id = changeI;
                    Console.WriteLine("change priority");
                    int changeP = Convert.ToInt32(Console.ReadLine());
                    Task[task].priority = changeP;
                    Console.WriteLine("change due date");
                    string changeD = Console.ReadLine();
                    Task[task].dueDate = changeD;
                }
            }
        }
        public bool IsEmpty()
        {
            return (Task.Count == 0);
        }
        public void Delete(int index)
        {
            if (IsEmpty())
                Console.WriteLine("the todo list is empty");
            else
            {
               Task.Remove(Task[index]);  
            }
        }
        public void Serch(string id)
        {
            if (IsEmpty())
                Console.WriteLine("the todo list is empty");

            else 
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    if (id == Task[i].Id)
                    {
                        Console.WriteLine("the Task is found ");
                        Console.WriteLine($"name {Task[i].name} id is {Task[i].Id} due date is {Task[i].DueDate} Priority is {Task[i].Priority}");
                        break;
                    }
                }
                    Console.WriteLine("the task not found!");
            }
        }
        public void DisplayAll()
        {
            if (IsEmpty())
                Console.WriteLine("the todo list is empty");
            else
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    Console.WriteLine($"the task {i} ");
                    Console.WriteLine($"name {Task[i].name} id is {Task[i].Id} due date is {Task[i].DueDate} Priority is {Task[i].Priority}");
                }
            }
        }
        public void Display(int index)
        {
            if (IsEmpty())
                Console.WriteLine("the todo list is empty");
            else if (index > Task.Count)
                Console.WriteLine("the task not found!");
            else
                Console.WriteLine($"name {Task[index].name} id is {Task[index].Id} due date is {Task[index].DueDate} Priority is {Task[index].Priority}");

        }
    }

}
