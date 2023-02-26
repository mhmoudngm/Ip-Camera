using DashBoardT.DAL.database;
using DashBoardT.DAL.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL.managers
{
    public class Departmentmanager : Repository<department>
    {
        public Departmentmanager(Dbcontainer ctx ): base(ctx) { }
    }
}
