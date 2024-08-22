namespace Commerce.Services.CuponAPI.Models.Dtos
{
    public class CuponDTO
    {
        public int CuponId { get; set; }
        public string CuponCode { get; set; }
        public double MinAmount { get; set; }
        public double DiscountAmount { get; set; }
    }
}
