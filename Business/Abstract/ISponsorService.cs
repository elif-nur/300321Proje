using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISponsorService
    {
        void Add(Sponsor sponsor);
        void Update(Sponsor sponsor);
        void Delete(Sponsor sponsor);
        List<Sponsor> GetAll();
        Sponsor Get(int sponsorId);
    }
}
