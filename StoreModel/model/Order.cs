using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModel.Model
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Required]
        public int OrdereId { get; set; }
        public Customer customer { get; set; }
        List<ProductInOrder> Products;      
        public DateTime DateOrder { get; set; }
        public int Cost()
        {
            int cost = 0;
            foreach (var p in Products)
            {
                cost += p.QtyProduct * p.Product.Cost;
            }
            return cost;
        }
    }
}
