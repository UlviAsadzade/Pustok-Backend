using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [StringLength(maximumLength: 100)]
        public string Title1 { get; set; }

        [StringLength(maximumLength: 100)]
        public string Title2 { get; set; }

        [StringLength(maximumLength: 100)]
        public string Subtitle { get; set; }

        [StringLength(maximumLength: 100)]
        public string RedirectUrl { get; set; }

        [StringLength(maximumLength: 100)]
        public string UrlText { get; set; }

        public int Order { get; set; }
    }
}
