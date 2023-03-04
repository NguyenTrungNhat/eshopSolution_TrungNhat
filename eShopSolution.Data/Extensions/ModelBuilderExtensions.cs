using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eshopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eshopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eshopSolution" });
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="vi-VN", Name="Tiếng Việt",IsDefault=true},
                new Language() { Id="en-US", Name="English",IsDefault=false}
                );
            modelBuilder.Entity<Category>().HasData(
                    new Category() 
                    {
                        Id=1, 
                        IsShowOnHome=true,
                        ParentId=null,
                        SortOrder=1,
                        Status=Enums.Status.Active,
                    },
                    new Category()
                    {
                        Id=2,
                        IsShowOnHome = true,
                        ParentId = null,
                        SortOrder = 2,
                        Status = Enums.Status.Active,
                    }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation() {Id=1, CategoryId=1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                    new CategoryTranslation() {Id=2,CategoryId =1, Name = "Man Shirt", LanguageId = "en-US", SeoAlias = "man-shirt", SeoDescription = "The shirt products for man", SeoTitle = "The shirt products for man" },
                    new CategoryTranslation() {Id=3,CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                    new CategoryTranslation() {Id=4,CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product()
                    {
                        Id = 1,
                        DateCreated = DateTime.Now,
                        OriginalPrice = 100000,
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                    }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                    new ProductTranslation()
                    {
                        Id=1,
                        ProductId=1,
                        Name = "Áo sơ mi nam trắng Việt Tiến",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                        SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                        SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                        Details = "Áo sơ mi nam trắng Việt Tiến",
                        Description = "Áo sơ mi nam trắng Việt Tiến"
                    },
                    new ProductTranslation()
                    {
                        Id=2,
                        ProductId=1,
                        Name = "Viet Tien Man T-Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Viet Tien Man T-Shirt",
                        SeoTitle = "Viet Tien Man T-Shirt",
                        Details = "Viet Tien Man T-Shirt",
                        Description = "Viet Tien Man T-Shirt"
                    }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory()
                    {
                        ProductId=1,
                        CategoryId=1
                    }
                
                );

            var roleId = new Guid("1688D3FB-4141-4CDD-9127-670ED67EDA0A");
            var adminId = new Guid("7B8209D5-D3BD-4475-A20A-0EB3A8F4EE82");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id= roleId,
                Name="admin",
                NormalizedName="admin",
                Description = "Administrator role"
            });
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName= "admin",
                Email= "nhatnguyen20102002@gmail.com",
                NormalizedEmail = "nhatnguyen20102002@gmail.com",
                EmailConfirmed= true,
                PasswordHash = hasher.HashPassword(null,"Abcd1234$"),
                SecurityStamp = string.Empty,
                FirsName = "Nguyen",
                LastName = "Nhat",
                Dob = new DateTime(2020,01,31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId= adminId,
            });
        }




    }
}
