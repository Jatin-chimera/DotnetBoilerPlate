using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetAllProductAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto couponDto);
        Task<ResponseDto?> DeleteProductsAsync(int id);
    }
}
