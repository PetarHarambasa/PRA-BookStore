using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Transactions
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Račun")]
        public int? ReceiptID { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Knjiga")]
        public int? BookID { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Količina")]
        public string Quantity { get; set; }
    }
}
