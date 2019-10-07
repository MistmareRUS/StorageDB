using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Area { get; set; }
        public virtual ICollection<StorageItem> Products { get; set; }
        public Storage()
        {
            Products = new List<StorageItem>();
        }
    }
}
