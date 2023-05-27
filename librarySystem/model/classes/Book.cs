using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.classes
{
    public class Book
    {
        public int ISBN { get; set;}
        public string Name { get; set; }
        public string  Sypnosis { get; set; }
        public int NPages { get; set; }

        //navigational property
        public int EditorialId { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }

    }
}