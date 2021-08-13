using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISportService
    {
        void Add(Sport sport);
        void Update(Sport sport);
        void Delete(Sport sport);
        List<Sport> GetAll();
        Sport Get(int sportId);
    }
}
