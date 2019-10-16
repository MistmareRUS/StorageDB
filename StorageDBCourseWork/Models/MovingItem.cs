using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        [Required]
        public int? StorageFromId { get; set; }

        [Display(Name = "Откуда")]
        [ForeignKey("Storage")]
        public virtual Storage StorageFrom { get; set; }


        [Required]
        public int? StorageToId { get; set; }

        [Display(Name = "Куда")]
        [ForeignKey("Storage")]
        public virtual Storage StorageTo { get; set; }


        [Display(Name = "Ответственный")]
        public int? UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public MovingItem()
        {
            StorageItems = new List<StorageItem>();
        }
    }
}