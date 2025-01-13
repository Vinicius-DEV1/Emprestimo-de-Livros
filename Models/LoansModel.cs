using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class LoansModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Write the Receiver")]
        public string Receiver { get; set; }

        [Required(ErrorMessage = "Write the Supplier")]
        public string Supplier { get; set; }

        [Required(ErrorMessage = "Write the borrowed book")]
        public string BorrowedBook { get; set; }

        public DateTime LastUpdate { get; set; } = DateTime.Now;

    }
}
