namespace TeachMeSkills.Naumenko.Homework4
{
    internal class ListOfTasks
    {
        string Id = Guid.NewGuid().ToString().ToUpper().Substring(0, 3);
        DateTime DateTimeTask = DateTime.Now;

        public string GetId()
        {
             return Id;   
        }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public void TaskDisplay()
        {
            Console.WriteLine("\n");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Date of creation: {DateTimeTask}");
        }
    }
}