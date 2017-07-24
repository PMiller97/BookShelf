using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<book> Books { get; set; } //ICollection is also a navigation property-is what, along with keys, allows me to connect my classes to eachother



    }
}