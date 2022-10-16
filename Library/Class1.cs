using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LevelUpLibrary
{
    class Library
    {
        private List<User> ListOfPatrons { get; set; }
        private List<Book> ListOfBooks { get; set; }
        private User currentUser;
        
        public Library()
        {
            currentUser = new User("Alicia", 0);

            ListOfPatrons = new List<User>();
            ListOfPatrons.Add(new User("Raphael", 1));
            ListOfPatrons.Add(new User("Massimo", 2));
            ListOfPatrons.Add(new User("Claire", 3));

            while(true)
            {
                PrintMenu();
                var userInput = Console.ReadLine();
                HandleMenuOption(userInput);
            }


        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"BookId: {BookId}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Pages: {Pages}");
            ShowBooks();
        }

        public void ShowBooks()
        {
            foreach (var book in ListOfBooks)
            {
                Console.WriteLine($"{book.Title} {book.Author}");
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("Welcome to Library Of Growth");
            Console.WriteLine("1. Find and add book");
            Console.WriteLine("2. Return book");
            Console.WriteLine("3. Print books");
            Console.WriteLine("4. Show book info");
        }

        private void HandleMenuOption(string menuOption)
        {
            if(menuOption == "1")
            {
                Console.WriteLine("MenuOption 1: Find and add book");
                ShowBooks();
                Console.WriteLine("Please choose the id of the book you want to add");
                var chosenBookId = Console.ReadLine();
                var bookInfo = GetBookInfo(chosenBookId);
                currentUser.AddBook(bookInfo);
            }

            if(menuOption == "2")
            {
                currentUser.ShowBooks();
                Console.WriteLine("Choose which book to return: ");
                var bookId = Console.ReadLine();
                var bookToReturn = GetBookInfo(bookId);
                currentUser.ReturnBook(bookToReturn);
            }

            if(menuOption == "3")
            {
                currentUser.ShowBooks();
            }

            if(menuOption == "4")
            {
                currentUser.ShowBooks();
                var bookId = Console.ReadLine();
                var bookInfo = GetBookInfo(bookId);
                bookInfo.PrintBookInfo();
            }
        }

        private Book GetBookInfo(string bookId)
        {
            return ListOfBooks.FirstOrDefault(book => book.BookId == bookId);
        }
    }
}
