using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : IComparable<Book>
    {
        public string Title;

        public string Author;

        public int Pages;

        public Book()
        {

        }

        public Book(string Title, int Pages, string Author="Noname")
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
        }

       int IComparable<Book>.CompareTo(Book other)
        {
            if (other.Equals(null))
            {
                return 1;
            }
            else
            {
                return this.Title.CompareTo(other.Title);
            }
        }

        public static bool operator == (Book a, Book b)
        {
            return a.Title == b.Title; ;
        }

        public static bool operator !=(Book a, Book b)
        {
            if (a.Title == b.Title)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}