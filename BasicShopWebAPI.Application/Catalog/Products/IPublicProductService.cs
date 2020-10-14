using BasicShopWebAPI.Application.Catalog.Products.Dtos;
using BasicShopWebAPI.Application.Catalog.Products.Dtos.Public;
using BasicShopWebAPI.Application.Dtos;
using System.Threading.Tasks;

namespace BasicShopWebAPI.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
