using StorageProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject
{
    public class StorageContext:DbContext
    {
        static StorageContext()
        {
            Database.SetInitializer<StorageContext>(new StorageInitializator());
        }
        public StorageContext():base("StorageConnection")
        {

        }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageItem> StorageItems { get; set; }
    }
    public class StorageInitializator : DropCreateDatabaseAlways<StorageContext>
    {
        //protected override void Seed(StorageContext context)
        //{
        //    var p1 = new Product { Name = "Кирпич глиняный", Discrption = "Кирпич глиняный, пустотелый", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.065 };
        //    var p2 = new Product { Name = "Кирпич белый", Discrption = "Кирпич белый, декоративный", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.088 };
        //    context.Products.Add(p1);
        //    context.Products.Add(p2);
        //    context.Storages.Add(new Storage { Name = "Центральный", Location = "Корпус 5А", Area = 200, Products = new List<Product> { context.Products.FirstOrDefault(p=>p.Name== "Кирпич глиняный") } });
        //    context.Storages.Add(new Storage { Name = "Сыпучие материалы", Location = "Корпус 11Б", Area = 180, Products = new List<Product> { p2 } });
        //    context.Storages.Add(new Storage { Name = "Временный", Location = "Корпус 2.Подвал", Area = 180, Products = new List<Product> { p1,p2 } });
        //}
    }
}
