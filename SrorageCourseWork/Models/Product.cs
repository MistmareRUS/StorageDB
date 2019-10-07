using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Models
{

    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Discrption { get; set; }
        [Display(Name = "Ед. измерения")]
        public string Units { get; set; }
        public virtual ICollection<ProductType> ProductType { get; set; }
        public virtual ICollection<StorageItem> StorageItems { get; set; }
        [Display(Name = "Длина")]
        public double Lenght { get; set; }
        [Display(Name = "Ширина")]
        public double Width { get; set; }
        [Display(Name = "Высота")]
        public double Height { get; set; }
        [Display(Name = "Складируемость")]
        public bool Stackable { get; set; }
        public Product()
        {
            ProductType = new List<ProductType>();
            StorageItems = new List<StorageItem>();
        }
    }
    public enum ProductType
    {
        Fragile,
        DoNotTurn
    }
}