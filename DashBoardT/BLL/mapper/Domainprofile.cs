using AutoMapper;
using DashBoardT.DAL.entity;
using DashBoardT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL.mapper
{
    public class Domainprofile:Profile
    {
      public  Domainprofile()
        {
            CreateMap<employee, Employeevm>();
            CreateMap<Employeevm,employee> ();
        }
    }
}
