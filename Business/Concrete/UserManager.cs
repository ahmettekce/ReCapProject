using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal user)
        {
            _userDal = user;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Message.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Message.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Message.CarListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Message.UserUpdated);
        }
    }
}
