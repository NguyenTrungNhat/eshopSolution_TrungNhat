using eshopSolution.ViewModels.Catalog.Products;
using eshopSolution.ViewModels.Catalog.Products.Manage;
using eshopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<int> AddImage(int productId, List<IFormFile> files);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, string caption, bool IsDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
