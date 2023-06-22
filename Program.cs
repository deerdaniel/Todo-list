using TodoList;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Todo> tasksList = new();

        while(true)
        {
            ConsoleKeyInfo option;

            MenuUI.PrintMenu();
            option = ReadKey();

            switch (option.Key)
            {
                //Add task
                case ConsoleKey.D1:
                    string? name;

                    name = ReadLine();
                    tasksList.Add(new Todo(name));
                    break;
            }

            Clear();
        }
        
    }
}