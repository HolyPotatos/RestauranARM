using System.ComponentModel.DataAnnotations;

namespace ARM.Data.Entities
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [MaxLength(50)]
        public string? MiddleName { get; set; }
        [Required]
        [MaxLength(16)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string Login { get; set; } = null!;
        [Required]
        [MaxLength(60)]
        public string PasswordHash { get; set; } = null!;
        [Required]
        public int EmployeeTitleID { get; set; }
        public virtual EmployeeTitle? EmployeeTitle { get; set; }
        public virtual ICollection<CustomerOrder>? CustomerOrders { get; set; }
    }
}
