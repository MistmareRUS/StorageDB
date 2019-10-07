using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discrption { get; set; }
        public string Units { get; set; }        
        public virtual ICollection<ProductType> ProductType { get; set; }
        public virtual ICollection<StorageItem> StorageItems { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public bool Stackable { get; set; }
        public Product()
        {
            ProductType = new List<ProductType>();
            StorageItems = new List<StorageItem>();
        }
    }
}
public enum ProductType
{
    Fragile,
    DoNotTurn
}

