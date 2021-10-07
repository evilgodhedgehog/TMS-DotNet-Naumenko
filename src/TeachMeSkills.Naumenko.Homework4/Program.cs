namespace TeachMeSkills.Naumenko.Homework4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<ListOfTasks> listOfTasks = new List<ListOfTasks>();
            InputTask(listOfTasks);
            ShowTasks(listOfTasks);
        }

        static void InputTask(List<ListOfTasks> listOfTasks)
        {
            bool stopInput = false;

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

                stopInput = StopInput();


            } while (!stopInput);
        }

        static bool StopInput()
        {
            Console.Write("Stop input? (Press Y/y (Yes) or N/n (No)): ");
            Console.WriteLine("\n");
            var key = Console.ReadKey().Key;
            var stopInput = false;

            do
            {
                if (key == ConsoleKey.Y)
                {
                    stopInput = true;
                    break;
                }
                else if (key == ConsoleKey.N)
                {
                    stopInput = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                    key = Console.ReadKey().Key;
                }
            } while (key != ConsoleKey.Y || key != ConsoleKey.N);

            return stopInput;
        }

        static void ShowTasks(List<ListOfTasks> listOfTasks)
        {
            foreach (var task in listOfTasks)
            {
                task.TaskDisplay();
                Console.WriteLine("\n");
            }
        }
    }
}


