using BasicShopWebAPI.ViewModels.Catalog;
using BasicShopWebAPI.ViewModels.Catalog.Public;
using BasicShopWebAPI.ViewModels.Common;
using System.Threading.Tasks;

namespace BasicShopWebAPI.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
