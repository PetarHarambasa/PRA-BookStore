using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Books
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(15)]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Naslov")]
        public string Title { get; set; }
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Žanr")]
        public string Genere { get; set; } //    to dvoje treba rijesit, ne znam kako bi napravio s stranim kljucevima

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Autor")]
        public string Author { get; set; } //

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Cijena")]
        public Int32 Price { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Stanje")]
        public string Condititon { get; set; } 
        public bool Stock { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Sažetak")]
        public string Summary { get; set; } 
    }
}
