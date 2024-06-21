namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models;

public static class DataSource
{
    public static List<Category> GetCategories()
    {

        return new List<Category>()
        {
            new Category { ProductCategoryID = 1, CategoryName = "Dairy" },
            new Category { ProductCategoryID = 2, CategoryName = "Plant-Based" },
            new Category { ProductCategoryID = 3, CategoryName = "Yogurt" },
        };
    }

    public static List<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product
            {
                ProductID = 1,
                Name = "Fresh Milk",
                Price = 2.99m,
                Quantity = 10,
                Description = "Whole milk from local farms",
                ProductCategoryID = 1,
                ImageUrl = "https://example.com/milk.jpg",
                TotalRating = 4.5m
            },
            new Product
            {
                ProductID = 2,
                Name = "Almond Milk",
                Price = 3.49m,
                Quantity = 5,
                Description = "Unsweetened almond milk",
                ProductCategoryID = 2,
                ImageUrl = "https://example.com/almondmilk.jpg",
                TotalRating = 4.2m
            },
        };
    }
}

