﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
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
