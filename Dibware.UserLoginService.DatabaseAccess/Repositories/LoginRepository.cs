using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dibware.UserLoginService.CommandService.Contracts;
using Dibware.UserLoginService.DomainEntities;

namespace Dibware.UserLoginService.DatabaseAccess.Repositories
{
    public class LoginRepository : ILoginRepository
    {

        #region IRepository<Login,Guid> Members

        public Login Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Login> Find(Expression<Func<Login, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Login entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Login> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(Login entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Login> entities)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
