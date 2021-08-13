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
    public class FullSubmitManager : IFullSubmitService
    {
        IFullSubmitDal _fullSubmitDal;

        public FullSubmitManager(IFullSubmitDal fullSubmitDal)
        {
            _fullSubmitDal = fullSubmitDal;
        }

        public void Add(FullSubmit fullSubmit)
        {
            _fullSubmitDal.Add(fullSubmit);
        }

        public void Delete(FullSubmit fullSubmit)
        {
            _fullSubmitDal.Delete(fullSubmit);
        }

        public FullSubmit Get(int fullSubmitId)
        {
            return _fullSubmitDal.Get(x => x.Id == fullSubmitId);
        }

        public List<FullSubmit> GetAll()
        {
            return _fullSubmitDal.GetAll();
        }

        public void Update(FullSubmit fullSubmit)
        {
            _fullSubmitDal.Update(fullSubmit);
        }
    }
}
