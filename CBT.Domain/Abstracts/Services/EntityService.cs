﻿using CBT.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CBT.Domain.Abstracts.Services
{
    internal abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        protected CBTDbContext _context = new CBTDbContext();
        //protected IContext _context;
        protected DbSet<T> _dbset;
        public EntityService(CBTDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public virtual async Task<T> GetByIdAsync(int Id)
        {
            var entity = await _dbset.FindAsync(Id);
            if (entity == null)
                return default(T);
            else
                return entity;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            if (entity == null) throwError();
            _context.Entry(entity).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            if (entity == null) throwError();
            _dbset.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            if (entity == null) throwError();
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsQueryable<T>();
        }

        void throwError()
        {
            throw new ArgumentNullException("entity", "can't pass a null object to this method");
        }
    }
}
