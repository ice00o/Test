using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Test
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool Paperback;
        public Book(string title, string author, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            Paperback = paperBack;
        }
    }

    public delegate void ProcessBookCallback(Book book);

    public class BookDB
    {
        ArrayList list = new ArrayList();
        public void AddBook(string title, string author, decimal price, bool paperback)
        {
            list.Add(new Book(title, author, price, paperback));
        }
        public void ProcessPaperbackBooks(ProcessBookCallback processBook)
        {
            foreach (Book b in list)
            {
                if (b.Paperback)
                    processBook(b);
            }
        }
    }

    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0m;

        internal void AddBookTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.Price;
        }
        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }
    }
}
