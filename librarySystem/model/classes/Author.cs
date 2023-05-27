using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.classes
{
    public class Author
    {
        /*The framework allows you to work with properties, instead of using attributes and methods.*/
        public int Id { get; set;}
        public string Name { get; set; }
        public string LastName { get; set; }
        //navigational property
        public List<AuthorBook> AuthorBook { get; set; }

    }
}