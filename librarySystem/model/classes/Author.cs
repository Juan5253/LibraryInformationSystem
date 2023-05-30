using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use data annotation 
using System.ComponentModel.DataAnnotations.Schema;

namespace model.classes
{
    public class Author
    {
        /*The framework allows you to work with properties, instead of using attributes and methods.*/
        public int Id { get; set;}
        [Required(ErrorMessage="the name field is required")]
        [MaxLength(45,ErrorMessage="field {0} cannot have more than {1} characters")]
        [MinLength(4,ErrorMessage="field {0} cannot have less than {1} characters")]
        public string Name { get; set; }
        [Required(ErrorMessage="the last name field is required")]
        [MaxLength(45,ErrorMessage="field {0} cannot have more than {1} characters")]
        [MinLength(4,ErrorMessage="field {0} cannot have less than {1} characters")]
        public string LastName { get; set; }
        //navigational property
        public List<AuthorBook> AuthorBook { get; set; }

    }
}