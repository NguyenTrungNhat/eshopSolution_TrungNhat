using eshopSolution.ViewModels.Catalog.Products;
using eshopSolution.ViewModels.Catalog.Products.Public;
using eshopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
