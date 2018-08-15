using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public int NumberOfStock { get; set; }

        public int NumberAvailable { get; set; }

        [Display(Name = "Genre")]
        public MovieGenre MovieGenre { get; set; }

        [Display(Name = "Genre")]
        public int MovieGenreId { get; set; }
    }
}