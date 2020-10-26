using BasicShopWebAPI.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicShopWebAPI.ViewModels.Catalog.Public
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
