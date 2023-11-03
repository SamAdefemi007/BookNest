using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNest.Models
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string CoverImageUrl { get; set; }

        public int StockQuantity { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required]

        public DateOnly PublishedDate { get; set; }
    }
}
