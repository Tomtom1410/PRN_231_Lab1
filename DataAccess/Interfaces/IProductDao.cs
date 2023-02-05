using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.DTO;
using BusinessObjects.Models;

namespace DataAccess.Interfaces
{
    public interface IProductDao
    {
        Task<bool> CreateAsync(ProductDto model);
        Task<bool> DeleteAsync(int id);
        Task<List<ProductDto>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<List<CategoryDto>> GetCategoriesAsync();
        Task<bool> UpdateAsync(ProductDto model);
    }
}
