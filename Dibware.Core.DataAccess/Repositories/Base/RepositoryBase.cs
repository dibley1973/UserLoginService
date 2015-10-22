using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Dibware.Core.DataAccess.Contracts;
using Dibware.Helpers.Validation;

namespace Dibware.Core.DataAccess.Repositories.Base
{
    /// <summary>
    /// Represents the base class that all repositories should inherit from
    /// </summary>
    public abstract class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase{TEntity, TKey}"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <exception cref="System.ArgumentNullException">context</exception>
        protected RepositoryBase(DbContext context)
        {
            // Validate arguments
            Guard.ArgumentIsNotNull(context, "context");

            // Cache the data context
            Context = context;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>The context.</value>
        protected DbContext Context { get; private set; }

        #endregion

        #region IRepository<TEntity,TKey> Members

        /// <summary>
        /// Gets the entity specified by the ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public TEntity Get(TKey id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Gets all of the entities.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        /// <summary>
        /// Finds the entity using the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Adds a range of entites.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Removes the range
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        #endregion
    }
}