using BasicShopWebAPI.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShopWebAPI.ViewModels.Catalog.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }

    }
}
