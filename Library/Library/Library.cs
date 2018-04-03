using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        private List<Book> _books;

        public int Count => _books.Count;

        public Library()
        {
            _books = new List<Book>();

            _books.Add(new Book("War and peace", 1000, "Tolstoy"));
            _books.Add(new Book("Idiot", 20, "Dostoevskiy"));
            _books.Add(new Book("Harry Potter", 800, "Rouling"));
            _books.Add(new Book("Idiot", 200, "Dostoevskiy1"));
        }

        public void Sort()
        {
            _books.Sort();
        }
        public void Show()
        {
            Console.WriteLine("----------------------");
            foreach (var book in _books)
            {
                Console.WriteLine($"Title: {book.Title}; Autor: {book.Author}; Pages: {book.Pages}");
            }
            Console.WriteLine("----------------------");
        }

        public void Add(string Title, int Pages, string Author = "Noname")
        {
            _books.Add(new Book(Title, Pages, Author));
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(int Index)
        {
            try
            {
                _books.RemoveAt(Index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Warning: " + e.Message);
            }
        }

        public void Remove(string Title)
        {
            //for (int i = 0; i < _books.Count; i++)
            //{
            //    if (_books[i].Title.Equals(Title))
            //    {
            //        _books.RemoveAt(i);
            //    }
            //}.
            _books.RemoveAll(el => el.Title == Title);
        }
    }
}