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
    public class HonoraryManager : IHonoraryService
    {
        IHonoraryDal _honoraryDal;

        public HonoraryManager(IHonoraryDal honoraryDal)
        {
            _honoraryDal = honoraryDal;
        }

        public void Add(Honorary honorary)
        {
            _honoraryDal.Add(honorary);
        }

        public void Delete(Honorary honorary)
        {
            _honoraryDal.Delete(honorary);
        }

        public Honorary Get(int honoraryId)
        {
            return _honoraryDal.Get(x => x.Id == honoraryId);
        }

        public List<Honorary> GetAll()
        {
            return _honoraryDal.GetAll();
        }

        public void Update(Honorary honorary)
        {
            _honoraryDal.Update(honorary);
        }
    }
}
