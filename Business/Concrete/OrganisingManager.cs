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
    public class OrganisingManager : IOrganisingService
    {
        IOrganisingDal _organisingDal;

        public OrganisingManager(IOrganisingDal organisingDal)
        {
            _organisingDal = organisingDal;
        }

        public void Add(Organising organising)
        {
            _organisingDal.Add(organising);
        }

        public void Delete(Organising organising)
        {
            _organisingDal.Delete(organising);
        }

        public Organising Get(int organisingId)
        {
            return _organisingDal.Get(x => x.Id == organisingId);
        }

        public List<Organising> GetAll()
        {
            return _organisingDal.GetAll();
        }

        public void Update(Organising organising)
        {
            _organisingDal.Update(organising);
        }
    }
}
