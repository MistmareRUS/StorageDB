using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SrorageCourseWork.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public int? DepartmentId { get; set; }
        public Departament Departament { get; set; }
        public Employee()
        {
            Roles = new List<Role>();
        }
    }
}