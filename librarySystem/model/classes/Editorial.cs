using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use data annotation 
using System.ComponentModel.DataAnnotations.Schema;

namespace model.classes
{
    public class Editorial
    {
        public int Id { get; set; }
        [Required(ErrorMessage="the name field is required")]
        [MaxLength(45,ErrorMessage="field {0} cannot have more than {1} characters")]
        [MinLength(4,ErrorMessage="field {0} cannot have less than {1} characters")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Tel { get; set; }
        //navigational property
        public List<Book> books { get; set; }
    }
}