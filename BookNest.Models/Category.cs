using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNest.Models
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
    }
}
