using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.UserName.Length < 2 ||
                user.UserPassword.Length < 2 ||
                user.Name.Length<2 ||
                user.Surname.Length<2 ||
                user.UserTelephone.Length<10 ||
                user.UserMail.Length<2)
            {
                return new ErrorResult(Messages.UserRegInfo);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }


        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessDataResult<User>(Messages.UserUpdated);
        }

        IDataResult<List<User>> IUserService.GetAllByUserTypeId(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.UserTypeID == id));
        }

        public IDataResult<User> GetByNameAndPw(string userName,string userPw)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserName == userName && u.UserPassword == userPw));
        }
    }
}
