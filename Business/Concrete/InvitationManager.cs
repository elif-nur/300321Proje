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
    public class InvitationManager : IInvitationService
    {
        IInvitationDal _invitationDal;

        public InvitationManager(IInvitationDal invitationDal)
        {
            _invitationDal = invitationDal;
        }

        public void Add(Invitation invitation)
        {
            _invitationDal.Add(invitation);
        }

        public void Delete(Invitation invitation)
        {
            _invitationDal.Delete(invitation);
        }

        public Invitation Get(int invitationId)
        {
            return _invitationDal.Get(x => x.Id == invitationId);
        }

        public List<Invitation> GetAll()
        {
            return _invitationDal.GetAll();
        }

        public void Update(Invitation invitation)
        {
            _invitationDal.Update(invitation);
        }
    }
}
