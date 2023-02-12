using System.ComponentModel.DataAnnotations;


namespace ApiProject.Core.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
