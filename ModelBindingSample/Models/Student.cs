using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models {
    public class Student {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Must be between 3 and 30 charactors.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Must be between 3 and 30 charactors.")]
        public string LastName { get; set; }
    }
}
