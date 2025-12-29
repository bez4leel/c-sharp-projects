using System.Collections;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool appRunning = true;
            SortedList tasks = new SortedList();
            int keyValue = 1;

            while (appRunning) 
            {
                Console.WriteLine("To-Do-List");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. View Task");
                Console.WriteLine("4. Exit");
                Console.Write("Select menu :");
                string menuInput = Console.ReadLine();

                Console.Clear();

                int menuSelection = 0;
                bool isNumber = int.TryParse(menuInput, out menuSelection);


                switch (menuSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Add task: ");
                        string inputTask = Console.ReadLine();
                        tasks.Add(keyValue, inputTask);
                        keyValue++;
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        foreach (DictionaryEntry task in tasks)
                        {
                            Console.WriteLine($"{task.Key}. {task.Value}");
                        }
                        Console.Write("Select task to be removed : ");
                        string inputRemove = Console.ReadLine();
                        int removeSelection = 0;
                        bool isInt = int.TryParse(inputRemove, out removeSelection);
                        tasks.Remove(removeSelection);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        foreach (DictionaryEntry task in tasks)
                        {
                            Console.WriteLine($"{task.Key}. {task.Value}");
                        }
                        Console.Write("Back (press any key)");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        appRunning = false;
                        break;
                }
            }
        }
    }
}
