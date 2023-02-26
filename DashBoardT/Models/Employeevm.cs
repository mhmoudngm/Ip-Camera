using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.Models
{
    public class Employeevm
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter employee name...")]
        public String name { get; set; }
        [Required(ErrorMessage = "Please enter employee address...")]
        public String address { get; set; }
        [Range(3000, 10000)]
        public float salary { get; set; }
        public String notes { get; set; }
        public String photoname { get; set; }
        public IFormFile photourl { get; set; }
        public String cvname { get; set; }
        public IFormFile cvurl { get; set; }
        public DateTime hiredate { get; set; }
           
        public String departmentid { get; set; }
          


      

}
}
