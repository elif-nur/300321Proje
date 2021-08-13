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
    public class DateManager : IDateService
    {
        IDateDal _dateDal;

        public DateManager(IDateDal dateDal)
        {
            _dateDal = dateDal;
        }

        public void Add(Date date)
        {
            _dateDal.Add(date);
        }

        public void Delete(Date date)
        {
            _dateDal.Delete(date);
        }

        public Date Get(int dateId)
        {
            return _dateDal.Get(x => x.Id == dateId);
        }

        public List<Date> GetAll()
        {
            return _dateDal.GetAll();
        }

        public void Update(Date date)
        {
            _dateDal.Update(date);
        }
    }
}
