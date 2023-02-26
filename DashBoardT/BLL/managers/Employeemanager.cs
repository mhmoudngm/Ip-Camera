using DashBoardT.DAL.database;
using DashBoardT.DAL.entity;
using DashBoardT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL.managers
{
    public class Employeemanager:Repository<employee>
    {
        public Employeemanager(Dbcontainer ctx) : base(ctx) { }
    }
}
