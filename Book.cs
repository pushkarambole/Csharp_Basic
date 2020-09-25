using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCreation
{
    class Book
    {
        private string bookName;
        public static int count;
        public Book(string val1)
        {
            BookName = val1;
        }

        public static void StaticExample()
        {
            Console.WriteLine("Static call test");
        }
        public string BookName
        {
            get{ return bookName; }
            set { bookName = value; }

        }
    }
}
