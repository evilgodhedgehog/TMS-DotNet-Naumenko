namespace TeachMeSkills.Naumenko.Homework4
{
    internal class ListOfTasks
    {
        DateTime DateTimeTask = DateTime.Now;
        string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 3);
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public void TaskDisplay()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Date of creation: {DateTimeTask}");
        }
    }
}