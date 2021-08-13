using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrganisingService
    {
        void Add(Organising organising);
        void Update(Organising organising);
        void Delete(Organising organising);
        List<Organising> GetAll();
        Organising Get(int organisingId);
    }
}
