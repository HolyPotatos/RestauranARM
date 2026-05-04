using System.ComponentModel.DataAnnotations;

namespace ARM.Data.Entities
{
    public class SeatTable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(5)]
        public string TableNumber { get; set; } = null!;
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int StatusID { get; set; }
        public virtual TableStatus? Status { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
        public virtual ICollection<CustomerOrder>? CustomerOrders { get; set; }
    }
}
