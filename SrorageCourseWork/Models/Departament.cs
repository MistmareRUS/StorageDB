using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Models
{
    public class Departament
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
    }
}