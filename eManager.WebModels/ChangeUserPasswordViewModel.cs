using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eManager.WebModels
{
    public class ChangeUserPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Внесете ја старата лозинка")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Внесете нова лозинка")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Повторете ја новата лозинка")]
        [Compare("NewPassword",ErrorMessage ="Новата лозинка не се совпаѓа!")]
        public string ConfirmNewPassword { get; set; }
    }
}
