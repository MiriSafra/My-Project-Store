using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreModel.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        public int ProdId { get; set; }//מספר מזהה
        public string Name { get; set; }//שם מוצר
        public int Price { get; set; }//מחיר קניה
        public int Cost { get; set; }//מחיר מכירה
        public int Qty { get; set; }//כמות המוצר במלאי//quantity
    }
}