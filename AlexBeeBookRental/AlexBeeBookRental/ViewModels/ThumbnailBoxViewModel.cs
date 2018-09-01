using AlexBeeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlexBeeBookRental.ViewModels
{
    public class ThumbnailBoxViewModel
    {
        public IEnumerable<ThumbnailModel> Thumbnails { get; set; }
    }
}