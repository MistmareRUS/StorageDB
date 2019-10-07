using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Display(Name = "Список разрешений")]
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