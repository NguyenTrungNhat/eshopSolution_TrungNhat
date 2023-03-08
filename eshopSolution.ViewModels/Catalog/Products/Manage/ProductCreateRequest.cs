using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshopSolution.ViewModels.Catalog.Products.Manage
{
    public class ProductCreateRequest
    {
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string LanguageId { get; set; }

        public string SeoAlias { get; set; }
        //formfile chứa thông tin các ảnh
        public IFormFile ThumbnailImage { get; set; }
    }
}
