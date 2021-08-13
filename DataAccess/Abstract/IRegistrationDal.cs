using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRegistrationDal:IEntityRepository<Registration>
    {
        Registration GetMail(Expression<Func<Registration, bool>> filter);
    }
}
