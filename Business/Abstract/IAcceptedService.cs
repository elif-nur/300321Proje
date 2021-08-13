using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAcceptedService
    {
        void Add(Accepted accepted);
        void Update(Accepted accepted);
        void Delete(Accepted accepted);
        List<Accepted> GetAll();
        Accepted Get(int acceptedId);
    }
}
