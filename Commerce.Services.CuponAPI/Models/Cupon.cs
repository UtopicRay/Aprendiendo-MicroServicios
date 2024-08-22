using System.ComponentModel.DataAnnotations;

namespace Commerce.Services.CuponAPI.Models
{
    public class Cupon
    {
        [Key]
        public int CuponId { get; set; }
        [Required]
        public string CuponCode { get; set; }
        [Required]
        public double MinAmount { get; set; }
        public double DiscountAmount { get; set; }
    }
}
