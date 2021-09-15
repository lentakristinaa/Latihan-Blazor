using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages 
{
    public partial class EmployeePage 
    {
        public IEnumerable <Employee> Employees { get; set; }
        
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Lenta",
                LastName="Sianturi",
                Email="lenta.kristina@si.ukdw.ac.id",
                DateOfBirth = new DateTime(2001,12,05),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=1,DepartmentName="CEO"},
                PhotoPath = "images/lenta.jpg"
            };

             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Shawn",
                LastName="Mendes",
                Email="Shawnmendes@gmail.com",
                DateOfBirth = new DateTime(1998,8,8),
                Gender = Gender.Male,
                Department = new Department{DepartmentId=2,DepartmentName="Human Resource"},
                PhotoPath = "images/shawn.jpg"
                  };
                  
             Employee e3 = new Employee{
                EmployeeId=3,
                FirstName="Ariana",
                LastName="Grande",
                Email="Arianagrande@gmail.com",
                DateOfBirth = new DateTime(1993,06,26),
                Gender = Gender.Female,
                Department = new Department{DepartmentId=2,DepartmentName="IT"},
                PhotoPath = "images/ariana.jpg"
                   };

                   Employees = new List<Employee>{e1,e2,e3};
        }
    }
}