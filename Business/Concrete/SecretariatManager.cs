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
    public class SecretariatManager : ISecretariatService
    {
        ISecretariatDal _secretariatDal;

        public SecretariatManager(ISecretariatDal secretariatDal)
        {
            _secretariatDal = secretariatDal;
        }

        public void Add(Secretariat secretariat)
        {
            _secretariatDal.Add(secretariat);
        }

        public void Delete(Secretariat secretariat)
        {
            _secretariatDal.Delete(secretariat);
        }

        public Secretariat Get(int secretariatId)
        {
            return _secretariatDal.Get(x => x.Id == secretariatId);
        }

        public List<Secretariat> GetAll()
        {
            return _secretariatDal.GetAll();
        }

        public void Update(Secretariat secretariat)
        {
            _secretariatDal.Update(secretariat);
        }
    }
}
