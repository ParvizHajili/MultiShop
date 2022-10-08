﻿using Core.Entities;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity
        where TContext : IdentityDbContext<User>, new()
    {
        public void Add(TEntity entity)
        {
            using var _context = new TContext();
            var addEntity = _context.Entry(entity);
            addEntity.State = EntityState.Added;

            _context.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
            using var _context = new TContext();
            var deleteEntity = _context.Entry(entity);
            deleteEntity.State = EntityState.Deleted;

            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var _context = new TContext();
            return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using var _context = new TContext();
            return filter==null 
                ? _context.Set<TEntity>().ToList() :_context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            using var _context = new TContext();
            var updateEntity = _context.Entry(entity);
            updateEntity.State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
