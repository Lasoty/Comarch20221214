﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Data.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Autor { get; set; }

        public string Title { get; set; }

        public int PageCount { get; set; }

        public bool IsBorrowed { get; set; }

        public bool IsRemoved { get; set; }

        public Customer Borrower { get; set; }
    }
}
