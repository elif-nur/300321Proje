using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubmitService
    {
        void Add(Submit submit);
        void Update(Submit submit);
        void Delete(Submit submit);
        List<Submit> GetAll();
        Submit Get(int submitId);
    }
}
