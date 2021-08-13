using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFullSubmitService
    {
        void Add(FullSubmit fullSubmit);
        void Update(FullSubmit fullSubmit);
        void Delete(FullSubmit fullSubmit);
        List<FullSubmit> GetAll();
        FullSubmit Get(int fullSubmitId);
    }
}
