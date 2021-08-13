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
    public class SportManager : ISportService
    {
        ISportDal _sportDal;

        public SportManager(ISportDal sportDal)
        {
            _sportDal = sportDal;
        }

        public void Add(Sport sport)
        {
            _sportDal.Add(sport);
        }

        public void Delete(Sport sport)
        {
            _sportDal.Delete(sport);
        }

        public Sport Get(int sportId)
        {
            return _sportDal.Get(x => x.Id == sportId);
        }

        public List<Sport> GetAll()
        {
            return _sportDal.GetAll();
        }

        public void Update(Sport sport)
        {
            _sportDal.Update(sport);
        }
    }
}
