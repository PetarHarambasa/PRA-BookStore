using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Transactions
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ReceiptNum { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Korisnik")]
        public int User { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [StringLength(15)]
        [Display(Name = "Način plaćanja")]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Blagajnik")]
        public int Employee { get; set; } //FIXME: strani kljuceviiii

        public DateTime ReceiptDate { get; set; }

    }
}
