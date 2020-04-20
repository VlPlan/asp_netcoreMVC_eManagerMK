using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using eManager.Domain;
using Microsoft.AspNetCore.Http;

namespace eManager.WebModels
{
   public class EditEmployeeViewModel:EmployeeViewModel
    {
        public EditEmployeeViewModel(Employee employee)
        {
            Id = employee.Id;
        }

        public EditEmployeeViewModel()
        {

        }
        public int Id { get; set; }




    }
}
