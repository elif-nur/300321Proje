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
    public class RegistrationManager : IRegistrationService
    {
        IRegistrationDal _registrationDal;

        public RegistrationManager(IRegistrationDal registrationDal)
        {
            _registrationDal = registrationDal;
        }
        public bool Add(Registration registration)
        {
            var result = _registrationDal.GetMail(x => x.Email == registration.Email);
            if (result != null)
            {
                //throw new Exception("Aynı mail adresi ile başvuru yapılamaz");
                return false;
            }
            else
            {
                _registrationDal.Add(registration);
                return true;
            }
        }

        public void Delete(Registration registration)
        {
            _registrationDal.Delete(registration);
        }

        public Registration Get(int registrationId)
        {
            return _registrationDal.Get(x => x.Id == registrationId);
        }

        public List<Registration> GetAll()
        {
            return _registrationDal.GetAll();
        }

        public Registration GetMail(string mail)
        {
            return _registrationDal.GetMail(x => x.Email == mail);
           
        }

        public void Update(Registration registration)
        {
            _registrationDal.Update(registration);
        }
    }
}
