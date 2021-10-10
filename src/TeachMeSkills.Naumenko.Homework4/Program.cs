namespace TeachMeSkills.Naumenko.Homework4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<ListOfTasks> listOfTasks = new List<ListOfTasks>();
            InputTask(listOfTasks);
            EditTasks(listOfTasks);



        }

        static void InputTask(List<ListOfTasks> listOfTasks)
        {
            bool isStopInput = false;

            do
            {
                Console.WriteLine("\n");
                Console.Write("Input name: ");
                var name = Console.ReadLine();
                Console.Write("Input description: ");
                var description = Console.ReadLine();
                Console.Write("Input status: ");
                var status = Console.ReadLine();

                try
                {
                    var task = new ListOfTasks
                    {
                        Name = name,
                        Description = description,
                        Status = status,
                    };
                    listOfTasks.Add(task);
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                isStopInput = IsStopInput();


            } while (!isStopInput);

            DisplayTasksOnScreen(listOfTasks);   
        }

        static bool IsStopInput()
        {
            Console.WriteLine("\n");
            Console.Write("Stop input? (Press Y/y (Yes) or N/n (No)): ");
            
            var key = Console.ReadKey().Key;
            var isStopInput = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isStopInput = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isStopInput = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isStopInput;
        }

        static bool IsShowTasks()
        {
            Console.WriteLine("\n");
            Console.Write("Show tasks? (Press Y/y (Yes) or N/n (No)): ");
            
            var key = Console.ReadKey().Key;
            var isShowTasks = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isShowTasks = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isShowTasks = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isShowTasks;
        }

        static void DisplayTasksOnScreen(List<ListOfTasks> listOfTasks)
        {
            if (IsShowTasks() == true)
            {
                foreach (var task in listOfTasks)
                {
                    task.TaskDisplay();
                }
            }
        }

        static bool IsEditTasks()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to edit tasks? (Press Y/y (Yes) or N/n (No)): ");

            var key = Console.ReadKey().Key;
            var isEditTasks = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    isEditTasks = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    isEditTasks = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return isEditTasks;
        }

        static void EditTasks(List<ListOfTasks> listOfTasks)
        {
            while (IsEditTasks())
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Select ID to edit:\n");

                foreach (var task in listOfTasks)
                {
                    Console.WriteLine($"{task.GetId()}");
                }

                Console.WriteLine("Input ID to edit the task");
                var inputUserId = Console.ReadLine();

                foreach (var task in listOfTasks)
                {
                    if(task.GetId() == inputUserId.ToUpperInvariant())
                    {
                        EditProperties(task.GetId(), listOfTasks);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect ID. Try again ");
                    }
                }
            }
        }

        static void EditProperties(string taskId, List<ListOfTasks> listOfTasks)
        {
            foreach (var task in listOfTasks)
            {
                if (task.GetId() == taskId)
                {
                    Console.WriteLine("\n");
                    Console.Write("Input name: ");
                    var name = Console.ReadLine();
                    Console.Write("Input description: ");
                    var description = Console.ReadLine();
                    Console.Write("Input status: ");
                    var status = Console.ReadLine();

                    task.Name = name;
                    task.Description = description;
                    task.Status = status;
                }                
            }

            DisplayTasksOnScreen(listOfTasks);
        }
    }
}


