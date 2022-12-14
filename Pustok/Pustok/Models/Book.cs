using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }

        [Required]
        public double CostPrice { get; set; }

        [Required]
        public double SalePrice { get; set; }

        [Required]
        public double DiscountPrice { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public bool IsNew { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        [Required]
        public int Rate { get; set; }

        [Required]
        public int PageCount { get; set; }

        [StringLength(maximumLength: 300)]
        public string InfoText { get; set; }

        [StringLength(maximumLength: 1500)]
        public string Desc { get; set; }

        [Required]
        [StringLength(maximumLength: 20)]
        public string Code { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }

        public List<BookTag> BookTags { get; set; }

        public List<BookImage> BookImages { get; set; }


    }
}
