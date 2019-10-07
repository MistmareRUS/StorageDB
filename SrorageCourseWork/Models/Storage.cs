using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Models
{
    public class Storage
    {
        public int Id { get; set; }
        [Display(Name ="Наименование")]
        public string Name { get; set; }
        [Display(Name = "Расположение")]
        public string Location { get; set; }
        [Display(Name = "Площадь")]
        public double Area { get; set; }
        public virtual ICollection<StorageItem> Products { get; set; }
        public Storage()
        {
            Products = new List<StorageItem>();
        }
    }
}