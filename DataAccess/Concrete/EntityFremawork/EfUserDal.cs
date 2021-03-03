using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<UserDetailsDto> GetUserDetails()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from user in context.Users
                             join customer in context.Custormers
                             on user.Id equals customer.UserId
                             select new UserDetailsDto { UserId = user.Id,FirsName=user.FirstName,LastName=user.LastName,
                             CompanyName=customer.CompanyName,Email=user.Email
                             };
                return result.ToList();
            }
        }
    }
}
