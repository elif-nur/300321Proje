using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInvitationService
    {
        void Add(Invitation invitation);
        void Update(Invitation invitation);
        void Delete(Invitation invitation);
        List<Invitation> GetAll();
        Invitation Get(int invitationId);
    }
}
