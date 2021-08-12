using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Every Job must have a Name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Every Job must have a Location!")]
        public string Location { get; set; }

        public AddEmployerViewModel() { }
    }
}
