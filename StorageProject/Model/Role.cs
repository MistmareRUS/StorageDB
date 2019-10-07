using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Model
{
    public class Role
    {
        public int Id { get; set; }
        public virtual ICollection<Access> Accesses { get; set; }
        public Role()
        {
            Accesses = new List<Access>();
        }
    }
    public enum Access
    {
        CreateProduct,
        ReadProduct,
        UpdateProduct,
        DeleteProduct,
        CreateStorage,
        ReadStorage,
        UpdateStorage,
        DeleteStorage
    }
}
