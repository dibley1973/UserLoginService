using System;
using Dibware.Core.DataAccess.Contracts;
using Dibware.UserLoginService.DomainEntities;

namespace Dibware.UserLoginService.CommandService.Contracts
{
    public interface ILoginRepository : IRepository<Login, Guid>
    {
         
    }
}