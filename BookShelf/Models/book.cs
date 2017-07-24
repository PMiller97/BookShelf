using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookShelf.Models
{
    public class book
    {
        [Key] //<-- primary key
        public int ID { get; set; } //when you are building a model in C#, you ALWAYS want an ID
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] //foreign key is how we establish a relationship with another class (or table)
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } //when you see a line like this, it is called a navigation property

    }
}