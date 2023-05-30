using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.classes
{
    public class AuthorBook
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookISBN { get; set; }
        public Author author { get; set; }
        public Book book { get; set; }
    }
}