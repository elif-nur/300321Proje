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
    public class AcceptedManager : IAcceptedService
    {
        IAcceptedDal _acceptedDal;

        public AcceptedManager(IAcceptedDal acceptedDal)
        {
            _acceptedDal = acceptedDal;
        }

        public void Add(Accepted accepted)
        {
            _acceptedDal.Add(accepted);
        }

        public void Delete(Accepted accepted)
        {
            _acceptedDal.Delete(accepted);
        }

        public Accepted Get(int acceptedId)
        {
            return _acceptedDal.Get(x => x.Id == acceptedId);
        }

        public List<Accepted> GetAll()
        {
            return _acceptedDal.GetAll();
        }

        public void Update(Accepted accepted)
        {
            _acceptedDal.Update(accepted);
        }
    }
}
