namespace ToDoList
{
    class TodoList
    {
        private List<Task> tasks;

        public TodoList()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string description, string details)
        {
            Task newTask = new(description, details);
            tasks.Add(newTask);
            Console.Clear();
            Console.WriteLine("Oppgave lagt til: " + description);
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                string deletedTask = tasks[index].Description;
                tasks.RemoveAt(index);
                Console.WriteLine("Oppgave slettet: " + deletedTask);
            }
            else
            {
                Console.WriteLine("Ugyldig oppgaveindeks");
            }
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Todo-liste:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Description}");
            }
        }

        public void ViewTaskDetails(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                Console.WriteLine($"Oppgavedetaljer for {tasks[index].Description}:");
                Console.WriteLine($"Beskrivelse: {tasks[index].Description}");
                Console.WriteLine($"Detaljer: {tasks[index].Details}");
            }
            else
            {
                Console.WriteLine("Ugyldig oppgaveindeks");
            }
        }
    }
}