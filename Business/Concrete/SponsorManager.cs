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
    public class SponsorManager : ISponsorService
    {
        ISponsorDal _sponsorDal;

        public SponsorManager(ISponsorDal sponsorDal)
        {
            _sponsorDal = sponsorDal;
        }

        public void Add(Sponsor sponsor)
        {
            _sponsorDal.Add(sponsor);
        }

        public void Delete(Sponsor sponsor)
        {
            _sponsorDal.Delete(sponsor);
        }

        public Sponsor Get(int sponsorId)
        {
            return _sponsorDal.Get(x => x.Id == sponsorId);
        }

        public List<Sponsor> GetAll()
        {
            return _sponsorDal.GetAll();
        }

        public void Update(Sponsor sponsor)
        {
            _sponsorDal.Update(sponsor);
        }
    }
}
