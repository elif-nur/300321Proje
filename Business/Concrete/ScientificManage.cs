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
    public class ScientificManager : IScientificService
    {
        IScientificDal _scientificDal;

        public ScientificManager(IScientificDal scientificDal)
        {
            _scientificDal = scientificDal;
        }

        public void Add(Scientific scientific)
        {
            _scientificDal.Add(scientific);
        }

        public void Delete(Scientific scientific)
        {
            _scientificDal.Delete(scientific);
        }

        public Scientific Get(int scientificId)
        {
            return _scientificDal.Get(x => x.Id == scientificId);
        }

        public List<Scientific> GetAll()
        {
            return _scientificDal.GetAll();
        }

        public void Update(Scientific scientific)
        {
            _scientificDal.Update(scientific);
        }
    }
}
