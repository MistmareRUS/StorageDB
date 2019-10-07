using StorageProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    static class Program
    {
        public static StorageContext db;
        [STAThread]
        static void Main()
        {
            db = new StorageContext();
            db.Departaments.Load();
            db.Employees.Load();
            db.Products.Load();
            db.Roles.Load();
            db.Storages.Include(s=>s.Products).Load();
            //db.StorageItems.Load();

            var p1 = new Product { Name = "Кирпич глиняный", Discrption = "Кирпич глиняный, пустотелый", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.065 };
            var p2 = new Product { Name = "Кирпич белый", Discrption = "Кирпич белый, декоративный", Units = "шт", Stackable = true, Lenght = 0.25, Width = 0.12, Height = 0.088 };
            var p3 = new Product { Name = "Цемент", Discrption = "Цемент марки 500", Units = "уп", Stackable = true, Lenght = 0.63, Width = 0.5, Height = 0.1 };
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Products.Add(p3);
            db.SaveChanges();
            var s1 = new Storage { Name = "Центральный", Location = "Корпус 5А", Area = 200, Products = new List<StorageItem> {
                new StorageItem {ProductId=1,Count=20 },
                new StorageItem {ProductId=2,Count=10 }
            } };
            var s2 = new Storage { Name = "Сыпучие материалы", Location = "Корпус 11Б", Area = 180, Products = new List<StorageItem> {
                new StorageItem {ProductId=1,Count=5 },
                new StorageItem {ProductId=3,Count=7 }
            } };
            var s3 = new Storage { Name = "Временный", Location = "Корпус 2.Подвал", Area = 180, Products = new List<StorageItem> {
                new StorageItem {ProductId=2,Count=50 },
                new StorageItem {ProductId=3,Count=100 }
            } };
            db.Storages.Add(s1);
            db.Storages.Add(s2);
            db.Storages.Add(s3);
            db.SaveChanges();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
