using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Models;
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

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User Get(int userId)
        {
            return _userDal.Get(x => x.Id == userId);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
        public UserModels Find(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("kullanıcı adı boş geçilemez");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("parola boş geçilemez");
            }
            var user = _userDal.Find(username, password);
            if (user == null)
            {
                throw new Exception("kullanıcı adı ya da parola yanlış");
            }
            else
            {
                return new UserModels
                {
                    Username = user.Username,
                    Password = user.Password,
                    Id = user.Id

                };
            }
        }
    }
}
