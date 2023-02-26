using DashBoardT.DAL.entity;
using DashBoardT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> getall();
        TEntity add(TEntity entity);
        TEntity getbyid(params object[] id);
        bool update(TEntity entity);
        bool delete(TEntity entity);
       



    }
}
