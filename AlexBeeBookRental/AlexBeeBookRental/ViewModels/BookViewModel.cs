using AlexBeeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexBeeBookRental.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Book Book { get; set; }
    }
}