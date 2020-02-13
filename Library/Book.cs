using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        override public string ToString()
        {
            return Title;
        }
    }
}
