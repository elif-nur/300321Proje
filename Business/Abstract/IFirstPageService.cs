using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFirstPageService
    {
        void Add(FirstPage firstPage);
        void Update(FirstPage firstPage);
        void Delete(FirstPage firstPage);
        List<FirstPage> GetAll();
        FirstPage Get(int firstpageId);
    }
}
