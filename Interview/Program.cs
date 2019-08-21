using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial;

namespace Interview
{
    public class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            //var books = new List<Book>
            //{
            //    new Book() {Title="Book1", Price=15},
            //    new Book() {Title="Book2", Price=20}
            //};

            var books = new BookRepository().GetBooks();

            // LINQ query
            var cheapBooks = books
                .Where(b => b.Price > 10 && b.Price < 15)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            // LINQ method query
            var cheapBooks2 = from book in books
                              where book.Price < 15
                              && book.Price > 10
                              orderby book.Title
                              select book;

            // OrderBy
            var orderedBooks = books.OrderBy(b => b.Title);

            // First
            var lastBook = books.LastOrDefault(b => b.Price == 9.99f);
            Console.WriteLine(lastBook.Title);

            foreach (var book in orderedBooks)
            {
                Console.WriteLine($"{book.Title} {book.Price:C}");
            }

           
            //var maxPrice = books.Max(b => b.Price);
            //var minPrice = books.Min(b => b.Price);
            //var averagePrice = books.Average(b => b.Price);
            //var totalPrice = books.Sum(b => b.Price);

            //Console.WriteLine($"{maxPrice}, {minPrice}, {averagePrice}, {totalPrice}");

            //var names = new List<string> { "Abdu", "Hayat", "Hanan" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine( $"Hello {name.ToUpper()}");
            //}

            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

            Console.WriteLine(messages[302]);
            */

            List<Todos> todos = new List<Todos>()
            {
                new Todos {Description="Interview Prep", EstimatedHours=12, Status=Status.InProgress},
                new Todos {Description="CSharp Material", EstimatedHours=2, Status=Status.InProgress},
                new Todos {Description="Powershell Recap", EstimatedHours=4, Status=Status.NotStarted},
                new Todos {Description="Advanced CSS Udemy Course", EstimatedHours=12, Status=Status.InProgress},
                new Todos {Description="Javascripti Udemy Course", EstimatedHours=24, Status=Status.NotStarted},
                new Todos {Description="Basic CSS and HTML Course", EstimatedHours=0, Status=Status.Completed}
            };

            Todos.PrintTodosStatusUpdate(todos);
            Console.ReadLine();
        }
    }
}
