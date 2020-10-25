using BasicShopWebAPI.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShopWebAPI.ViewModels.Catalog.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
