using Core.DataAccess;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserDetailsDto> GetUserDetails();
    }
}
