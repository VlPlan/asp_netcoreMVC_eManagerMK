using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace eManager.WebModels
{
    public class EditUserRoleViewModel
    {
        public EditUserRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage="Мора да внесете име на тикет за авторизација")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
