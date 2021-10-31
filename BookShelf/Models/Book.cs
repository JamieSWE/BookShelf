using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        [Key]
        [DisplayName("ISBN")]
        [Required(ErrorMessage ="An ISBN number is required.")]
        public string BookISBN { get; set; }

        [Required(ErrorMessage ="The book's title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage ="A published date is required.")]
        [DisplayName("Publish Date")]
        public DateTimeOffset PublishDate { get; set; }

        [Required(ErrorMessage ="The book amount is required.")]
        public int Quantity { get; set; } 

    }
}
