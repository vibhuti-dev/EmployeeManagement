﻿using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IMapper Mapper { get; set; }


        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();
        public List<Department> Departments { get; set; } = new List<Department>();
        [Parameter]
        public string Id { get; set; }

        //protected async override Task OnInitializedAsync()
        //{
        //    Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        //    Departments = (await DepartmentService.GetDepartments()).ToList();
        //    // DepartmentID = Employee.DepartmentId.ToString();
        //    // base.OnInitialized();
        //}

        protected async override Task OnInitializedAsync()
        {
            
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
            // DepartmentID = Employee.DepartmentId.ToString();
            // base.OnInitialized();
        }

        protected void HandleValidSubmit() { }
    }
}
