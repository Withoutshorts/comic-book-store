using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookStore.Models
{
    public class ComicBooks
    {

        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public string Description { get; set; }
        public string Artists { get; set; }

        public bool Favorite { get; set; }
    }
}