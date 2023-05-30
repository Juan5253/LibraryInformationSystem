using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //to use data annotation 
using System.ComponentModel.DataAnnotations.Schema;

namespace model.classes
{
    public class Book
    {
        [Key]
        public int ISBN { get; set;}
        [Required(ErrorMessage="the title field is required")]
        [MaxLength(45,ErrorMessage="field {0} cannot have more than {1} characters")]
        [MinLength(4,ErrorMessage="field {0} cannot have less than {1} characters")]
        public string Title { get; set; }
        [Required]
        [StringLength(10)]
        public string  Sypnosis { get; set; }
        public int NPages { get; set; }

        //navigational property
        public int EditorialId { get; set; }
        public List<AuthorBook> AuthorBook { get; set; }

    }
}