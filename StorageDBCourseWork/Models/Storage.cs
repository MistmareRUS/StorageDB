using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StorageDBCourseWork.Models
{
    public class Storage
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Наименование")]
        public string Name { get; set; }


        [Display(Name = "Расположение")]
        public string Location { get; set; }


        [Display(Name = "Площадь")]
        [Required]
        public double Area { get; set; }


        public virtual ICollection<StorageItem> Products { get; set; }

        public Storage()
        {
            Products = new List<StorageItem>();
        }
    }
}