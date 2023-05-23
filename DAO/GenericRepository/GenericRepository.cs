using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data;

namespace DAO.GenericRepository
{
    // https://www.codeproject.com/Articles/990492/RESTful-Day-sharp-Enterprise-Level-Application#_Toc418969118/
    // TEntity là template, có thể là bất cứ class nào
    public class GenericRepository<TEntity> where TEntity : class
    {
        //internal DAO.TourManagerDataSet _dataSet;
        internal DbContext _context;
        internal System.Data.Entity.DbSet<TEntity> _entitySet;

        /// <summary>
        /// Aggregration Connection với data set
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(DbContext context)
        {
            _context = context;
            _entitySet = context.Set<TEntity>();
        }


        public virtual IEnumerable<TEntity> Get()
        {
            IQueryable<TEntity> query = _entitySet;
            return query.ToList();
        }

        public virtual TEntity GetByID(object id)
        {
            return _entitySet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _entitySet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _entitySet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _entitySet.Attach(entityToDelete);
            }
            _entitySet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            _entitySet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual IEnumerable<TEntity> GetMany(Func<TEntity, bool> where)
        {
            return _entitySet.Where(where).ToList();
        }

        public virtual IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where)
        {
            return _entitySet.Where(where).AsQueryable();
        }

        public TEntity Get(Func<TEntity, Boolean> where)
        {
            return _entitySet.Where(where).FirstOrDefault<TEntity>();
        }

        public void Delete(Func<TEntity, Boolean> where)
        {
            IQueryable<TEntity> objects = _entitySet.Where<TEntity>(where).AsQueryable();
            foreach (TEntity obj in objects)
                _entitySet.Remove(obj);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _entitySet.ToList();
        }

        public IQueryable<TEntity> GetWithInclude(
                System.Linq.Expressions.Expression<Func<TEntity,
                bool>> predicate, params string[] include)
        {
            IQueryable<TEntity> query = this._entitySet;
            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(predicate);
        }

        public bool Exists(object primaryKey)
        {
            return _entitySet.Find(primaryKey) != null;
        }

        public TEntity GetSingle(Func<TEntity, bool> predicate)
        {
            return _entitySet.Single<TEntity>(predicate);
        }

        public TEntity GetFirst(Func<TEntity, bool> predicate)
        {
            return _entitySet.First<TEntity>(predicate);
        }

        /// <summary>
        /// Discard all changed
        /// </summary>
        public void Refresh()
        {
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }
    }
}
