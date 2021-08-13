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
    public class WritingManager : IWritingService
    {
        IWritingDal _writingDal;

        public WritingManager(IWritingDal writingDal)
        {
            _writingDal = writingDal;
        }

        public void Add(Writing writing)
        {
            _writingDal.Add(writing);
        }

        public void Delete(Writing writing)
        {
            _writingDal.Delete(writing);
        }

        public Writing Get(int writingId)
        {
            return _writingDal.Get(x => x.Id == writingId);
        }

        public List<Writing> GetAll()
        {
            return _writingDal.GetAll();
        }

        public void Update(Writing writing)
        {
            _writingDal.Update(writing);
        }
    }
}
