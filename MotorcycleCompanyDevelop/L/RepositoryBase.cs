﻿using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext Context { get; set; }
        public RepositoryBase(RepositoryContext context)
        {
            this.Context = context;
        }

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                Context.Set<T>()
                .AsNoTracking()
            : Context.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
                Context.Set<T>()
                .Where(expression)
                .AsNoTracking()
            : Context.Set<T>()
                .Where(expression);


        public void Create(T entity) => Context.Set<T>().Add(entity);
        public void Update(T entity) => Context.Set<T>().Update(entity);
        public void Delete(T entity) => Context.Set<T>().Remove(entity);

    }
}
