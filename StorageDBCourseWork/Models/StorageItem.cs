﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StorageDBCourseWork.Models
{
    public class StorageItem
    {
        public int Id { get; set; }


        [Display(Name = "Наименование")]
        public string Name => Product.Name;


        [Display(Name = "Количество")]
        public double Count { get; set; }


        [Display(Name = "Ед. измерения")]
        public string Units => Product.Units;


        [Display(Name = "Комментарий")]
        public string Comment { get; set; }


        public int? MovingItemId { get; set; }
        public virtual MovingItem MovingItem { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }


        public int? StorageId { get; set; }

        public virtual Storage Storage { get; set; }
    }
}