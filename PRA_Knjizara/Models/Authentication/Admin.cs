using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Authentication
{
    public class Admin : IdentityUser<Guid>
    {

        [StringLength(150)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Ime")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(150)]
        [Display(Name = "Prezime")]
        public string Lastname { get; set; }

    }
}
