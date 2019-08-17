﻿using System;
using System.Linq;
using LinqTutorial;

namespace Interview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var averagePrice = books.Average(b => b.Price);
            var totalPrice = books.Sum(b => b.Price);

            Console.WriteLine("Max Price: {0}, Min Price: {1}, Average Price: {2} Total Price: {3}", maxPrice, minPrice, averagePrice, totalPrice);

            Console.ReadLine();
        }
    }
}
