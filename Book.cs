using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Book
    {
        private readonly string _isbn;
        private string _title;
        private string _author;

        public string ISBN => _isbn;
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public Book(string isbn, string title, string author)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Книга: {_title}");
            Console.WriteLine($"Автор: {_author}");
            Console.WriteLine($"ISBN: {_isbn}");
        }
    }
}
