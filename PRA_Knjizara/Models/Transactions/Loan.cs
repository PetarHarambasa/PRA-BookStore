using System.ComponentModel.DataAnnotations;

namespace PRA_Knjizara.Models.Transactions
{
    public class Loan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Korisnik")]
        public int? UserID { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Knjiga")]
        public int? BookID { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Datum posudbe")]
        public DateTime BorrowDate { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Rok vraćanja")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Posudbina")]
        public double LoanFee { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Zakasnina")]
        public double LateFee { get; set; }

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Račun")]
        public int? ReceiptID { get; set; } //FIXME: strani kljuceviiii

        [Required(ErrorMessage = "Ovo je polje obavezno.")]
        [Display(Name = "Knjiga vraćena")]
        public bool IsReturned { get; set; }
    }
}
