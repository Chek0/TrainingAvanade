﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Books
{
    public class BookService : IBookService
    {
        public IEnumerable<Book> Get()
        {
            for (int i = 0; i < 5; i++)
                yield return new Book { Id = 1, ISBN = "XXX-111", Name = $"Book {i}", Author = $"Author {i}" };
        }
    }
}
