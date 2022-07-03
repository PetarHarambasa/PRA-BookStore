using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Authentication
{
    public class Role : IdentityRole<Guid>
    {
        [StringLength(550)]
        [Display(Name = "Opis")]
        public string Description { get; set; }
    }
}
