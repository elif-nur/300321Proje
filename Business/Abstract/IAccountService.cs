using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountService
    {
        void Add(Account account);
        void Update(Account account);
        void Delete(Account account);
        List<Account> GetAll();
        Account Get(int accountId);
    }
}
