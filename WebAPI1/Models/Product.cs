using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}