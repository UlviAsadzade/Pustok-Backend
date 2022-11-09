using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }

        public List<Book> Books { get; set; }

    }
}
