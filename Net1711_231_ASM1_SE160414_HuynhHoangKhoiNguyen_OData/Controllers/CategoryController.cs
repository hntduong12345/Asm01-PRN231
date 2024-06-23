using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.DTOs;
using Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Models;

namespace Net1711_231_ASM1_SE160414_HuynhHoangKhoiNguyen_OData.Controllers
{
    public class CategoriesController : ODataController
    {
        [EnableQuery] 
        public IActionResult Get()
        {
            var categoryDtos = DataSource.Categories.Select(c => new CategoryDTO
            {
                ProductCategoryID = c.ProductCategoryID,
                CategoryName = c.CategoryName
            });

            return Ok(categoryDtos);
        }

        [HttpGet("odata/Categories/({key})")]
        public IActionResult Get([FromRoute] int key)
        {
            var category = DataSource.Categories.FirstOrDefault(c => c.ProductCategoryID == key);

            if (category is null)
            {
                return NotFound();
            }

            var categoryDto = new CategoryDTO
            {
                ProductCategoryID = category.ProductCategoryID,
                CategoryName = category.CategoryName
            };

            return Ok(categoryDto);
        }

        public IActionResult Post([FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = new Category
            {
                ProductCategoryID = categoryDto.ProductCategoryID,
                CategoryName = categoryDto.CategoryName
            };

            DataSource.Categories.Add(category); 

            return Created(category); 
        }

        public IActionResult Put([FromRoute] int key, [FromBody] CategoryDTO categoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (key != categoryDto.ProductCategoryID)
            {
                return BadRequest("Route key does not match category ID");
            }

            var existingCategory = DataSource.Categories.FirstOrDefault(c => c.ProductCategoryID == key);

            if (existingCategory is null)
            {
                return NotFound();
            }

            existingCategory.CategoryName = categoryDto.CategoryName;

            return NoContent();
        }

        public IActionResult Delete([FromRoute] int key)
        {
            var category = DataSource.Categories.FirstOrDefault(c => c.ProductCategoryID == key);

            if (category is null)
            {
                return NotFound();
            }

            DataSource.Categories.Remove(category); // Remove from in-memory data source

            return NoContent();
        }
    }
}
