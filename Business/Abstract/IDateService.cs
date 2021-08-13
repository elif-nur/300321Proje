using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDateService
    {
        void Add(Date date);
        void Update(Date date);
        void Delete(Date date);
        List<Date> GetAll();
        Date Get(int dateId);
    }
}
