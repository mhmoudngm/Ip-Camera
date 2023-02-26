using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashBoardT.BLL.managers;
using DashBoardT.DAL.database;
namespace DashBoardT.BLL
{
    public class Unitofwork
    {
        private Dbcontainer ctx ;
        public Unitofwork (Dbcontainer ctx)
        {
            this.ctx = ctx;
        }
        public Departmentmanager Departmentmanager
        {
            get
            {
                return new Departmentmanager(ctx);
            }
        }
        public Employeemanager Employeemanager
        {
            get
            {
                return new Employeemanager(ctx);
            }
        }
        public bool save()
        {
            return ctx.SaveChanges() > 0;
        }
    }
}
