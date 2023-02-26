using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.DAL.entity
{
    [Table("department")]
    public class department
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "enter department name...")]
        [MinLength(3, ErrorMessage = "min length 3 characters")]
        public String departmentname { get; set; }
        [Required(ErrorMessage = "enter department code...")]
        public String departmentcode { get; set; }
        public virtual ICollection<employee> employee { get;set;}
    }
}
