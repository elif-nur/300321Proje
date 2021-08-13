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
    public class CultureManager : ICultureService
    {
        ICultureDal _cultureDal;

        public CultureManager(ICultureDal cultureDal)
        {
            _cultureDal = cultureDal;
        }

        public void Add(Culture culture)
        {
            _cultureDal.Add(culture);
        }

        public void Delete(Culture culture)
        {
            _cultureDal.Delete(culture);
        }

        public Culture Get(int cultureId)
        {
            return _cultureDal.Get(x => x.Id == cultureId);
        }

        public List<Culture> GetAll()
        {
            return _cultureDal.GetAll();
        }

        public void Update(Culture culture)
        {
            _cultureDal.Update(culture);
        }
    }
}
