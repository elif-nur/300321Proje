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
    public class FirstPageManager : IFirstPageService
    {
        IFirstPageDal _firstPageDal;

        public FirstPageManager(IFirstPageDal firstPageDal)
        {
            _firstPageDal = firstPageDal;
        }
        public void Add(FirstPage firstPage)
        {
            _firstPageDal.Add(firstPage);
        }

        public void Delete(FirstPage firstPage)
        {
            _firstPageDal.Delete(firstPage);
        }

        public FirstPage Get(int firstpageId)
        {
            return _firstPageDal.Get(x => x.Id == firstpageId);
        }

        public List<FirstPage> GetAll()
        {
            return _firstPageDal.GetAll();
        }

        public void Update(FirstPage firstPage)
        {
            _firstPageDal.Update(firstPage);
        }
    }
}
