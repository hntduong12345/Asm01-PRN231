using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int ProductCategoryID { get; set; }
        public string ImageUrl { get; set; }
        public decimal TotalRating { get; set; }
        public virtual Category Category { get; set; }

    }
}
