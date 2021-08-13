using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICultureService
    {
        void Add(Culture culture);
        void Update(Culture culture);
        void Delete(Culture culture);
        List<Culture> GetAll();
        Culture Get(int cultureId);
    }
}
