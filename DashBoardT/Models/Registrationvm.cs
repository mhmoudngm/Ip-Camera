using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DashBoardT.Models
{
    public class Registrationvm
    {
        [Required(ErrorMessage ="Mail is required")]
        [EmailAddress(ErrorMessage ="you must enter valid email")]
        public String email { get; set; }
        [Required(ErrorMessage = "this field required")]
        [MinLength(3,ErrorMessage ="min length is 3 characters")]
        [DataType(DataType.Password)]
        public String password { get; set; }
        [Required(ErrorMessage = "this field required")]
        [MinLength(3, ErrorMessage = "min length is 3 characters")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Not matching !!")]
        [Display(Name ="confirm password")]
        public String confirmpassword { get; set; }
    }
}
