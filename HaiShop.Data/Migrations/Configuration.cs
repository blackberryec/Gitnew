namespace HaiShop.Data.Migrations
{
    using HaiShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaiShop.Data.HaiShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HaiShop.Data.HaiShopDbContext context)
        {
            CreateProductCategorySample(context);

            //  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new HaiShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new HaiShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "Hai",
            //    Email = "hai.gmail.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Tran nam hai"
            //};

            //manager.Create(user, "123456$");

            //if(!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });

            //}

            //var adminUser = manager.FindByEmail("hai.gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
        }
        private void CreateProductCategorySample(HaiShop.Data.HaiShopDbContext context)
        {
            if(context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory(){ Name = "Điện lạnh" , Alias="dien-lanh", Status=true },
                new ProductCategory(){ Name = "Viễn thông" , Alias="vien-thong", Status=true },
                new ProductCategory(){ Name = "Đồ gia dụng" , Alias="do-gia-dung", Status=true },
                new ProductCategory(){ Name = "Mỹ phẩm" , Alias="my-pham", Status=true },
                new ProductCategory(){ Name = "Điện thoại" , Alias="dien-thoai", Status=true },
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
