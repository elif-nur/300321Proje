using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRegistrationService
    {
        bool Add(Registration registration);
        void Update(Registration registration);
        void Delete(Registration registration);
        List<Registration> GetAll();
        Registration Get(int registrationId);
        Registration GetMail(string mail);

    }
}
