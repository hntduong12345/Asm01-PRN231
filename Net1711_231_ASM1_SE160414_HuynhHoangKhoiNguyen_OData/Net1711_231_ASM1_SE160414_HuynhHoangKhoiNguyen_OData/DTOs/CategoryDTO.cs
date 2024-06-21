using System.ComponentModel.DataAnnotations;

namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.DTOs
{
    public class CategoryDTO
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
