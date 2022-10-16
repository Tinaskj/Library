using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LevelUpLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookId { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }

        

        public Book(string title, string author, string bookId, string genre, int pages)
        {
            Title = title;
            Author = author;
            BookId = bookId;
            Genre = genre;
            Pages = pages;
        }

        

    }

}
