using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextBox_Validation_MVC.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
    }
}