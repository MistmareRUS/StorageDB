using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StorageDBCourseWork.Models
{
    public class MovingItem
    {
        public int Id { get; set; }
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Display(Name = "Товары")]
        public virtual ICollection<StorageItem> StorageItems { get; set; }
        [Display(Name = "Откуда")]
        public int? StorageFromId { get; set; }
        public virtual Storage StorageFrom { get; set; }
        [Display(Name = "Куда")]
        public int? StorageToId { get; set; }
        public virtual Storage StorageTo { get; set; }

        public int? UserId { get; set; }
        [Display(Name = "Ответственный")]
        public virtual ApplicationUser User { get; set; }

        public MovingItem()
        {
            StorageItems = new List<StorageItem>();
        }
    }
}