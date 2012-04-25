﻿using System;
using System.ComponentModel.DataAnnotations;

namespace KendoGridBinder.Examples.Models
{
    public class Employee
    { 
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int EmployeeNumber { get; set; }

        public DateTime HireDate { get; set; }

        public bool Active { get; set; }
    }
}