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
                Console.Write("Input name: ");
                var name = Console.ReadLine();
                Console.Write("Input description: ");
                var description = Console.ReadLine();
                Console.Write("Input status: ");
                var status = Console.ReadLine();

                var task = new ListOfTasks
                {
                    Name = name,
                    Description = description,
                    Status = status,
                };

                listOfTasks.Add(task);


                stopInput = StopInput();


            } while (!stopInput);
        }

        static bool StopInput()
        {
            Console.Write("Stop input? (Press Y/y (Yes) or N/n (No)): ");
            var key = ConsoleKey.N;
            var stopInput = false;

            while (key != ConsoleKey.Y)
            {
                key = Console.ReadKey().Key;
                Console.WriteLine("\n");

                if (key == ConsoleKey.Y)
                {
                    stopInput = true;
                }
                else if (key == ConsoleKey.N)
                {
                    stopInput = false;
                }
                else
                {
                    Console.WriteLine("Incorrect value. Press Y/y (Yes) or N/n (No) ");
                }
            }

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


