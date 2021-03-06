﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
// using System.DataValidation.Annotation;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        //[ValidateComplextype]
        public virtual Department Department { get; set; } = new Department();
    }
}
