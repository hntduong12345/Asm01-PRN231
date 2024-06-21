using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models
{
    public class Category
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
