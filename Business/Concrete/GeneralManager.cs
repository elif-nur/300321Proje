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
    public class GeneralManager : IGeneralService
    {
        IGeneralDal _generalDal;

        public GeneralManager(IGeneralDal generalDal)
        {
            _generalDal = generalDal;
        }

        public void Add(General general)
        {
            _generalDal.Add(general);
        }

        public void Delete(General general)
        {
            _generalDal.Delete(general);
        }

        public General Get(int generalId)
        {
            return _generalDal.Get(x => x.Id == generalId);
        }

        public List<General> GetAll()
        {
            return _generalDal.GetAll();
        }

        public void Update(General general)
        {
            _generalDal.Update(general);
        }
    }
}
