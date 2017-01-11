using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gura.Dal
{
    public class EntityBaseRepository<T> 
        where T : class, new()
    {

        private thedevelopmentstore_guraEntities _context;

        #region Properties
        public EntityBaseRepository(thedevelopmentstore_guraEntities context)
        {
            _context = context;
        }
        #endregion
       
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> AllIncludingAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public virtual void Add(T entity)
        {
            var dbEntityEntry = _context.Entry<T>(entity);
            _context.Set<T>().Add(entity);
        }

        public virtual void Edit(T entity)
        {
            var dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            var dbEntityEntry = _context.Entry<T>(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public virtual void Commit()
        {
            _context.SaveChanges();
        }

        public virtual async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void AddRange(List<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void DeleteRange(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        //public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}
        //public virtual IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> query = _context.Set<T>();
        //    foreach (var includeProperty in includeProperties)
        //    {
        //        query = query.Include(includeProperty);
        //    }
        //    return query.AsEnumerable();
        //}
        //public T GetSingle(Expression<Func<T, bool>> predicate)
        //{
        //    return _context.Set<T>().FirstOrDefault(predicate);
        //}
        //public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        //{
        //    IQueryable<T> query = _context.Set<T>();
        //    foreach (var includeProperty in includeProperties)
        //    {
        //        query = query.Include(includeProperty);
        //    }
        //    return query.Where(predicate).FirstOrDefault();
        //}
        //public virtual IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
        //{
        //    return _context.Set<T>().Where(predicate);
        // }
    }
}
