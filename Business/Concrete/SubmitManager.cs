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
    public class SubmitManager : ISubmitService
    {
        ISubmitDal _Submit;

        public SubmitManager(ISubmitDal submit)
        {
            _Submit = submit;
        }

        public void Add(Submit submit)
        {
            _Submit.Add(submit);
            
        }

        public void Delete(Submit submit)
        {
            _Submit.Delete(submit);
        }

        public Submit Get(int submitId)
        {
            return _Submit.Get(x => x.Id == submitId);
        }

        public List<Submit> GetAll()
        {
            return _Submit.GetAll();
        }

        public void Update(Submit submit)
        {
            _Submit.Update(submit); 
        }
    }
}
