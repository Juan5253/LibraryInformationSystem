using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace model.classes
{
    public class Editorial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tel { get; set; }
        //navigational property
        public List<Book> books { get; set; }
    }
}