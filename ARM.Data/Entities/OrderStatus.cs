using System.ComponentModel.DataAnnotations;

namespace ARM.Data.Entities
{
    public class OrderStatus
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; } = null!;
        public virtual ICollection<CustomerOrder>? CustomerOrders { get; set; }
    }
}
