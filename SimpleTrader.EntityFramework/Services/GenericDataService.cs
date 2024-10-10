using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.EntityFramework.Services
{
    public class GenericDataService<T> : IDataServise<T> where T : DomainObject
    {
        private readonly SimpleTradeDbContextFactory _contextFactory;

        public GenericDataService(SimpleTradeDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (SimpleTraderDBContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (SimpleTraderDBContext context = _contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault(e => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (SimpleTraderDBContext context = _contextFactory.CreateDbContext())
            {
                T entity = context.Set<T>().FirstOrDefault(e => e.Id == id);
                return entity;
            }
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            using (SimpleTraderDBContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (SimpleTraderDBContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
