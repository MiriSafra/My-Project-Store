using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Model
{
    [Table("ProductInOrder")]
    public class ProductInOrder
    {
        [Key]
        [Required]
        public int Code { get; set; }
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order  Order{ get; set; }
        public int QtyProduct { get; set; }
    }
}
