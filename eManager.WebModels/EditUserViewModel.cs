using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eManager.WebModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string FullName { get; set; }
        public List<string> Claims { get; set; }
        public IList<string> Roles { get; set; }
    }
}
