using SrorageCourseWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Repositories
{
    public class StorageContext:DbContext
    {
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageItem> StorageItems { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
    public class StorageInitializer : DropCreateDatabaseAlways<StorageContext>
    {
        protected override void Seed(StorageContext context)
        {
            context.Products.Add(new Product { Name = "Кирпич глиняный", Discrption = "Кирпич глиняный, пустотелый", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.065 });
            context.Products.Add(new Product { Name = "Кирпич белый", Discrption = "Кирпич белый, декоративный", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.088 });
            context.Products.Add(new Product { Name = "Цемент", Discrption = "Цемент марки 500", Units = "уп", Stackable = true, Lenght = 0.63, Width = 0.5, Height = 0.1 });

            context.Storages.Add( new Storage { Name = "Основной", Location = "Ленина 10", Area = 200.0, Products = new List<StorageItem>() });
            context.Storages.Add(new Storage { Name = "Дополнителный", Location = "Фрунзе 11А", Area = 130.0, Products = new List<StorageItem>() });
            context.Storages.Add(new Storage { Name = "Дальний", Location = "Продольная 45/8", Area = 173.5, Products = new List<StorageItem>() });




            base.Seed(context);
        }
    }
}