using ToDoList;

class Program
{
    static void Main()
    {
        TodoList todoList = new();
        bool letLoopRun = true;
        bool firstRun = true;

        while (letLoopRun)
        {
            if(firstRun) Console.WriteLine("Velkommen til oppgavelisten");
            firstRun = false;
            Console.WriteLine("Trykk 1 for å legge til oppgave");
            Console.WriteLine("Trykk 2 for å slette oppgave");
            Console.WriteLine("Trykk 3 for å vise oppgaveliste");
            Console.WriteLine("Trykk 4 for å vise oppgavedetalje");
            Console.WriteLine("Trykk 5 for å avslutte");

            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Beskriv oppgaven: ");
                    var description = Console.ReadLine();
                    Console.Write("Detaljer: ");
                    var details = Console.ReadLine();
                    if (!string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(details)) {
                        todoList.AddTask(description, details);
                    }
                    break;
                case 2:
                    Console.Write("Skriv inn indeksen til oppgaven du vil slette: ");
                    int deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    todoList.DeleteTask(deleteIndex);
                    break;
                case 3:
                    todoList.DisplayTasks();
                    break;
                case 4:
                    Console.Write("Skriv inn indeksen til oppgaven du vil se detaljer for: ");
                    int viewIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    todoList.ViewTaskDetails(viewIndex);
                    break;
                case 5:
                    letLoopRun = false;
                    break;
                default:
                    Console.WriteLine("Ugyldig valg. Prøv igjen.");
                    break;
            }
        }
    }
}