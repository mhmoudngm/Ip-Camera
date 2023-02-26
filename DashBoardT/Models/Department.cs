using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DashBoardT.Models
{
    public class Department
    {
        public int id { get; set; }
       
        public String departmentname { get; set; }
        
        public String departmentcode { get; set; }

    }
}
