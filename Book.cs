using System;
using System.Collections.Generic;

namespace ConstructingObjects
{
    public class Book
    {
        public string Title { get; set; }
        public IEnumerable<string> Authors { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
    }
}
