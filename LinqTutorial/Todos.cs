using System;
using System.Collections.Generic;

namespace LinqTutorial
{
    public class Todos
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }

        public static void PrintTodosStatusUpdate(List<Todos> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Description: {todo.Description} Estimated Hours: {todo.EstimatedHours}");
            }
        }
       
    }
}