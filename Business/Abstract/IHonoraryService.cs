using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHonoraryService
    {
        void Add(Honorary honorary);
        void Update(Honorary honorary);
        void Delete(Honorary honorary);
        List<Honorary> GetAll();
        Honorary Get(int honoraryId);
    }
}
