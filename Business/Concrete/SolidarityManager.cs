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
    public class SolidarityManager : ISolidarityService
    {
        ISolidarityDal _solidarityDal;

        public SolidarityManager(ISolidarityDal solidarityDal)
        {
            _solidarityDal = solidarityDal;
        }

        public void Add(Solidarity solidarity)
        {
            _solidarityDal.Add(solidarity);
        }

        public void Delete(Solidarity solidarity)
        {
            _solidarityDal.Delete(solidarity);
        }

        public Solidarity Get(int solidarityId)
        {
            return _solidarityDal.Get(x => x.Id == solidarityId);
        }

        public List<Solidarity> GetAll()
        {
            return _solidarityDal.GetAll();
        }

        public void Update(Solidarity solidarity)
        {
            _solidarityDal.Update(solidarity);
        }
    }
}
