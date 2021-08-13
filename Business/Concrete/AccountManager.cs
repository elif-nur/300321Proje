using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public void Add(Account account)
        {
            _accountDal.Add(account);
        }

        public void Delete(Account account)
        {
            _accountDal.Delete(account);
        }

        public Account Get(int accountId)
        {
            return _accountDal.Get(x => x.Id == accountId);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public void Update(Account account)
        {
            _accountDal.Update(account);
        }
    }
}
