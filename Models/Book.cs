﻿using Microsoft.AspNetCore.Http;
using System;

namespace BooksApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public string Image { get; set; }

        public Book()
        {

        }
    }
}