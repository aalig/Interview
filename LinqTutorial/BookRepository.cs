using System.Collections;
using System.Collections.Generic;

namespace LinqTutorial
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "HTML Crash Course", Price = 5.99f},
                new Book() {Title = "CSS Crash Course", Price = 9.99f},
                new Book() {Title = "Basic CSharp Course", Price = 9.99f},
                new Book() {Title = "Intermediate CSharp Course", Price = 14.99f},
                new Book() {Title = "Advanced CSharp Course", Price = 19.99f}
            };
        }
    }
}