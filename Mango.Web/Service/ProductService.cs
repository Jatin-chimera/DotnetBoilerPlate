using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        public readonly IBaseService _baseService;
        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateProductsAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIbase + "/api/product"
            });
        }

        public async Task<ResponseDto?> DeleteProductsAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = Utility.SD.ApiType.DELETE,
                Url = SD.ProductAPIbase + "/api/product/" + id
            });
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.ProductAPIbase + "/api/product" 
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.ProductAPIbase + "/api/product/" + id
            });
        }

        public async  Task<ResponseDto?> UpdateProductsAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = Utility.SD.ApiType.PUT,
                Data = productDto,
                Url = SD.ProductAPIbase + "/api/product"
            });
        }
    }
}
