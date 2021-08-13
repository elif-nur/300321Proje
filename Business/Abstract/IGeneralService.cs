using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGeneralService
    {
        void Add(General general);
        void Update(General general);
        void Delete(General general);
        List<General> GetAll();
        General Get(int generalId);
    }
}
