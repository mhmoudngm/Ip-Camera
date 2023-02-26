using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashBoardT.DAL.entity
{
    [Table("employee")]
    public class employee
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Please enter employee name...")]
        public String  name { get; set; }
        [Required(ErrorMessage = "Please enter employee address...")]
        public String address { get; set; }
        [Range(3000,10000)]
        public float salary { get; set; }
        public String notes { get; set; }
        public String photoname { get; set; }
        public String cvname { get; set; }
        public DateTime hiredate { get; set; }
        [ForeignKey("departmentid")]
        public int departmentid { get; set; }
        public department department { get; set; }

    }
}
