using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Model
{
    public class StorageItem
    {
        public int Id { get; set; }
        public string Name => Product.Name;
        public double Count { get; set; }
        public string Units => Product.Units;
        public string Comment { get; set; }

        public int? ProductId { get; set; }
        public Product Product { get; set; }

        public int? StorageId { get; set; }
        public Storage Storage { get; set; }
    }
}
