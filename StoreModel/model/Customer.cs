using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required]
        public int CustId { get; set; }
        [MaxLength(25)]
        [MinLength(2)]
        public string Name { get; set; }
        public string Adress { get; set; }
        //[RegularExpression("^(0(\\d ?){9})", ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        //public ICollection<Order> Orders { get; set; }
    }
}
