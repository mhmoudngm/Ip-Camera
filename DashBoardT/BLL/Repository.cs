using DashBoardT.DAL.database;
using DashBoardT.DAL.entity;
using DashBoardT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly Dbcontainer _ctx ;
        private DbSet<TEntity> _set;
        public Repository(Dbcontainer ctx)
            {
            this._ctx=ctx;
            _set=_ctx.Set<TEntity>();
            }
        public TEntity add(TEntity entity)
        {
             _set.Add(entity);
            return _ctx.SaveChanges() > 0 ? entity : null;
        }

        public bool delete(TEntity entity)
        {
           
            _set.Remove(entity);
            return _ctx.SaveChanges() > 0;
        }

       

        public IQueryable<TEntity> getall()
        {
            return _set;
        }

        public TEntity getbyid(params object[] id)
        {
            return _set.Find(id);
        }

        public bool update(TEntity entity)
        {
            _set.Attach(entity);
            _ctx.Entry(entity).State = EntityState.Modified;
            return _ctx.SaveChanges() > 0;

        }
    }
}
