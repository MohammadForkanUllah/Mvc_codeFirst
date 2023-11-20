namespace Exam_7.Migrations
{
    using Exam_7.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exam_7.DAL.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Exam_7.DAL.OrderContext context)
        {
            var categories = new List<Category>
            {
                new Category{CategoryName="HP"},
                new Category{CategoryName="DELL"}
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(c => c.CategoryName, s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{CategoryID=1,ProductName="HP-P-14"},
                new Product{CategoryID=1,ProductName="Hp-p-15"},

                new Product{CategoryID=2,ProductName="DELL-L-20"},
                new Product{CategoryID=2,ProductName="DELL-L-24"}
            };
            products.ForEach(s => context.Products.AddOrUpdate(c => c.ProductName, s));
            context.SaveChanges();
        }
    }
}
