using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LevelUpLibrary
{
    internal class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        

        private List<Book> Books { get; set; }

        public User(string name, int id)
        {
            Name = name;
            Id = id;
            Books = new List<Book>();
        }

        

        public void ShowBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} {book.BookId}");
            }
        }

        public void AddBook(Book bookToAdd)
        {
            Books.Add(bookToAdd);
        }

        public void ReturnBook(Book bookToReturn)
        {
            Books.Remove(bookToReturn);
        }
    }
}
