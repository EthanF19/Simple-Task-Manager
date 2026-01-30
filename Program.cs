using System;
using System.ComponentModel;

class TaskItem
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}

class Program
{
    static void Main()
    {
        List<TaskItem> tasks = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add new Task");
            Console.WriteLine("2. View all Tasks");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter new task description: ");
                    string desc = Console.ReadLine();
                    tasks.Add(new TaskItem { Description = desc });
                    break;
                case "2":
                    foreach (TaskItem item in tasks)
                    {
                        Console.WriteLine($"{item.Description}.");
                        
                    }
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}