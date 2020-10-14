using BasicShopWebAPI.Application.Catalog.Products.Dtos;
using BasicShopWebAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShopWebAPI.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
