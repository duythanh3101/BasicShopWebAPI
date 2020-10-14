using BasicShopWebAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShopWebAPI.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
